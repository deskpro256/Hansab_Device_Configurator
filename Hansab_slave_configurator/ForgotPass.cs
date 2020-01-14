using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hansab_slave_configurator
{
    public partial class ForgotPass : Form
    {
        public string username = "";
        public string password = "";
        public string repeatPassword = "";
        public string textFromFile = "";
        public string tempLUD = "";
        public string newText = "";


        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //find username in user files, if there, replace passwords, else, user not found!
            if (username != "")
            {
                using (StreamReader readLogins = File.OpenText("lud.lfs"))
                {
                    textFromFile = "";
                    try
                    {
                        textFromFile = readLogins.ReadToEnd();
                        readLogins.Close();
                        if (textFromFile.Contains(username) == false)
                        {
                            MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception)
                    {
                    }

                }
                if (password == repeatPassword && password != "")
                {
                    replacePassword();
                }
                else if (password != repeatPassword && password != "" || repeatPassword != "")
                {
                    MessageBox.Show("Passwords don't match", "Something happened", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Fields can't be empty!", "Something happened", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Fields can't be empty!", "Something happened", MessageBoxButtons.OK);
            }

        }

        public void replacePassword()
        {

            using (StreamReader readLogins = File.OpenText("lud.lfs"))
            {
                tempLUD = readLogins.ReadToEnd();
                readLogins.Close();
            }
            StringReader strReader = new StringReader(tempLUD);
            textFromFile = "";
            try
            {
                while (textFromFile.Contains(username) == false)
                {
                    textFromFile = strReader.ReadLine();
                    //MessageBox.Show(textFromFile, "textFromFile", MessageBoxButtons.OK);
                    if (textFromFile.Contains(username) == true)
                    {
                        if (textFromFile.Contains("admin") == true)
                        {
                            newText = "admin " + username + " " + password + "\n";
                            tempLUD.Replace(textFromFile, newText);
                            tempLUD += newText;
                            //MessageBox.Show(tempLUD, "tempLUD", MessageBoxButtons.OK);
                            File.Delete("lud.lfs");
                            StreamWriter SWriter = File.CreateText("lud.lfs");
                            SWriter.Write(tempLUD);
                            SWriter.Close();
                            MessageBox.Show(" Username found!\n Password changed!", "Success!", MessageBoxButtons.OK);
                            break;
                        }
                        else if (textFromFile.Contains("guest") == true)
                        {
                            newText = "guest " + username + " " + password + "\n";
                            tempLUD.Replace(textFromFile, newText);
                            tempLUD += newText;
                            //MessageBox.Show(tempLUD, "tempLUD", MessageBoxButtons.OK);
                            File.Delete("lud.lfs");
                            StreamWriter SWriter = File.CreateText("lud.lfs");
                            SWriter.Write(tempLUD);
                            SWriter.Close();
                            MessageBox.Show(" Username found!\n Password changed!", "Success!", MessageBoxButtons.OK);
                            break;
                        }
                    }
                }

            }
            catch (Exception)
            {
            }

        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            password = PasswordBox.Text;
        }

        private void RepPasswordBox_TextChanged(object sender, EventArgs e)
        {
            repeatPassword = RepPasswordBox.Text;
        }

        private void ForgotPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login_form.forgotLimiter = 0;
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            username = UsernameBox.Text;
        }
    }
}