using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zadatak3.Properties;

namespace zadatak3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxUsername.Focus();
        }

        private void showPassword(object sender, MouseEventArgs e)
        {
            this.textBoxPassword.PasswordChar = '\0';
        }

        private void hidePassword(object sender, MouseEventArgs e)
        {
            this.textBoxPassword.PasswordChar = '*';
        }

        private void login(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == Settings.Default.Password && textBoxUsername.Text == Settings.Default.Username)
            {
                this.Hide();
                WishListForm form = new WishListForm();
                form.Show();
                
            }
            else
            {
                MessageBox.Show("Neuspjesna prijava","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
