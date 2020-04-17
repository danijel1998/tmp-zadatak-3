using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak3
{
    public partial class WishListForm : Form
    {
        public WishListForm()
        {
            InitializeComponent();
            this.dateAndTime.Text = DateTime.Now.ToString();
        }

        private void logOut(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addWish(object sender, EventArgs e)
        {
            listViewWish.Items.Add(this.textBoxWish.Text);
            numberOfWishes.Text = numberOfWishes.Text + listViewWish.Items.Count;
            textBoxWish.Focus();
        }

        private void showTime(object sender, EventArgs e)
        {
            this.dateAndTime.Text = DateTime.Now.ToString();
        }
    }
}
