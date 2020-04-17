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
            numberOfWishes.Text = "Broj stavki: " + listViewWish.Items.Count;
            this.buttonDeleteAll.Enabled = false;
            this.buttonDelete.Enabled = false;
            this.buttonAdd.Enabled = false;

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
            if (!(textBoxWish.Text == ""))
            {
                listViewWish.Items.Add(this.textBoxWish.Text);
                numberOfWishes.Text = "Broj stavki: " + listViewWish.Items.Count;
                textBoxWish.Focus();
            }
        }

        private void showTime(object sender, EventArgs e)
        {
            this.dateAndTime.Text = DateTime.Now.ToString();
            this.buttonDeleteAll.Enabled = !(listViewWish.Items.Count == 0);
            this.buttonDelete.Enabled = !(listViewWish.Items.Count == 0) && !(listViewWish.SelectedItems.Count ==0);
            this.buttonAdd.Enabled = !(textBoxWish.Text == "");
        }

        private void delete(object sender, EventArgs e)
        {   
            foreach (ListViewItem eachItem in listViewWish.SelectedItems)
            {
                listViewWish.Items.Remove(eachItem);
            }
            numberOfWishes.Text = "Broj stavki: " + listViewWish.Items.Count;
        }

        private void deleteAll(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da zelite obrisati sve stavke?","Obrisi sve",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                listViewWish.Items.Clear();
                numberOfWishes.Text = "Broj stavki: " + listViewWish.Items.Count;
            }
        }
    }
}
