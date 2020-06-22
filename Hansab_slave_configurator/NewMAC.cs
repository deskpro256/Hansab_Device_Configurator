using Hansab_slave_configurator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hansab_Parking_Configurator
{
    public partial class NewMAC : Form
    {
        public NewMAC()
        {
            InitializeComponent();
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Main.MACConfig[4] = Convert.ToByte(Convert.ToInt32(MAC1.Text, 16));
                Main.MACConfig[5] = Convert.ToByte(Convert.ToInt32(MAC2.Text, 16));
                Main.MACConfig[6] = Convert.ToByte(Convert.ToInt32(MAC3.Text, 16));
                Main.MACConfig[7] = Convert.ToByte(Convert.ToInt32(MAC4.Text, 16));
                Main.MACConfig[8] = Convert.ToByte(Convert.ToInt32(MAC5.Text, 16));
                Main.MACConfig[9] = Convert.ToByte(Convert.ToInt32(MAC6.Text, 16));
                Main.MACConfigSend = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Check if there are no empty fields or are filed with (0-9 & A-F) only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Main.MACConfigSend = false;
            }
            /*
            String MACAddress =
                Main.MACConfig[4] + ":" +
                Main.MACConfig[5] + ":" +
                Main.MACConfig[6] + ":" +
                Main.MACConfig[7] + ":" +
                Main.MACConfig[8] + ":" +
                Main.MACConfig[9];

            MessageBox.Show(MACAddress, "MAC Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }

        private void NewMAC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Network.NewMACLimiter = 0;
        }
    }
}
