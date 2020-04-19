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
            changeNumberOfListItems();
            this.buttonDeleteAll.Enabled = false;
            this.buttonDelete.Enabled = false;
            this.buttonAdd.Enabled = false;

        }

        private void logOut(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void exit(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void addWish(object sender, EventArgs e)
        {  
            if (!(textBoxWish.Text == ""))
            {
                listViewWish.Items.Add(this.textBoxWish.Text);
                changeNumberOfListItems();
                textBoxWish.Focus();
                textBoxWish.Text = "";
                this.buttonDeleteAll.Enabled = true;
              
            }
        }

        private void showTime(object sender, EventArgs e)
        {
            this.dateAndTime.Text = DateTime.Now.ToString();
        }

        private void delete(object sender, EventArgs e)
        {   
            foreach (ListViewItem eachItem in listViewWish.SelectedItems)
            {
                listViewWish.Items.Remove(eachItem);
            }
            changeNumberOfListItems();
            this.buttonDeleteAll.Enabled = listViewWish.Items.Count > 0;


        }

        private void deleteAll(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da zelite obrisati sve stavke?","Obrisi sve",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                listViewWish.Items.Clear();
                changeNumberOfListItems();
                this.buttonDelete.Enabled = this.buttonDeleteAll.Enabled = false;
            }
        }

        private void changeNumberOfListItems()
        {
            numberOfWishes.Text = "Broj stavki: " + listViewWish.Items.Count;
        }

        private void textBoxWish_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxWish.Text.Length > 0;
        }

        private void listViewWish_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonDelete.Enabled = this.listViewWish.SelectedItems.Count > 0;
        }
    }
}
