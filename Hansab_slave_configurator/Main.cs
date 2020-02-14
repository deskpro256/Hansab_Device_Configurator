using SimpleIO;
using System;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace Hansab_slave_configurator
{
    public partial class Main : Form
    {
        public static bool loadSavedConfig = false;
        public static String loadConfigName = "";
        public static int loadConfigCounter = 0;
        public String FileName = "Log.txt";
        public static int NewConfigLimiter = 0;
        public static int NewImageEditorLimiter = 0;
        public static int NewUserLimiter = 0;
        public Boolean apply = false;
        public Boolean _continue = false;
        public bool TimerPause = false;
        public string message;
        public string serialPorts;
        public string textFromFile;
        public const uint mcp2200_VID = 0x04D8;  //VID for MCP2200
        public const uint mcp2200_PID = 0x00DF;  //PID for MCP2200
        public bool isConnected = SimpleIOClass.IsConnected();         //Connection status of MCP2200 

        // RS485 stuff start:
        public byte[] msg = new byte[9];
        byte LookForSTX = 0x00;
        public byte[] RS485ReadBytes = new byte[8];
        bool replied = false;
        public byte[] logBytes = new byte[9];
        String logText = "";


        public int[] floorNums = new int[4];
        public byte[] floorNaddresses = { 0xF1, 0xF2, 0xF3, 0xF4 };

        public byte IntDev = 0x1D; //Interface device ID
        public byte myID = 0x1C;    //PC soft ID
        public byte STX = 0x5B;
        public byte ETX = 0x5D;
        public byte[] CMDLUT = new byte[11] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };
        public byte[] messageType = new byte[3] { 0x05, 0x06, 0x21 }; //ENQ ACK NAK
        public bool ConfigEnabled = false;
        public bool ConfigLoaded = false;

        // RS485 stuff end
        // Configuration files:

        byte[] MasterConfig = new byte[18];
        byte[,] SlaveConfig = new byte[16, 10];
        public Main(string type, string username)
        {
            InitializeComponent();
            UsernameLabel.Text = username;
            GetPortNames();
            if (type == "admin")
            {
                UserType.Text = "Admin";
            }
            else if (type == "guest")
            {
                UserType.Text = "Guest";
                Tab_control.TabPages.Remove(config_tab);
                NewUserButton.Visible = false;
                NewUserText.Visible = false;

            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            MCP2200Load();
            timer1.Interval = 200;
            timer1.Start();
            Apply_button.Enabled = false;
            Disonnect_button.Enabled = false;
            Connect_button.Enabled = false;
            PingProgressBar.Value = 0;
            PingProgressBar.Visible = false;
            Ping_button.Enabled = false;
            serialPort1.PortName = "COM99";
            ConfigDisableButton.Enabled = false;
            ConfigEnableButton.Enabled = false;
            RequestCount_button.Enabled = false;
            GetErrors_button.Enabled = false;
            ClearErrorsButton.Enabled = false;
            SendConfigButton.Enabled = false;
            FloorCountSendButton.Enabled = false;
            ConfigLoaded = false;
            ConfigEnabled = false;
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            SetSerialSettings();
            Connect_button.Enabled = true;
            apply = true;
        }

        private void Connect_button_Click_1(object sender, EventArgs e)
        {
            if (apply == true)
            {
                try
                {
                    serialPort1.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("COM port already open!");
                    Connect_button.Enabled = false;
                    Apply_button.Enabled = false;
                }
            }
            if (serialPort1.IsOpen == true)
            {
                progressLED2.Value = 100;
                Restart_button.Enabled = false;
                _continue = true;
                ConDiscon_label.Text = "Connected!";
                Connect_button.Enabled = false;
                Disonnect_button.Enabled = true;
                ConfigDisableButton.Enabled = false;
                ConfigEnableButton.Enabled = true;
                Apply_button.Enabled = false;
                Refresh_button.Enabled = false;
            }
            else
            {
                progressLED2.Value = 0;
                Ping_button.Enabled = false;
            }
        }
        private void Disonnect_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                SimpleIOClass.ClearPin(3);
                ConnectedDeviceList.Nodes.Clear();
                ConfigDisableButton.Enabled = false;
                ConfigEnableButton.Enabled = true;
                Restart_button.Enabled = false;
                RequestCount_button.Enabled = false;
                GetErrors_button.Enabled = false;
                ClearErrorsButton.Enabled = false;
                Ping_button.Enabled = false;
                _continue = false;
                apply = false;
                Apply_button.Enabled = false;
                progressLED2.Value = 0;
                ConDiscon_label.Text = "Disconnected!";
                Connect_button.Enabled = false;
                Restart_button.Enabled = false;
                Disonnect_button.Enabled = false;
                Ping_button.Enabled = false;
                COM_ports_box.Text = "";
                ConfigDisableButton.Enabled = false;
                ConfigEnableButton.Enabled = false;
                FloorCountSendButton.Enabled = false;
                Refresh_button.Enabled = true;
                ConfigEnabled = false;
                serialPort1.Close();
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            try
            {
                COM_ports_box.Text = "";
                COM_ports_box.Items.Clear();
                serialPort1.PortName = "COM99";
                GetPortNames();
            }
            catch (Exception)
            {
            }
        }

        private void COM_ports_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = COM_ports_box.Text;
                Apply_button.Enabled = true;
            }
        }

        public void SetSerialSettings()
        {
            if (serialPort1.PortName != "COM99")
            {
                serialPort1.PortName = COM_ports_box.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.Two;
            }
            else
            {
                MessageBox.Show("COM port not selected!");
            }
        }

        private void GetPortNames()
        {
            serialPorts = "";
            foreach (string s in SerialPort.GetPortNames())
            {
                serialPorts = s;
                if (serialPorts != "")
                {
                    COM_ports_box.Items.Add(serialPorts);
                }
            }
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            OpenFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            LoadConfig(OpenFileDialog1.FileName);
        }

        public void LoadConfig(String _filename)
        {
            Current_cfg_box.Text = "";
            Current_cfg_box.AppendText("Loading config file: \n" + _filename + " \n");
            try
            {
                using (StreamReader filereader = new StreamReader(File.Open(_filename + "_Readable.txt", FileMode.Open)))
                {
                    String textFromConfig = filereader.ReadToEnd();
                    Current_cfg_box.AppendText(textFromConfig);
                }
            }
            catch (Exception)
            {
            }
            using (BinaryReader reader = new BinaryReader(File.Open(_filename, FileMode.Open)))
            {
                for (int i = 0; i <= 17; i++)
                {
                    MasterConfig[i] = reader.ReadByte();
                }
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        SlaveConfig[i, j] = reader.ReadByte();
                    }
                }

                reader.Close();
            }
            ConfigLoaded = true;
            Current_cfg_box.AppendText("Config loaded successfully! \n");
        }


        private void NewConfig_button_Click(object sender, EventArgs e)
        {
            NewConfigLimiter++;
            if (NewConfigLimiter == 1)
            {
                var newwindow = new NewConfig();
                newwindow.Show();
            }
        }

        private void Restart_button_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to restart the system? ", "Warning!", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            ))
            {
                case DialogResult.Yes: RestartSystem(); break;
                case DialogResult.No: break;
            }
        }

        private void RestartSystem()
        {
            ConfigDisableButton.Enabled = false;
            ConfigEnableButton.Enabled = true;
            Restart_button.Enabled = false;
            RequestCount_button.Enabled = false;
            GetErrors_button.Enabled = false;
            ClearErrorsButton.Enabled = false;
            Ping_button.Enabled = false;
            FloorCountSendButton.Enabled = false;

            for (int i = 0; i <= 15; i++)
            {
                RS485Send(Convert.ToByte(i), messageType[0], CMDLUT[8], 0x52, 0x53, 0x54);  // restart CMD for slaves
            }

            RS485Send(0x1D, messageType[0], CMDLUT[8], 0x52, 0x53, 0x54);  // restart CMD for interface device
            SimpleIOClass.ClearPin(3);
            MessageBox.Show("System restarted!");
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            NewUserLimiter++;
            if (NewUserLimiter == 1)
            {
                var newwindow = new NewUser();
                newwindow.Show();
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            isConnected = SimpleIOClass.IsConnected();

            if (isConnected == true)
            {
                progressLED.Value = 100;
                Plugged_label.Text = "Plugged in!";
                Refresh_button.Enabled = true;
            }
            else
            {
                ConnectedDeviceList.Nodes.Clear();
                progressLED.Value = 0;
                Plugged_label.Text = "Not plugged in!";
                serialPort1.Close();
                ConDiscon_label.Text = "Disconnected!";
                progressLED2.Value = 0;
                Disonnect_button.Enabled = false;
                Connect_button.Enabled = false;
                serialPort1.PortName = "COM99";
                _continue = false;
                apply = false;
                Apply_button.Enabled = false;
                COM_ports_box.Text = "";
                Ping_button.Enabled = false;
                ConfigDisableButton.Enabled = false;
                ConfigEnableButton.Enabled = false;
                FloorCountSendButton.Enabled = false;
                RequestCount_button.Enabled = false;
                Restart_button.Enabled = false;
                GetErrors_button.Enabled = false;
                ClearErrorsButton.Enabled = false;
            }
            if (ConfigEnabled == true && ConfigLoaded == true)
            {
                SendConfigButton.Enabled = true;
            }
            else
            {
                SendConfigButton.Enabled = false;
            }
            if (loadSavedConfig)
            {
                loadConfigCounter++;
                if (loadConfigCounter == 1)
                {
                    LoadConfig(loadConfigName);
                }
            }
        }
        public void MCP2200Load()
        {
            SimpleIOClass.InitMCP2200(mcp2200_VID, mcp2200_PID);
            SimpleIOClass.ConfigureMCP2200(0x00, 9600, 5, 5, false, false, false, false);
            SimpleIOClass.ConfigureIoDefaultOutput(0x00, 0x00);
            //SimpleIOClass.ConfigureIO(0x34);
        }

        private void ConfigEnableButton_Click(object sender, EventArgs e)
        {
            SimpleIOClass.SetPin(3);
            ConfigEnabled = true;
            ConfigEnableButton.Enabled = false;
            ConfigDisableButton.Enabled = true;
            Restart_button.Enabled = true;
            RequestCount_button.Enabled = true;
            GetErrors_button.Enabled = true;
            ClearErrorsButton.Enabled = true;
            Ping_button.Enabled = true;
            FloorCountSendButton.Enabled = true;
            System.Threading.Thread.Sleep(50);
            while (serialPort1.BytesToRead > 0)
            {
                serialPort1.ReadByte();
            }
            System.Threading.Thread.Sleep(500);
            RequestCurrentCount();
        }

        private void ConfigDisableButton_Click(object sender, EventArgs e)
        {
            SimpleIOClass.ClearPin(3);
            ConfigEnabled = false;
            ConfigDisableButton.Enabled = false;
            ConfigEnableButton.Enabled = true;
            Restart_button.Enabled = false;
            ClearErrorsButton.Enabled = false;
            RequestCount_button.Enabled = false;
            GetErrors_button.Enabled = false;
            Ping_button.Enabled = false;
            FloorCountSendButton.Enabled = false;
        }

        private void Serial_timer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (serialPort1.BytesToRead > 8)
                {
                    int isSTX = serialPort1.ReadByte();
                    if (isSTX == 91)
                    {
                        serialPort1.Read(logBytes, 0, 8);
                        AddToSerialData(logBytes);
                    }

                }
            }
        }

        public void PingDevices()
        {
            PingProgressBar.Visible = true;
            Ping_button.Enabled = false;

            ConnectedDeviceList.Nodes.Clear();

            // ping interface device
            Ping(IntDev);
            System.Threading.Thread.Sleep(50);

            if (serialPort1.BytesToRead > 0)
            {
                LookForSTX = 0x00;
                LookForSTX = Convert.ToByte(serialPort1.ReadByte());
            }
            if (LookForSTX == STX)
            {
                RS485Receive();
            }

            if (replied == true)
            {
                if (RS485ReadBytes[1] == IntDev)
                {
                    ConnectedDeviceList.Nodes.Add("Main interface unit");
                    replied = false;
                }
                else
                {
                    replied = false;
                }
            }
            // ping interface device

            //pinging slaves
            for (int id = 0; id <= 15; id++)
            {

                PingProgressBar.Value = id * (100 / 15);
                Ping(id);
                System.Threading.Thread.Sleep(50);
                // get reply, then continue to next id
                if (serialPort1.BytesToRead > 0)
                {
                    LookForSTX = 0x00;
                    LookForSTX = Convert.ToByte(serialPort1.ReadByte());
                }
                else
                {
                    continue;
                }


                if (LookForSTX == STX)
                {
                    RS485Receive();
                }

                if (replied == true)
                {
                    try
                    {
                        if (RS485ReadBytes[1] == Convert.ToByte(id))
                        {
                            ConnectedDeviceList.Nodes.Add("Interface node " + id);
                            replied = false;
                        }
                        else
                        {
                            replied = false;
                            continue;
                        }

                    }
                    catch (Exception)
                    {
                        continue;
                    }

                }
            }
            PingProgressBar.Value = 0;
            PingProgressBar.Visible = false;
            Ping_button.Enabled = true;

        }

        private void Ping_button_Click(object sender, EventArgs e)
        {
            PingDevices();
        }
        public void Ping(int ID)
        {
            if (serialPort1.IsOpen)
            {
                RS485Send(Convert.ToByte(ID), messageType[0], CMDLUT[5], 0x50, 0x4E, 0x47);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Serialport_text_box.Clear();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SimpleIOClass.ClearPin(3);
                serialPort1.Close();
            }
            else
            {
                SimpleIOClass.ClearPin(3);
            }
            Application.Exit();
        }

        private void RequestCount_button_Click(object sender, EventArgs e)
        {
            RequestCurrentCount();
        }

        public void RequestCurrentCount()
        {
            //floorNaddresses[0-3]
            for (int i = 0; i <= 3; i++)
            {
                RS485Send(IntDev, floorNaddresses[i], CMDLUT[6], 0x4E, 0x55, 0x4D); //NUM as data
                System.Threading.Thread.Sleep(50);
                // get reply, then continue to next id
                if (serialPort1.BytesToRead > 0)
                {
                    LookForSTX = 0x00;
                    LookForSTX = Convert.ToByte(serialPort1.ReadByte());
                }
                else
                {
                    continue;
                }

                if (LookForSTX == STX)
                {
                    RS485Receive();
                }

                if (replied == true)
                {
                    byte _floor = RS485ReadBytes[2];
                    int hundreds = RS485ReadBytes[4] - 48;
                    int tens = RS485ReadBytes[5] - 48;
                    int ones = RS485ReadBytes[6] - 48;
                    int floorGetCount = (hundreds * 100) + (tens * 10) + ones;
                    if (_floor == 0xF1)   //_floor == 0xF1 241
                                          //if (_floor == 0xF1)   //_floor == 0xF1 241
                    {
                        try
                        {
                            Floor1SendCount.Value = floorGetCount;
                            continue;
                        }
                        catch (ArgumentOutOfRangeException) { }
                    }
                    else if (_floor == 0xF2)   //_floor == 0xF2 242
                    {
                        try
                        {
                            Floor2SendCount.Value = floorGetCount;
                            continue;
                        }
                        catch (ArgumentOutOfRangeException) { }
                    }
                    else if (_floor == 0xF3)   //_floor == 0xF3 243
                    {
                        try
                        {
                            Floor3SendCount.Value = floorGetCount;
                            continue;
                        }
                        catch (ArgumentOutOfRangeException) { }
                    }
                    else if (_floor == 0xF4)   //_floor == 0xF4 244
                    {
                        try
                        {
                            Floor4SendCount.Value = floorGetCount;
                            continue;
                        }
                        catch (ArgumentOutOfRangeException) { }
                    }

                    replied = false;
                }
            }
        }
        public void RS485Send(byte receiverID, byte msgType, byte command, byte data1, byte data2, byte data3)
        {
            msg[0] = STX;
            msg[1] = receiverID;
            msg[2] = myID;
            msg[3] = msgType;
            msg[4] = command;
            msg[5] = data1;
            msg[6] = data2;
            msg[7] = data3;
            msg[8] = ETX;

            SimpleIOClass.SetPin(2); //enable sending
            System.Threading.Thread.Sleep(50);
            serialPort1.Write(msg, 0, 9);
            System.Threading.Thread.Sleep(20);
            SimpleIOClass.ClearPin(2); //disable sending
            AddToSerialData(msg);

        }
        public void RS485Receive()
        {
            if (LookForSTX == STX)
            {
                LookForSTX = 0x00;
                serialPort1.Read(RS485ReadBytes, 0, 8);
                AddToSerialData(RS485ReadBytes);
                replied = true;
            }
            else
            {
                replied = false;
            }
        }
        private void GetErrors_button_Click(object sender, EventArgs e)
        {
            current_errors.Clear();
            GetErrors_button.Enabled = false;
            RS485Send(IntDev, 0x05, 0x08, 0x45, 0x52, 0x52);
            System.Threading.Thread.Sleep(1000);
            message = serialPort1.ReadExisting();
            current_errors.Text = message;
            GetErrors_button.Enabled = true;
        }

        private void ClearErrorsButton_Click(object sender, EventArgs e)
        {
            ClearErrorsButton.Enabled = false;
            RS485Send(IntDev, 0x05, 0x04, 0x45, 0x52, 0x52);
            for (int i = 0; i <= 15; i++)
            {
                RS485Send(Convert.ToByte(i), 0x05, 0x04, 0x45, 0x52, 0x52);
            }
            current_errors.Clear();
            ClearErrorsButton.Enabled = true;
        }

        private void Floor1SendCount_ValueChanged(object sender, EventArgs e)
        {
            floorNums[0] = System.Convert.ToInt32(Floor1SendCount.Value);
        }

        private void Floor2SendCount_ValueChanged(object sender, EventArgs e)
        {
            floorNums[1] = System.Convert.ToInt32(Floor2SendCount.Value);
        }

        private void Floor3SendCount_ValueChanged(object sender, EventArgs e)
        {
            floorNums[2] = System.Convert.ToInt32(Floor3SendCount.Value);
        }

        private void Floor4SendCount_ValueChanged(object sender, EventArgs e)
        {
            floorNums[3] = System.Convert.ToInt32(Floor4SendCount.Value);
        }
        private void FloorCountSendButton_Click(object sender, EventArgs e)
        {
            FloorCountSendButton.Enabled = false;
            for (int i = 0; i <= 3; i++)
            {
                byte huns = System.Convert.ToByte((floorNums[i] / 100) + 0x30);
                byte tens = System.Convert.ToByte((floorNums[i] % 100) / 10 + 0x30);
                byte ones = System.Convert.ToByte((floorNums[i] % 10) + 0x30);
                byte floorAddress = floorNaddresses[i];
                RS485Send(floorAddress, messageType[0], CMDLUT[2], huns, tens, ones);
            }
            FloorCountSendButton.Enabled = true;
        }

        public void MasterConfigSend()
        {
            SimpleIOClass.SetPin(2); //enable sending
            System.Threading.Thread.Sleep(50);
            serialPort1.Write(MasterConfig, 0, 18);
            System.Threading.Thread.Sleep(50);
            SimpleIOClass.ClearPin(2); //disable sending
        }
        public void SlaveConfigSend(byte[] SlaveData)
        {
            SimpleIOClass.SetPin(2); //enable sending
            System.Threading.Thread.Sleep(50);
            serialPort1.Write(SlaveData, 0, 10);
            System.Threading.Thread.Sleep(50);
            SimpleIOClass.ClearPin(2); //disable sending
        }

        private void SendConfigButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                MessageBox.Show("Sending the configuration data!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RS485Send(IntDev, messageType[0], CMDLUT[4], 0x43, 0x46, 0x47);
                System.Threading.Thread.Sleep(50);
                MasterConfigSend();

                for (int i = 0; i <= 15; i++)
                {
                    byte[] SlaveData = new byte[10];
                    RS485Send(Convert.ToByte(i), messageType[0], CMDLUT[4], 0x43, 0x46, 0x47);
                    System.Threading.Thread.Sleep(50);
                    for (int j = 0; j <= 9; j++)
                    {
                        SlaveData[j] = SlaveConfig[i, j];
                    }
                    SlaveConfigSend(SlaveData);
                    System.Threading.Thread.Sleep(50);
                }

                ConfigDisableButton.Enabled = false;
                ConfigEnableButton.Enabled = true;
                Restart_button.Enabled = false;
                RequestCount_button.Enabled = false;
                GetErrors_button.Enabled = false;
                ClearErrorsButton.Enabled = false;
                Ping_button.Enabled = false;
                FloorCountSendButton.Enabled = false;
                SimpleIOClass.ClearPin(3);
            }
            else
            {
                MessageBox.Show("SerialPort not open! \n Connect to an Interface device to configure the system!", "Cannot send configuration!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void AddToSerialData(byte[] data)
        {
            String LogText = "[";
            Char ascii = '0';
            try
            {
                for (int i = 0; i <= 7; i++)
                {
                    if (data[i] < 32)
                    {
                        if (data[i] == 28)
                        {
                            LogText += " [PC] ";
                        }
                        else if(data[i] == 29)
                        {
                            LogText += " [INT] ";
                        }
                        else
                        {
                            LogText += Convert.ToInt32(data[i].ToString()) + " ";
                        }
                    }
                    else
                    {
                        if (data[i] == 0xF1)
                        {
                            LogText += " F1 ";
                        }
                        else if (data[i] == 0xF2)
                        {
                            LogText += " F2 ";
                        }
                        else if (data[i] == 0xF3)
                        {
                            LogText += " F3 ";
                        }
                        else if (data[i] == 0xF4)
                        {
                            LogText += " F4 ";
                        }
                        else
                        {
                            ascii = (char)data[i];
                            LogText += ascii;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            Serialport_text_box.AppendText("\n[" + DateTime.Now + "] - " + LogText);
        }

        private void ImageEditorBtn_Click(object sender, EventArgs e)
        {
            NewImageEditorLimiter++;
            if (NewImageEditorLimiter == 1)
            {
                var newwindow = new ImageEditor();
                newwindow.Show();
            }
        }

        private void LogSaveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                FileName = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(File.Open(FileName, FileMode.Create)))
                {
                    writer.Write(Serialport_text_box.Text);
                    writer.Close();
                }
                MessageBox.Show("File saved in:\n" + FileName, "File saved!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
            }
        }
    }
}
