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
        public bool LoggedIn = false;
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
            ValidateLogin();
            //check for user admin/guest
            //if admin go to admin page
            //else if guest user go to simplified page

        }
        private void GuestLogin()
        {
            this.Hide();
            var newwindow = new Main(typeGuest, username);
            newwindow.Show();


        }
        private void AdminLogin()
        {
            this.Hide();
            var newwindow = new Main(typeAdmin, username);
            newwindow.Show();


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

            using (StreamReader readLogins = File.OpenText("lud.lfs"))
            {
                while (readLogins.Peek() > -1 || LoggedIn != true)
                {
                    try
                    {
                        textFromFile = readLogins.ReadLine();
                        if (textFromFile.Contains(typeAdmin) && textFromFile.Contains(username) && textFromFile.Contains(password))
                        {
                            LoggedIn = true;
                            readLogins.Close();
                            AdminLogin();
                            break;
                        }
                        else if (textFromFile.Contains(typeGuest) && textFromFile.Contains(username) && textFromFile.Contains(password))
                        {
                            LoggedIn = true;
                            readLogins.Close();
                            GuestLogin();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password!", "Warning!", MessageBoxButtons.OK);
                            LoggedIn = false;
                            Incorrect_label.Visible = true;
                        }

                    }
                    catch (Exception)
                    {
                        break;
                    }

                }
                readLogins.Close();
            }
        }

        private void Login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}