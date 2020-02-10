﻿using System;
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
        public string tempLIC;
        public String LicenceFile = "licence.lic";
        public String LicContent = "";
        public static int forgotLimiter;
        public bool ValidLicence = false;
        public String[] AllLicences = new String[100] {
"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"
        };


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
            CheckForLIC();
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
        private void ValidateLicence()
        {
            try
            {
                using (StreamReader readLicence = File.OpenText("Licence.lic"))
                {
                    tempLIC = readLicence.ReadToEnd();
                    readLicence.Close();
                }

                for (int i = 0; i <= 100; i++)
                {
                    if (AllLicences[i].Contains(tempLIC))
                    {
                        ValidLicence = true;
                    }
                    else
                    {
                        ValidLicence = false;
                    }
                    if (ValidLicence)
                    {
                        ValidateLogin();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Licence file doesn't match!", "Licence activation failed!", MessageBoxButtons.OK);
            }

        }
        private void CheckForLIC()
        {
            LicenceFile = "Licence.lic";
            LicContent = " ";
            if (File.Exists(LicenceFile) == true)
            {
                ValidateLicence();
            }

            else
            {
                switch (MessageBox.Show("No licence file found!\nWould you like to add one now?", "Licence not found!", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                                ))
                {
                    case DialogResult.Yes: AddLicence(); break;
                    case DialogResult.No: break;
                }
;
            }

        }
        private void AddLicence()
        {
            openFileDialog1.ShowDialog();
            LicenceFile = openFileDialog1.FileName;
            try
            {
                using (StreamReader filereader = new StreamReader(File.Open(LicenceFile, FileMode.Open)))
                {
                    LicContent = filereader.ReadToEnd();
                }
            }
            catch (Exception)
            {
            }
            using (StreamWriter outputFile = new StreamWriter(File.Open("Licence.lic", FileMode.Create)))
            {
                outputFile.Write(LicContent);
                outputFile.Close();
            }
            CheckForLIC();
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
            String Content = "admin admin Hansab123\n" +
                             "guest guest Guest123\n";
            if (File.Exists(FileName) == true)
            {
                //continue
            }

            else
            {
                using (StreamWriter FileWriter = new StreamWriter(File.Open(FileName, FileMode.Create)))
                {
                    FileWriter.Write(Content);
                    FileWriter.Close();
                }
            }
        }

        private void ChangeLicenceButton_Click(object sender, EventArgs e)
        {
            AddLicence();
        }
    }
}