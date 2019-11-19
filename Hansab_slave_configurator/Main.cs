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
        public Boolean apply = false;
        public Boolean _continue = false;
        public bool TimerPause = false;
        public string message;
        public string pingRead;
        public string serialPorts;
        public string textFromFile;
        public const uint mcp2200_VID = 0x04D8;  //VID for MCP2200
        public const uint mcp2200_PID = 0x00DF;  //PID for MCP2200
        public bool isConnected = SimpleIOClass.IsConnected();         //Connection status of MCP2200 
        public byte[] msg = new byte[8];

        // RS485 stuff start:
        public byte IntDev = 0x1D; //Interface device ID
        public byte myID = 0x1C;    //PC soft ID
        public byte STX = 0x5B;
        public byte[] CMDLUT = new byte[11] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };
        public byte[] messageType = new byte[3] { 0x05, 0x06, 0x21 }; //ENQ ACK NAK
        public bool ConfigEnabled = true;
        public bool ConfigPrevious = false;
        public bool ConfigCurrent = false;

        // RS485 stuff end
        public Main(string type, string username)
        {
            InitializeComponent();
            UsernameLabel.Text = username;
            getPortNames();
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
            treeView1.ExpandAll();
            ConfigDisableButton.Enabled = false;
            ConfigEnableButton.Enabled = false;
            RequestCount_button.Enabled = false;
            GetErrors_button.Enabled = false;
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
                ConfigDisableButton.Enabled = false;
                ConfigEnableButton.Enabled = true;
                Restart_button.Enabled = false;
                RequestCount_button.Enabled = false;
                GetErrors_button.Enabled = false;
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
                serialPort1.Close();
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            COM_ports_box.Text = "";
            COM_ports_box.Items.Clear();
            serialPort1.PortName = "COM99";
            getPortNames();

        }

        private void COM_ports_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = COM_ports_box.Text;
            Apply_button.Enabled = true;
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

        private void getPortNames()
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

        private void load_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //textFromFile;
            StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
            textFromFile = streamReader.ReadToEnd();
            Current_cfg_box.Text = textFromFile;
        }

        private void newConfig_button_Click(object sender, EventArgs e)
        {
            var newwindow = new NewConfig();
            newwindow.Show();
        }

        private void Restart_button_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to restart the system? ", "Warning!", MessageBoxButtons.YesNo,
                            //MessageBoxIcon.Warning // for Warning  
                            //MessageBoxIcon.Error // for Error 
                            //MessageBoxIcon.Information  // for Information
                            MessageBoxIcon.Question // for Question
                            ))
            {
                case DialogResult.Yes: RestartSystem(); break;
                case DialogResult.No: break;
            }
        }

        private void RestartSystem()
        {

            //RS485Send(Convert.ToByte(ID), messageType[0], CMDLUT[5], 0x50, 0x4E, 0x47);  // restart CMD
            SimpleIOClass.SetPin(2); //enable sending
            System.Threading.Thread.Sleep(10);
            serialPort1.Write("Restarting!");
            System.Threading.Thread.Sleep(10);
            SimpleIOClass.ClearPin(2); //disable sending

            MessageBox.Show("Restarting the system!");
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            var newwindow = new NewUser();
            newwindow.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
            var newwindow = new Login_form();
            newwindow.Show();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            isConnected = SimpleIOClass.IsConnected();

            if (isConnected == true)
            {
                progressLED.Value = 100;
                Plugged_label.Text = "Plugged in!";
            }
            else
            {
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
            ConfigEnableButton.Enabled = false;
            ConfigDisableButton.Enabled = true;
            Restart_button.Enabled = true;
            RequestCount_button.Enabled = true;
            GetErrors_button.Enabled = true;
            Ping_button.Enabled = true;
        }

        private void ConfigDisableButton_Click(object sender, EventArgs e)
        {
            SimpleIOClass.ClearPin(3);
            ConfigDisableButton.Enabled = false;
            ConfigEnableButton.Enabled = true;
            Restart_button.Enabled = false;
            RequestCount_button.Enabled = false;
            GetErrors_button.Enabled = false;
            Ping_button.Enabled = false;
        }

        private void Serial_timer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (serialPort1.ReadExisting().Length > 0)
                {
                    RS485Receive();
                }
            }
        }

        private void Ping_button_Click(object sender, EventArgs e)
        {
            PingProgressBar.Visible = true;
            for (int id = 0; id <= 16; id++) //change to id <= 16;
            {
                Ping_button.Enabled = false;
                PingProgressBar.Value = id * (100 / 16);
                Ping(id);
                System.Threading.Thread.Sleep(10);
                // get reply, then continue to next id
                pingRead = serialPort1.ReadExisting();
                if (pingRead.Length > 0)
                {
                    if (pingRead.Contains("\u0002"))
                    {

                    }
                    Serialport_text_box.AppendText(pingRead + "\n\r");
                    serialPort1.DiscardInBuffer();
                }
            }
            PingProgressBar.Value = 0;
            PingProgressBar.Visible = false;
            Ping_button.Enabled = true;
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
            //Serialport_text_box.Text = "";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SimpleIOClass.ClearPin(3);
                serialPort1.Close();
            }
            Application.Exit();
        }

        private void RequestCount_button_Click(object sender, EventArgs e)
        {
            //RS485Send(0x69, messageType[0], CMDLUT[6], 0x4E, 0x55, 0x4D); //NUM as data
            RS485Send(IntDev, messageType[0], 0x09, 0x4E, 0x55, 0x4D); //NUM as data
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

            SimpleIOClass.SetPin(2); //enable sending
            System.Threading.Thread.Sleep(10);
            serialPort1.Write(msg, 0, 8);
            System.Threading.Thread.Sleep(10);
            Serialport_text_box.AppendText(Encoding.ASCII.GetString(msg));
            SimpleIOClass.ClearPin(2); //disable sending
        }
        public void RS485Receive()
        {
            message = serialPort1.ReadExisting();
            Serialport_text_box.AppendText(message + "\n\r");
        }
        private void GetErrors_button_Click(object sender, EventArgs e)
        {
            GetErrors_button.Enabled = false;
            RS485Send(IntDev, 0x05, 0x08, 0x45, 0x52, 0x52);
            message = serialPort1.ReadExisting();
            current_errors.Clear();
            current_errors.Text = message;
            serialPort1.DiscardInBuffer();
            GetErrors_button.Enabled = true;
        }


    }
}