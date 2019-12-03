using System;
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
    public partial class ForgotPass : Form
    {
        public int supportID;
        public string username;
        public string password;
        public string repeatPassword;

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //find username in user files, if there, replace passwords, else, user not found!

            if (password == repeatPassword && password != "")
            {
                MessageBox.Show("Passwords match", "Something happened", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Passwords don't match", "Something happened", MessageBoxButtons.OK);
            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            password = PasswordBox.Text;
            //get the password string
            //add it to valid passwords
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

        }
    }
}