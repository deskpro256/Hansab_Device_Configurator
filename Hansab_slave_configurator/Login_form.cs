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
        public string tempLUD;
        public static int forgotLimiter;

        public Login_form()
        {
            InitializeComponent();
            CheckForLUD();
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
            try
            {
                using (StreamReader readLogins = File.OpenText("lud.lfs"))
                {
                    tempLUD = readLogins.ReadToEnd();
                    readLogins.Close();
                }
                StringReader strReader = new StringReader(tempLUD);
                textFromFile = "";
                while (textFromFile.Contains(username) == false || LoggedIn != true)
                {
                    try
                    {
                        textFromFile = strReader.ReadLine();
                        if (textFromFile.Contains(typeAdmin) && textFromFile.Contains(username) && textFromFile.Contains(password))
                        {
                            LoggedIn = true;
                            AdminLogin();
                            break;
                        }
                        else if (textFromFile.Contains(typeGuest) && textFromFile.Contains(username) && textFromFile.Contains(password))
                        {
                            LoggedIn = true;
                            GuestLogin();
                            break;
                        }
                        else
                        {
                            LoggedIn = false;
                            Incorrect_label.Visible = true;
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }

                }
            }
            catch (Exception)
            {
            }
        }

        private void Login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void CheckForLUD()
        {
            String FileName = "lud.lfs";
            String Content = "admin admin Hansab123 \n" +
                             "guest guest Guest123 \n ";
            if (File.Exists(FileName) == true)
            {
                //continue
            }

            else
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(FileName, FileMode.Create)))
                {
                    binaryWriter.Write(Content);
                    binaryWriter.Close();
                }
            }
        }

    }
}