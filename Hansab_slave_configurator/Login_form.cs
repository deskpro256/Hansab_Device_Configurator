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

namespace Hansab_slave_configurator
{
    public partial class Login_form : Form
    {
        public string admin = "admin";
        public string admin_password = "Hansab123";
        public string guest = "guest";
        public string guest_password = "Hansab123";
        public string typeAdmin = "admin";
        public string typeGuest = "guest";
        public string usertype;
        public string username;
        public string password;
        public string textFromFile;
        public static int forgotLimiter;

        public Login_form()
        {
            InitializeComponent();
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {
            Incorrect_label.Visible = false;
            username = username_box.Text;
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            Incorrect_label.Visible = false;
            password = password_box.Text;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //ValidateLogin();
            //check for user admin/guest
            //if admin go to admin page
            //else if guest user go to simplified page

            if ((username == admin) && (password == admin_password))
            {
                this.Hide();
                var newwindow = new Main(typeAdmin, username);
                newwindow.Show();
            }

            else if ((username == guest) && (password == guest_password))
            {
                this.Hide();
                var newwindow = new Main(typeGuest, username);
                newwindow.Show();
            }

            else if ( (username != admin) || (username != guest) || (password != guest_password) || (password != admin_password) )
            {
                Incorrect_label.Visible = true;
            }            
        }

        private void ForgotButton_Click(object sender, EventArgs e)
        {
            forgotLimiter++;
            if (forgotLimiter == 1)
            {                
                var newwindow = new ForgotPass();
                newwindow.Show();
            }
        }

        private void ValidateLogin()
        {
            //textFromFile;
            StreamReader readLogins = File.OpenText("lud.lfs");
            textFromFile = readLogins.ReadToEnd();
            readLogins.Close();
            //MessageBox.Show(textFromFile);
            //Current_cfg_box.Text = textFromFile;
        }

        private void Login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}