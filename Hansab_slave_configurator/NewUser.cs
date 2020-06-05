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
using Hansab_slave_configurator;

namespace Hansab_slave_configurator
{
    public partial class NewUser : Form
    {
        public bool guestType;
        public bool adminType;
        public string usertype;
        public string username;
        public string password = "";
        public string repeatedPassword = "1";
        public string textToFile;

        public NewUser()
        {
            InitializeComponent();
        }
        private void NewUser_Load(object sender, EventArgs e)
        {
            dontMatchlabel.Visible = false;
            CreateButton.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            StreamReader readFile = File.OpenText("lud.lfs");
            string tempText = readFile.ReadToEnd();
            readFile.Close();

            StreamWriter newUser = File.CreateText("lud.lfs");
            textToFile = usertype + " " + username + " " + password + "\n";
            textToFile = tempText + textToFile;

            newUser.Write(textToFile);
            newUser.Close();
            switch (MessageBox.Show("New user '" + username +"' created!", "Success!", MessageBoxButtons.OK))
            {
                case DialogResult.OK: this.Close(); break;
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            username = UsernameBox.Text;
        }

        private void UserTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserTypeBox.Text == "Admin")
            {
                usertype = "admin";
                guestType = false;
                adminType = true;
            }
            else if (UserTypeBox.Text == "Guest")
            {
                usertype = "guest";
                guestType = true;
                adminType = false;
            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            password = PasswordBox.Text;
        }

        private void RepeatPassBox_TextChanged(object sender, EventArgs e)
        {
            repeatedPassword = RepeatPassBox.Text;
            if (repeatedPassword != password)
            {
                dontMatchlabel.Visible = true;
                CreateButton.Enabled = false;
            }
            else
            {
                dontMatchlabel.Visible = false;
                CreateButton.Enabled = true;
            }
        }

        private void NewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.NewUserLimiter = 0;
        }
    }
}
