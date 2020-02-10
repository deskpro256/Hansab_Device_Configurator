using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleIO;

namespace Hansab_slave_configurator
{

    public partial class NewConfig : Form
    {
        public static byte IntDev = 0x1D; //Interface device ID
        public static byte myID = 0x1C;    //PC soft ID
        public static byte STX = 0x5B;
        public static byte ETX = 0x5D;
        public static byte[] CMDLUT = new byte[11] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };

        public String FileName = "Config.dat";
        public String textToFile = "";
        //SlaveConfigBytes
        public static byte[,] SlaveConfiguration = new byte[16, 10]
        {
            {STX,0x00,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x01,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x02,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x03,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x04,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x05,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x06,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x07,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x08,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x09,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x0A,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x0B,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x0C,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x0D,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x0E,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX},
            {STX,0x0F,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,ETX}
        };
        //MasterConfigBytes
        public static byte[] MasterConfiguration = new byte[18]
            {STX,IntDev,myID,CMDLUT[4],0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,ETX};
        bool CorrectConfig = false;

        public int FloorNumericValue = 1;
        public int UsedSlaveCount = 1;
        public int Floor1Count = 0;
        public int Floor2Count = 0;
        public int Floor3Count = 0;
        public int Floor4Count = 0;

        public static Slave Slave0 = new Slave(0, 0, 0, 0);
        public static Slave Slave1 = new Slave(1, 0, 0, 0);
        public static Slave Slave2 = new Slave(2, 0, 0, 0);
        public static Slave Slave3 = new Slave(3, 0, 0, 0);
        public static Slave Slave4 = new Slave(4, 0, 0, 0);
        public static Slave Slave5 = new Slave(5, 0, 0, 0);
        public static Slave Slave6 = new Slave(6, 0, 0, 0);
        public static Slave Slave7 = new Slave(7, 0, 0, 0);
        public static Slave Slave8 = new Slave(8, 0, 0, 0);
        public static Slave Slave9 = new Slave(9, 0, 0, 0);
        public static Slave Slave10 = new Slave(10, 0, 0, 0);
        public static Slave Slave11 = new Slave(11, 0, 0, 0);
        public static Slave Slave12 = new Slave(12, 0, 0, 0);
        public static Slave Slave13 = new Slave(13, 0, 0, 0);
        public static Slave Slave14 = new Slave(14, 0, 0, 0);
        public static Slave Slave15 = new Slave(15, 0, 0, 0);


        public bool[] SlaveSettings0 = new bool[3] { true, false, false };
        public bool[] SlaveSettings1 = new bool[3] { true, false, false };
        public bool[] SlaveSettings2 = new bool[3] { true, false, false };
        public bool[] SlaveSettings3 = new bool[3] { true, false, false };
        public bool[] SlaveSettings4 = new bool[3] { true, false, false };
        public bool[] SlaveSettings5 = new bool[3] { true, false, false };
        public bool[] SlaveSettings6 = new bool[3] { true, false, false };
        public bool[] SlaveSettings7 = new bool[3] { true, false, false };
        public bool[] SlaveSettings8 = new bool[3] { true, false, false };
        public bool[] SlaveSettings9 = new bool[3] { true, false, false };
        public bool[] SlaveSettings10 = new bool[3] { true, false, false };
        public bool[] SlaveSettings11 = new bool[3] { true, false, false };
        public bool[] SlaveSettings12 = new bool[3] { true, false, false };
        public bool[] SlaveSettings13 = new bool[3] { true, false, false };
        public bool[] SlaveSettings14 = new bool[3] { true, false, false };
        public bool[] SlaveSettings15 = new bool[3] { true, false, false };


        public NewConfig()
        {
            InitializeComponent();
        }
        private void NewConfig_Load(object sender, EventArgs e)
        {
            ApplyConfigSettingsButton.Enabled = false;
            SaveButton.Enabled = false;
            this.Width = 350;
            FloorGroupBox.Height = 50;

            SlaveSettingsBox0.Hide();
            SlaveSettingsBox1.Hide();
            SlaveSettingsBox2.Hide();
            SlaveSettingsBox3.Hide();
            SlaveSettingsBox4.Hide();
            SlaveSettingsBox5.Hide();
            SlaveSettingsBox6.Hide();
            SlaveSettingsBox7.Hide();
            SlaveSettingsBox8.Hide();
            SlaveSettingsBox9.Hide();
            SlaveSettingsBox10.Hide();
            SlaveSettingsBox11.Hide();
            SlaveSettingsBox12.Hide();
            SlaveSettingsBox13.Hide();
            SlaveSettingsBox14.Hide();
            SlaveSettingsBox15.Hide();
        }



        //==============================[CHECK_FUNC]=============================================

        private void CheckButton_Click(object sender, EventArgs e)
        {
            CheckBoxes();
        }

