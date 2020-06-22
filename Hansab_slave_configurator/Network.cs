using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hansab_slave_configurator;

namespace Hansab_Parking_Configurator
{
    public partial class Network : Form
    {

        public static int NewMACLimiter = 0;
        public Network()
        {
            InitializeComponent();
            SaveButton.Enabled = false;
            ClearButton.Enabled = false;
            IPBox1.Enabled = false;
            IPBox2.Enabled = false;
            IPBox3.Enabled = false;
            IPBox4.Enabled = false;

            SNBox1.Enabled = false;
            SNBox2.Enabled = false;
            SNBox3.Enabled = false;
            SNBox4.Enabled = false;

            GWBox1.Enabled = false;
            GWBox2.Enabled = false;
            GWBox3.Enabled = false;
            GWBox4.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Main.NewIPEditorLimiter = 0;
            SaveNetworkSettings();
            if (Main.NWConfigSend == true)
            {
                this.Close();
            }
        }
        void SaveNetworkSettings()
        {
            if (DHCPButton.Checked == true)
            {
                // DHCP
                //Main.DHCP = 0x01;
                // IP
                Main.IP[0] = 0x00;
                Main.IP[1] = 0x00;
                Main.IP[2] = 0x00;
                Main.IP[3] = 0x00;
                // Subnet
                Main.SN[0] = 0x00;
                Main.SN[1] = 0x00;
                Main.SN[2] = 0x00;
                Main.SN[3] = 0x00;
                // Gateway
                Main.GW[0] = 0x00;
                Main.GW[1] = 0x00;
                Main.GW[2] = 0x00;
                Main.GW[3] = 0x00;

                Main.NWConfigSend = true;
            }
            else
            {
                try
                {
                    // DHCP
                    //Main.DHCP = 0x00;
                    // IP
                    Main.IP[0] = Convert.ToByte(Convert.ToInt32(IPBox1.Text));
                    Main.IP[1] = Convert.ToByte(Convert.ToInt32(IPBox2.Text));
                    Main.IP[2] = Convert.ToByte(Convert.ToInt32(IPBox3.Text));
                    Main.IP[3] = Convert.ToByte(Convert.ToInt32(IPBox4.Text));
                    // Subnet
                    Main.SN[0] = Convert.ToByte(Convert.ToInt32(SNBox1.Text));
                    Main.SN[1] = Convert.ToByte(Convert.ToInt32(SNBox2.Text));
                    Main.SN[2] = Convert.ToByte(Convert.ToInt32(SNBox3.Text));
                    Main.SN[3] = Convert.ToByte(Convert.ToInt32(SNBox4.Text));
                    // Gateway
                    Main.GW[0] = Convert.ToByte(Convert.ToInt32(GWBox1.Text));
                    Main.GW[1] = Convert.ToByte(Convert.ToInt32(GWBox2.Text));
                    Main.GW[2] = Convert.ToByte(Convert.ToInt32(GWBox3.Text));
                    Main.GW[3] = Convert.ToByte(Convert.ToInt32(GWBox4.Text));
                    Main.NWConfigSend = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Check if there are no empty fields or are filed with numbers only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Main.NWConfigSend = false;
                }
            }

        }
        void ClearSettings()
        {
            IPBox1.Text = "";
            IPBox2.Text = "";
            IPBox3.Text = "";
            IPBox4.Text = "";

            GWBox1.Text = "";
            GWBox2.Text = "";
            GWBox3.Text = "";
            GWBox4.Text = "";

            SNBox1.Text = "";
            SNBox2.Text = "";
            SNBox3.Text = "";
            SNBox4.Text = "";

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearSettings();
        }


        private void Network_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.NewIPEditorLimiter = 0;
        }

        private void DHCPButton_Click(object sender, EventArgs e)
        {
            Main.DHCP = 0x01;
            ManualButton.Checked = false;
            ClearButton.Enabled = false;
            SaveButton.Enabled = true;
            ClearSettings();

            IPBox1.Enabled = false;
            IPBox2.Enabled = false;
            IPBox3.Enabled = false;
            IPBox4.Enabled = false;

            SNBox1.Enabled = false;
            SNBox2.Enabled = false;
            SNBox3.Enabled = false;
            SNBox4.Enabled = false;

            GWBox1.Enabled = false;
            GWBox2.Enabled = false;
            GWBox3.Enabled = false;
            GWBox4.Enabled = false;
        }

        private void ManualButton_Click(object sender, EventArgs e)
        {
            Main.DHCP = 0x00;
            DHCPButton.Checked = false;
            ClearButton.Enabled = true;
            SaveButton.Enabled = true;

            IPBox1.Enabled = true;
            IPBox2.Enabled = true;
            IPBox3.Enabled = true;
            IPBox4.Enabled = true;

            SNBox1.Enabled = true;
            SNBox2.Enabled = true;
            SNBox3.Enabled = true;
            SNBox4.Enabled = true;

            GWBox1.Enabled = true;
            GWBox2.Enabled = true;
            GWBox3.Enabled = true;
            GWBox4.Enabled = true;
        }

        private void Network_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == '~')
            {
                switch (MessageBox.Show("Are you sure you want to edit the device's MAC Address?", "MAC Change", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question
                               ))
                {
                    case DialogResult.Yes: ChangMAC(); break;
                    case DialogResult.No: break;
                }
            }
        }
        void ChangMAC()
        {
            NewMACLimiter++;
            if (NewMACLimiter == 1)
            {
                var newwindow = new NewMAC();
                newwindow.Show();
            }

        }

    }
}