        //==============================[APPLY_FUNC]=============================================
        private void ApplyConfigSettingsButton_Click(object sender, EventArgs e)
        {
            ConfigTextBox.Text = "[Configuration data] \n\n";
            
            SaveButton.Enabled = true;

            CreateConfigurationBytes(UsedSlaveCount);

        }

        //==============================[SAVE_FUNC]=============================================
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Main.loadConfigCounter = 0;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            FileName = saveFileDialog1.FileName;

            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(FileName, FileMode.Create)))
            {
                for (int i = 0; i <= 17; i++)
                {
                    binaryWriter.Write(MasterConfiguration[i]);
                }

                // i rows  //  j cols
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        binaryWriter.Write(SlaveConfiguration[i, j]);
                    }
                }

                binaryWriter.Close();
            }
            using (StreamWriter writer = new StreamWriter(File.Open(FileName + "_Readable.txt", FileMode.Create)))
            {
                writer.Write(ConfigTextBox.Text);
                writer.Close();
            }
            Main.loadSavedConfig = true;
            Main.loadConfigName = FileName;
            MessageBox.Show("File saved in:\n" + FileName, "File saved!", MessageBoxButtons.OK);

        }
        private void SlaveCount_ValueChanged(object sender, EventArgs e)
        {
            UsedSlaveCount = Convert.ToInt32(SlaveCount.Value);
        }

        private void SlaveCountAccept_Click(object sender, EventArgs e)
        {
            SlaveSettingsBox0.Hide();
            SlaveSettingsBox1.Hide();
            SlaveSettingsBox2.Hide();
            SlaveSettingsBox3.Hide();
            SlaveSettingsBox4.Hide();
            SlaveSettingsBox5.Hide();
            SlaveSettingsBox6.Hide();
            SlaveSettingsBox7.Hide();
            SlaveSettingsBox8.Hide();
            SlaveSettingsBox9.Hide();
            SlaveSettingsBox10.Hide();
            SlaveSettingsBox11.Hide();
            SlaveSettingsBox12.Hide();
            SlaveSettingsBox13.Hide();
            SlaveSettingsBox14.Hide();
            SlaveSettingsBox15.Hide();

            if (UsedSlaveCount <= 4)
            {
                this.Width = 515;
                switch (UsedSlaveCount)
                {
                    case 1:
                        SlaveSettingsBox0.Show();
                        break;
                    case 2:
                        SlaveSettingsBox0.Show();
                        SlaveSettingsBox1.Show();
                        break;
                    case 3:
                        SlaveSettingsBox0.Show();
                        SlaveSettingsBox1.Show();
                        SlaveSettingsBox2.Show();
                        break;
                    case 4:
                        SlaveSettingsBox0.Show();
                        SlaveSettingsBox1.Show();
                        SlaveSettingsBox2.Show();
                        SlaveSettingsBox3.Show();
                        break;
                }
            }
            else if (UsedSlaveCount > 4 && UsedSlaveCount <= 8)
            {
                this.Width = 670;
                SlaveSettingsBox0.Show();
                SlaveSettingsBox1.Show();
                SlaveSettingsBox2.Show();
                SlaveSettingsBox3.Show();
                switch (UsedSlaveCount)
                {
                    case 5:
                        SlaveSettingsBox4.Show();
                        break;
                    case 6:
                        SlaveSettingsBox4.Show();
                        SlaveSettingsBox5.Show();
                        break;
                    case 7:
                        SlaveSettingsBox4.Show();
                        SlaveSettingsBox5.Show();
                        SlaveSettingsBox6.Show();
                        break;
                    case 8:
                        SlaveSettingsBox4.Show();
                        SlaveSettingsBox5.Show();
                        SlaveSettingsBox6.Show();
                        SlaveSettingsBox7.Show();
                        break;
                }
            }
            else if (UsedSlaveCount > 8 && UsedSlaveCount <= 12)
            {
                SlaveSettingsBox0.Show();
                SlaveSettingsBox1.Show();
                SlaveSettingsBox2.Show();
                SlaveSettingsBox3.Show();
                SlaveSettingsBox4.Show();
                SlaveSettingsBox5.Show();
                SlaveSettingsBox6.Show();
                SlaveSettingsBox7.Show();
                this.Width = 830;
                switch (UsedSlaveCount)
                {
                    case 9:
                        SlaveSettingsBox8.Show();
                        break;
                    case 10:
                        SlaveSettingsBox8.Show();
                        SlaveSettingsBox9.Show();
                        break;
                    case 11:
                        SlaveSettingsBox8.Show();
                        SlaveSettingsBox9.Show();
                        SlaveSettingsBox10.Show();
                        break;
                    case 12:
                        SlaveSettingsBox8.Show();
                        SlaveSettingsBox9.Show();
                        SlaveSettingsBox10.Show();
                        SlaveSettingsBox11.Show();
                        break;
                }
            }
            else if (UsedSlaveCount > 12 && UsedSlaveCount <= 16)
            {
                SlaveSettingsBox0.Show();
                SlaveSettingsBox1.Show();
                SlaveSettingsBox2.Show();
                SlaveSettingsBox3.Show();
                SlaveSettingsBox4.Show();
                SlaveSettingsBox5.Show();
                SlaveSettingsBox6.Show();
                SlaveSettingsBox7.Show();
                SlaveSettingsBox8.Show();
                SlaveSettingsBox9.Show();
                SlaveSettingsBox10.Show();
                SlaveSettingsBox11.Show();
                this.Width = 1000;
                switch (UsedSlaveCount)
                {
                    case 13:
                        SlaveSettingsBox12.Show();
                        break;
                    case 14:
                        SlaveSettingsBox12.Show();
                        SlaveSettingsBox13.Show();
                        break;
                    case 15:
                        SlaveSettingsBox12.Show();
                        SlaveSettingsBox13.Show();
                        SlaveSettingsBox14.Show();
                        break;
                    case 16:
                        SlaveSettingsBox12.Show();
                        SlaveSettingsBox13.Show();
                        SlaveSettingsBox14.Show();
                        SlaveSettingsBox15.Show();
                        break;
                }
            }

        }
        private void FloorCountNumeric_ValueChanged(object sender, EventArgs e)
        {
            FloorNumericValue = Convert.ToInt32(FloorCountNumeric.Value);
        }
        private void AcceptFloorButton_Click(object sender, EventArgs e)
        {
            SlaveFloor0.Items.Clear();
            SlaveFloor1.Items.Clear();
            SlaveFloor2.Items.Clear();
            SlaveFloor3.Items.Clear();
            SlaveFloor4.Items.Clear();
            SlaveFloor5.Items.Clear();
            SlaveFloor6.Items.Clear();
            SlaveFloor7.Items.Clear();
            SlaveFloor8.Items.Clear();
            SlaveFloor9.Items.Clear();
            SlaveFloor10.Items.Clear();
            SlaveFloor11.Items.Clear();
            SlaveFloor12.Items.Clear();
            SlaveFloor13.Items.Clear();
            SlaveFloor14.Items.Clear();
            SlaveFloor15.Items.Clear();

            if (FloorNumericValue == 1)
            {
                // "1","2","3","4"
                
                FloorGroupBox.Height = 90;
                SlaveFloor0.Items.AddRange(new object[] { "1" });
                SlaveFloor1.Items.AddRange(new object[] { "1" });
                SlaveFloor2.Items.AddRange(new object[] { "1" });
                SlaveFloor3.Items.AddRange(new object[] { "1" });
                SlaveFloor4.Items.AddRange(new object[] { "1" });
                SlaveFloor5.Items.AddRange(new object[] { "1" });
                SlaveFloor6.Items.AddRange(new object[] { "1" });
                SlaveFloor7.Items.AddRange(new object[] { "1" });
                SlaveFloor8.Items.AddRange(new object[] { "1" });
                SlaveFloor9.Items.AddRange(new object[] { "1" });
                SlaveFloor10.Items.AddRange(new object[] { "1" });
                SlaveFloor11.Items.AddRange(new object[] { "1" });
                SlaveFloor12.Items.AddRange(new object[] { "1" });
                SlaveFloor13.Items.AddRange(new object[] { "1" });
                SlaveFloor14.Items.AddRange(new object[] { "1" });
                SlaveFloor15.Items.AddRange(new object[] { "1" });
            }
            else if (FloorNumericValue == 2)
            {
                FloorGroupBox.Height = 120;
                SlaveFloor0.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor1.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor2.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor3.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor4.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor5.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor6.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor7.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor8.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor9.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor10.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor11.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor12.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor13.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor14.Items.AddRange(new object[] { "1", "2" });
                SlaveFloor15.Items.AddRange(new object[] { "1", "2" });
            }
            else if (FloorNumericValue == 3)
            {
                FloorGroupBox.Height = 150;
                SlaveFloor0.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor1.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor2.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor3.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor4.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor5.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor6.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor7.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor8.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor9.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor10.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor11.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor12.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor13.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor14.Items.AddRange(new object[] { "1", "2", "3" });
                SlaveFloor15.Items.AddRange(new object[] { "1", "2", "3" });
            }
            else if (FloorNumericValue == 4)
            {
                FloorGroupBox.Height = 195;
                SlaveFloor0.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor1.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor2.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor3.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor4.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor5.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor6.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor7.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor8.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor9.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor10.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor11.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor12.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor13.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor14.Items.AddRange(new object[] { "1", "2", "3", "4" });
                SlaveFloor15.Items.AddRange(new object[] { "1", "2", "3", "4" });
            }
        }
        //==============================[FLOOR SETTINGS MODIFIERS]=============================================

        public void SetFloorCount(int FloorNum)
        {
            int n = FloorNum;
            string FloorMax1 = Convert.ToString(Floor1Count);
            string FloorMax2 = Convert.ToString(Floor2Count);
            string FloorMax3 = Convert.ToString(Floor3Count);
            string FloorMax4 = Convert.ToString(Floor4Count);
            String MainCount = "";

            if (SlaveFloor0.Text != "")
            {
                Slave0.Floor = Convert.ToInt32(SlaveFloor0.Text);
            }
            if (SlaveFloor1.Text != "")
            {
                Slave1.Floor = Convert.ToInt32(SlaveFloor1.Text);
            }
            if (SlaveFloor2.Text != "")
            {
                Slave2.Floor = Convert.ToInt32(SlaveFloor2.Text);
            }
            if (SlaveFloor3.Text != "")
            {
                Slave3.Floor = Convert.ToInt32(SlaveFloor3.Text);
            }
            if (SlaveFloor4.Text != "")
            {
                Slave4.Floor = Convert.ToInt32(SlaveFloor4.Text);
            }
            if (SlaveFloor5.Text != "")
            {
                Slave5.Floor = Convert.ToInt32(SlaveFloor5.Text);
            }
            if (SlaveFloor6.Text != "")
            {
                Slave6.Floor = Convert.ToInt32(SlaveFloor6.Text);
            }
            if (SlaveFloor7.Text != "")
            {
                Slave7.Floor = Convert.ToInt32(SlaveFloor7.Text);
            }
            if (SlaveFloor8.Text != "")
            {
                Slave8.Floor = Convert.ToInt32(SlaveFloor8.Text);
            }
            if (SlaveFloor9.Text != "")
            {
                Slave9.Floor = Convert.ToInt32(SlaveFloor9.Text);
            }
            if (SlaveFloor10.Text != "")
            {
                Slave10.Floor = Convert.ToInt32(SlaveFloor10.Text);
            }
            if (SlaveFloor11.Text != "")
            {
                Slave11.Floor = Convert.ToInt32(SlaveFloor11.Text);
            }
            if (SlaveFloor12.Text != "")
            {
                Slave12.Floor = Convert.ToInt32(SlaveFloor12.Text);
            }
            if (SlaveFloor13.Text != "")
            {
                Slave13.Floor = Convert.ToInt32(SlaveFloor13.Text);
            }
            if (SlaveFloor14.Text != "")
            {
                Slave14.Floor = Convert.ToInt32(SlaveFloor14.Text);
            }
            if (SlaveFloor15.Text != "")
            {
                Slave15.Floor = Convert.ToInt32(SlaveFloor15.Text);
            }

            if (n == 1)
            {
                MainCount = FloorMax1;
            }
            else if (n == 2)
            {
                MainCount = FloorMax2;
            }
            else if (n == 3)
            {
                MainCount = FloorMax3;
            }
            else if (n == 4)
            {
                MainCount = FloorMax4;
            }

            if (Slave0.Floor == n)
            {
                Slave0.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel0.Text = MainCount;
            }
            if (Slave1.Floor == n)
            {
                Slave1.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel1.Text = MainCount;
            }
            if (Slave2.Floor == n)
            {
                Slave2.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel2.Text = MainCount;
            }
            if (Slave3.Floor == n)
            {
                Slave3.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel3.Text = MainCount;
            }
            if (Slave4.Floor == n)
            {
                Slave4.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel4.Text = MainCount;
            }
            if (Slave5.Floor == n)
            {
                Slave5.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel5.Text = MainCount;
            }
            if (Slave6.Floor == n)
            {
                Slave6.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel6.Text = MainCount;
            }
            if (Slave7.Floor == n)
            {
                Slave7.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel7.Text = MainCount;
            }
            if (Slave8.Floor == n)
            {
                Slave8.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel8.Text = MainCount;
            }
            if (Slave9.Floor == n)
            {
                Slave9.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel9.Text = MainCount;
            }
            if (Slave10.Floor == n)
            {
                Slave10.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel10.Text = MainCount;
            }
            if (Slave11.Floor == n)
            {
                Slave11.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel11.Text = MainCount;
            }
            if (Slave12.Floor == n)
            {
                Slave12.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel12.Text = MainCount;
            }
            if (Slave13.Floor == n)
            {
                Slave13.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel13.Text = MainCount;
            }
            if (Slave14.Floor == n)
            {
                Slave14.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel14.Text = MainCount;
            }
            if (Slave15.Floor == n)
            {
                Slave15.Count = Convert.ToInt32(MainCount);
                SlaveMaxCountLabel15.Text = MainCount;
            }
        }

        //=====================================[FLOOR_1]=======================================================
        private void FloorMax1_ValueChanged(object sender, EventArgs e)
        {
            Floor1Count = Convert.ToInt32(FloorMax1.Value);
            SetFloorCount(1);
        }

        //=====================================[FLOOR_2]=======================================================
        private void FloorMax2_ValueChanged(object sender, EventArgs e)
        {
            Floor2Count = Convert.ToInt32(FloorMax2.Value);
            SetFloorCount(2);
        }

        //=====================================[FLOOR_3]=======================================================
        private void FloorMax3_ValueChanged(object sender, EventArgs e)
        {
            Floor3Count = Convert.ToInt32(FloorMax3.Value);
            SetFloorCount(3);
        }


        //=====================================[FLOOR_4]=======================================================
        private void FloorMax4_ValueChanged(object sender, EventArgs e)
        {
            Floor4Count = Convert.ToInt32(FloorMax4.Value);
            SetFloorCount(4);
        }

        //==============================[SLAVE SETTINGS MODIFIERS]=============================================

        //=====================================[SLAVE_0]=======================================================


        private void SlaveTypeBox0_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave0.Type = Convert.ToInt32(SlaveTypeBox0.Text);
            SlaveSettings0[1] = true;
            CheckProgressBarValues(0);
        }

        private void SlaveFloor0_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave0.Floor = Convert.ToInt32(SlaveFloor0.Text);
            SlaveSettings0[2] = true;
            CheckProgressBarValues(0);
            SetFloorCount(Slave0.Floor);
        }

        //=====================================[SLAVE_1]=======================================================


        private void SlaveTypeBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave1.Type = Convert.ToInt32(SlaveTypeBox1.Text);
            SlaveSettings1[1] = true;
            CheckProgressBarValues(1);
        }

        private void SlaveFloor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave1.Floor = Convert.ToInt32(SlaveFloor1.Text);
            SlaveSettings1[2] = true;
            CheckProgressBarValues(1);
            SetFloorCount(Slave1.Floor);
        }

        //=====================================[SLAVE_2]=======================================================


        private void SlaveTypeBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave2.Type = Convert.ToInt32(SlaveTypeBox2.Text);
            SlaveSettings2[1] = true;
            CheckProgressBarValues(2);
        }

        private void SlaveFloor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave2.Floor = Convert.ToInt32(SlaveFloor2.Text);
            SlaveSettings2[2] = true;
            CheckProgressBarValues(2);
            SetFloorCount(Slave2.Floor);
        }

        //=====================================[SLAVE_3]=======================================================


        private void SlaveTypeBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave3.Type = Convert.ToInt32(SlaveTypeBox3.Text);
            SlaveSettings3[1] = true;
            CheckProgressBarValues(3);
        }

        private void SlaveFloor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave3.Floor = Convert.ToInt32(SlaveFloor3.Text);
            SlaveSettings3[2] = true;
            CheckProgressBarValues(3);
            SetFloorCount(Slave3.Floor);
        }

        //=====================================[SLAVE_4]=======================================================


        private void SlaveTypeBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave4.Type = Convert.ToInt32(SlaveTypeBox4.Text);
            SlaveSettings4[1] = true;
            CheckProgressBarValues(4);
        }

        private void SlaveFloor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave4.Floor = Convert.ToInt32(SlaveFloor4.Text);
            SlaveSettings4[2] = true;
            CheckProgressBarValues(4);
            SetFloorCount(Slave4.Floor);
        }

        //=====================================[SLAVE_5]=======================================================


        private void SlaveTypeBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave5.Type = Convert.ToInt32(SlaveTypeBox5.Text);
            SlaveSettings5[1] = true;
            CheckProgressBarValues(5);
        }

        private void SlaveFloor5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave5.Floor = Convert.ToInt32(SlaveFloor5.Text);
            SlaveSettings5[2] = true;
            CheckProgressBarValues(5);
            SetFloorCount(Slave5.Floor);
        }

        //=====================================[SLAVE_6]=======================================================


        private void SlaveTypeBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave6.Type = Convert.ToInt32(SlaveTypeBox6.Text);
            SlaveSettings6[1] = true;
            CheckProgressBarValues(6);
        }

        private void SlaveFloor6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave6.Floor = Convert.ToInt32(SlaveFloor6.Text);
            SlaveSettings6[2] = true;
            CheckProgressBarValues(6);
            SetFloorCount(Slave6.Floor);
        }

        //=====================================[SLAVE_7]=======================================================


        private void SlaveTypeBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave7.Type = Convert.ToInt32(SlaveTypeBox7.Text);
            SlaveSettings7[1] = true;
            CheckProgressBarValues(7);
        }

        private void SlaveFloor7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave7.Floor = Convert.ToInt32(SlaveFloor7.Text);
            SlaveSettings7[2] = true;
            CheckProgressBarValues(7);
            SetFloorCount(Slave7.Floor);
        }

        //=====================================[SLAVE_8]=======================================================


        private void SlaveTypeBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave8.Type = Convert.ToInt32(SlaveTypeBox8.Text);
            SlaveSettings8[1] = true;
            CheckProgressBarValues(8);
        }

        private void SlaveFloor8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave8.Floor = Convert.ToInt32(SlaveFloor8.Text);
            SlaveSettings8[2] = true;
            SetFloorCount(Slave8.Floor);
            CheckProgressBarValues(8);
        }

        //=====================================[SLAVE_9]=======================================================


        private void SlaveTypeBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave9.Type = Convert.ToInt32(SlaveTypeBox9.Text);
            SlaveSettings9[1] = true;
            CheckProgressBarValues(9);
        }

        private void SlaveFloor9_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave9.Floor = Convert.ToInt32(SlaveFloor9.Text);
            SlaveSettings9[2] = true;
            SetFloorCount(Slave9.Floor);
            CheckProgressBarValues(9);
        }

        //=====================================[SLAVE_10]=======================================================


        private void SlaveTypeBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave10.Type = Convert.ToInt32(SlaveTypeBox10.Text);
            SlaveSettings10[1] = true;
            CheckProgressBarValues(10);
        }

        private void SlaveFloor10_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave10.Floor = Convert.ToInt32(SlaveFloor10.Text);
            SlaveSettings10[2] = true;
            SetFloorCount(Slave10.Floor);
            CheckProgressBarValues(10);
        }

        //=====================================[SLAVE_11]=======================================================


        private void SlaveTypeBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave11.Type = Convert.ToInt32(SlaveTypeBox11.Text);
            SlaveSettings11[1] = true;
            CheckProgressBarValues(11);
        }

        private void SlaveFloor11_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave11.Floor = Convert.ToInt32(SlaveFloor11.Text);
            SlaveSettings11[2] = true;
            SetFloorCount(Slave11.Floor);
            CheckProgressBarValues(11);
        }

        //=====================================[SLAVE_12]=======================================================


        private void SlaveTypeBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave12.Type = Convert.ToInt32(SlaveTypeBox12.Text);
            SlaveSettings12[1] = true;
            CheckProgressBarValues(12);
        }

        private void SlaveFloor12_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave12.Floor = Convert.ToInt32(SlaveFloor12.Text);
            SlaveSettings12[2] = true;
            SetFloorCount(Slave12.Floor);
            CheckProgressBarValues(12);
        }

        //=====================================[SLAVE_13]=======================================================


        private void SlaveTypeBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave13.Type = Convert.ToInt32(SlaveTypeBox13.Text);
            SlaveSettings13[1] = true;
            CheckProgressBarValues(13);
        }

        private void SlaveFloor13_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave13.Floor = Convert.ToInt32(SlaveFloor13.Text);
            SlaveSettings13[2] = true;
            SetFloorCount(Slave13.Floor);
            CheckProgressBarValues(13);
        }

        //=====================================[SLAVE_14]=======================================================


        private void SlaveTypeBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave14.Type = Convert.ToInt32(SlaveTypeBox14.Text);
            SlaveSettings14[1] = true;
            CheckProgressBarValues(14);
        }

        private void SlaveFloor14_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave14.Floor = Convert.ToInt32(SlaveFloor14.Text);
            SlaveSettings14[2] = true;
            SetFloorCount(Slave14.Floor);
            CheckProgressBarValues(14);
        }

        //=====================================[SLAVE_15]=======================================================

        private void SlaveTypeBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave15.Type = Convert.ToInt32(SlaveTypeBox15.Text);
            SlaveSettings15[1] = true;
            CheckProgressBarValues(15);
        }

        private void SlaveFloor15_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slave15.Floor = Convert.ToInt32(SlaveFloor15.Text);
            SlaveSettings15[2] = true;
            SetFloorCount(Slave15.Floor);
            CheckProgressBarValues(15);
        }

        //=====================================[CHECK_BOXES]=======================================================
        void CheckBoxes()
        {
            int foo =
                (progressBar0.Value) + (progressBar1.Value) + (progressBar2.Value) + (progressBar3.Value) +
                (progressBar4.Value) + (progressBar5.Value) + (progressBar6.Value) + (progressBar7.Value) +
                (progressBar8.Value) + (progressBar9.Value) + (progressBar10.Value) + (progressBar11.Value) +
                (progressBar12.Value) + (progressBar13.Value) + (progressBar14.Value) + (progressBar15.Value);

            if (foo == UsedSlaveCount)
            {
                CorrectConfig = true;
                foo = 0;
            }

            if (CorrectConfig == true)
            {
                MessageBox.Show("All seems good!");
                ApplyConfigSettingsButton.Enabled = true;
                CorrectConfig = false;
            }
            else
            {
                MessageBox.Show("You missed something! \nIndicators need to be green!");
                ApplyConfigSettingsButton.Enabled = false;
            }
        }

        void CheckProgressBarValues(int SlaveNum)
        {
            switch (SlaveNum)
            {
                case 0:
                    if (SlaveSettings0[0] == true && SlaveSettings0[1] == true && SlaveSettings0[2] == true)
                    {
                        progressBar0.Value = 1;
                    }
                    break;
                case 1:
                    if (SlaveSettings1[0] == true && SlaveSettings1[1] == true && SlaveSettings1[2] == true)
                    {
                        progressBar1.Value = 1;
                    }
                    break;
                case 2:
                    if (SlaveSettings2[0] == true && SlaveSettings2[1] == true && SlaveSettings2[2] == true)
                    {
                        progressBar2.Value = 1;
                    }
                    break;
                case 3:
                    if (SlaveSettings3[0] == true && SlaveSettings3[1] == true && SlaveSettings3[2] == true)
                    {
                        progressBar3.Value = 1;
                    }
                    break;
                case 4:
                    if (SlaveSettings4[0] == true && SlaveSettings4[1] == true && SlaveSettings4[2] == true)
                    {
                        progressBar4.Value = 1;
                    }
                    break;
                case 5:
                    if (SlaveSettings5[0] == true && SlaveSettings5[1] == true && SlaveSettings5[2] == true)
                    {
                        progressBar5.Value = 1;
                    }
                    break;
                case 6:
                    if (SlaveSettings6[0] == true && SlaveSettings6[1] == true && SlaveSettings6[2] == true)
                    {
                        progressBar6.Value = 1;
                    }
                    break;
                case 7:
                    if (SlaveSettings7[0] == true && SlaveSettings7[1] == true && SlaveSettings7[2] == true)
                    {
                        progressBar7.Value = 1;
                    }
                    break;
                case 8:
                    if (SlaveSettings8[0] == true && SlaveSettings8[1] == true && SlaveSettings8[2] == true)
                    {
                        progressBar8.Value = 1;
                    }
                    break;
                case 9:
                    if (SlaveSettings9[0] == true && SlaveSettings9[1] == true && SlaveSettings9[2] == true)
                    {
                        progressBar9.Value = 1;
                    }
                    break;
                case 10:
                    if (SlaveSettings10[0] == true && SlaveSettings10[1] == true && SlaveSettings10[2] == true)
                    {
                        progressBar10.Value = 1;
                    }
                    break;
                case 11:
                    if (SlaveSettings11[0] == true && SlaveSettings11[1] == true && SlaveSettings11[2] == true)
                    {
                        progressBar11.Value = 1;
                    }
                    break;
                case 12:
                    if (SlaveSettings12[0] == true && SlaveSettings12[1] == true && SlaveSettings12[2] == true)
                    {
                        progressBar12.Value = 1;
                    }
                    break;
                case 13:
                    if (SlaveSettings13[0] == true && SlaveSettings13[1] == true && SlaveSettings13[2] == true)
                    {
                        progressBar13.Value = 1;
                    }
                    break;
                case 14:
                    if (SlaveSettings14[0] == true && SlaveSettings14[1] == true && SlaveSettings14[2] == true)
                    {
                        progressBar14.Value = 1;
                    }
                    break;
                case 15:
                    if (SlaveSettings15[0] == true && SlaveSettings15[1] == true && SlaveSettings15[2] == true)
                    {
                        progressBar15.Value = 1;
                    }
                    break;
            }
        }

        //=====================================[CREATE_CONFIGURATION_BYTES]=======================================================

        void CreateConfigurationBytes(int slaveCount)
        {
            int huns = 0;
            int tens = 0;
            int ones = 0;
            var SlaveList = new List<Slave> { Slave0, Slave1, Slave2, Slave3,
                                              Slave4, Slave5, Slave6, Slave7,
                                              Slave8, Slave9, Slave10, Slave11,
                                              Slave12, Slave13, Slave14, Slave15};


            ConfigTextBox.AppendText("[Master settings]\n\n");
            ConfigTextBox.AppendText("Used slave count: " + slaveCount + "\n");
            if (FloorNumericValue == 1)
            {
                ConfigTextBox.AppendText("Floor 1 MAX count: " + Floor1Count + "\n");
            }
            else if (FloorNumericValue == 2)
            {
                ConfigTextBox.AppendText("Floor 1 MAX count: " + Floor1Count + "\n");
                ConfigTextBox.AppendText("Floor 2 MAX count: " + Floor2Count + "\n");
            }
            else if (FloorNumericValue == 3)
            {
                ConfigTextBox.AppendText("Floor 1 MAX count: " + Floor1Count + "\n");
                ConfigTextBox.AppendText("Floor 2 MAX count: " + Floor2Count + "\n");
                ConfigTextBox.AppendText("Floor 3 MAX count: " + Floor3Count + "\n");
            }
            else if (FloorNumericValue == 4)
            {
                ConfigTextBox.AppendText("Floor 1 MAX count: " + Floor1Count + "\n");
                ConfigTextBox.AppendText("Floor 2 MAX count: " + Floor2Count + "\n");
                ConfigTextBox.AppendText("Floor 3 MAX count: " + Floor3Count + "\n");
                ConfigTextBox.AppendText("Floor 4 MAX count: " + Floor4Count + "\n");
            }

            ConfigTextBox.AppendText("\n[Slave settings]\n\n");

            MasterConfiguration[4] = Convert.ToByte(UsedSlaveCount); // SLAVECNT

            huns = (Floor1Count / 100) + 48;
            tens = ((Floor1Count % 100) / 10) + 48;
            ones = (Floor1Count % 10) + 48;
            MasterConfiguration[5] = Convert.ToByte(huns); // COUNT1
            MasterConfiguration[6] = Convert.ToByte(tens); // COUNT2
            MasterConfiguration[7] = Convert.ToByte(ones); // COUNT3

            huns = (Floor2Count / 100) + 48; ;
            tens = ((Floor2Count % 100) / 10) + 48; ;
            ones = (Floor2Count % 10) + 48; ;
            MasterConfiguration[8] = Convert.ToByte(huns); // COUNT1
            MasterConfiguration[9] = Convert.ToByte(tens); // COUNT2
            MasterConfiguration[10] = Convert.ToByte(ones); // COUNT3

            huns = (Floor3Count / 100) + 48; ;
            tens = ((Floor3Count % 100) / 10) + 48; ;
            ones = (Floor3Count % 10) + 48; ;
            MasterConfiguration[11] = Convert.ToByte(huns); // COUNT1
            MasterConfiguration[12] = Convert.ToByte(tens); // COUNT2
            MasterConfiguration[13] = Convert.ToByte(ones); // COUNT3

            huns = (Floor4Count / 100) + 48; ;
            tens = ((Floor4Count % 100) / 10) + 48; ;
            ones = (Floor4Count % 10) + 48; ;
            MasterConfiguration[14] = Convert.ToByte(huns); // COUNT1
            MasterConfiguration[15] = Convert.ToByte(tens); // COUNT2
            MasterConfiguration[16] = Convert.ToByte(ones); // COUNT3

            foreach (Slave Slave in SlaveList)
            {
                if (Slave.ID <= UsedSlaveCount-1)
                {
                    ConfigTextBox.AppendText("Slave" + Slave.ID + " MAX count:" + Slave.Count + ", Type: " + Slave.Type
                                            + ", Floor: " + Slave.Floor + "\n");
                }
                Slave.ByteType = Convert.ToByte(Slave.Type);

                if (Slave.Floor == 1)
                {
                    Slave.ByteFloor = 0xF1;
                }
                else if (Slave.Floor == 2)
                {
                    Slave.ByteFloor = 0xF2;
                }
                else if (Slave.Floor == 3)
                {
                    Slave.ByteFloor = 0xF3;
                }
                else if (Slave.Floor == 4)
                {
                    Slave.ByteFloor = 0xF4;
                }

                Slave.ByteCount1 = Convert.ToByte((Slave.Count / 100) + 48);
                Slave.ByteCount2 = Convert.ToByte(((Slave.Count % 100) / 10) + 48);
                Slave.ByteCount3 = Convert.ToByte((Slave.Count % 10) + 48);


                int x = SlaveList.IndexOf(Slave);
                SlaveConfiguration[x, 4] = Slave.ByteType; // TYPE
                SlaveConfiguration[x, 5] = Slave.ByteFloor; // FLOORID
                SlaveConfiguration[x, 6] = Slave.ByteCount1; // COUNT1
                SlaveConfiguration[x, 7] = Slave.ByteCount2; // COUNT2
                SlaveConfiguration[x, 8] = Slave.ByteCount3; // COUNT3
                
            }

        }

        private void NewConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.NewConfigLimiter = 0;
        }

    }

}
//=============================================================[END_OF_NEW_CONFIG]=======================================================

//=====================================[SLAVE_CLASS]=======================================================
public class Slave
{
    public int ID { get; set; }
    public int Type { get; set; }
    public int Floor { get; set; }
    public int Count { get; set; }

    public byte ByteType { get; set; }
    public byte ByteFloor { get; set; }
    public byte ByteCount1 { get; set; }
    public byte ByteCount2 { get; set; }
    public byte ByteCount3 { get; set; }

    public Slave(int id, int type, int floor, int count)
    {
        ID = id;
        Type = type;
        Floor = floor;
        Count = count;
    }
}
