namespace zadatak3
{
    partial class WishListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WishListForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaSaSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazIzSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWish = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDateAndTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateAndTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberOfWishes = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewWish = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaSaSistemaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazIzSistemaToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // odjavaSaSistemaToolStripMenuItem
            // 
            this.odjavaSaSistemaToolStripMenuItem.Image = global::zadatak3.Properties.Resources.logout;
            this.odjavaSaSistemaToolStripMenuItem.Name = "odjavaSaSistemaToolStripMenuItem";
            this.odjavaSaSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odjavaSaSistemaToolStripMenuItem.Text = "Odjava sa sistema";
            this.odjavaSaSistemaToolStripMenuItem.Click += new System.EventHandler(this.logOut);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // izlazIzSistemaToolStripMenuItem
            // 
            this.izlazIzSistemaToolStripMenuItem.Image = global::zadatak3.Properties.Resources.Sign_Shutdown_icon1;
            this.izlazIzSistemaToolStripMenuItem.Name = "izlazIzSistemaToolStripMenuItem";
            this.izlazIzSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazIzSistemaToolStripMenuItem.Text = "Izlaz iz sistema";
            this.izlazIzSistemaToolStripMenuItem.Click += new System.EventHandler(this.exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upisite zelju";
            // 
            // textBoxWish
            // 
            this.textBoxWish.Location = new System.Drawing.Point(22, 88);
            this.textBoxWish.Name = "textBoxWish";
            this.textBoxWish.Size = new System.Drawing.Size(199, 20);
            this.textBoxWish.TabIndex = 3;
            this.textBoxWish.TextChanged += new System.EventHandler(this.textBoxWish_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDateAndTime,
            this.dateAndTime,
            this.numberOfWishes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 296);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDateAndTime
            // 
            this.toolStripDateAndTime.Name = "toolStripDateAndTime";
            this.toolStripDateAndTime.Size = new System.Drawing.Size(0, 17);
            // 
            // dateAndTime
            // 
            this.dateAndTime.Name = "dateAndTime";
            this.dateAndTime.Size = new System.Drawing.Size(0, 17);
            // 
            // numberOfWishes
            // 
            this.numberOfWishes.Name = "numberOfWishes";
            this.numberOfWishes.Size = new System.Drawing.Size(64, 17);
            this.numberOfWishes.Text = "Broj stavki:";
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Image = global::zadatak3.Properties.Resources.trash_icon;
            this.buttonDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteAll.Location = new System.Drawing.Point(25, 225);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(196, 41);
            this.buttonDeleteAll.TabIndex = 4;
            this.buttonDeleteAll.Text = "Obrisi sve stavke";
            this.buttonDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.deleteAll);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::zadatak3.Properties.Resources.Actions_edit_delete_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(25, 178);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(196, 41);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Obrisi oznacenu stavku";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.delete);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::zadatak3.Properties.Resources.Actions_list_add_icon;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(24, 131);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 41);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Dodaj na listu";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.addWish);
            // 
            // listViewWish
            // 
            this.listViewWish.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewWish.HideSelection = false;
            this.listViewWish.HoverSelection = true;
            this.listViewWish.Location = new System.Drawing.Point(247, 88);
            this.listViewWish.Name = "listViewWish";
            this.listViewWish.Size = new System.Drawing.Size(205, 178);
            this.listViewWish.TabIndex = 6;
            this.listViewWish.UseCompatibleStateImageBehavior = false;
            this.listViewWish.View = System.Windows.Forms.View.List;
            this.listViewWish.SelectedIndexChanged += new System.EventHandler(this.listViewWish_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.showTime);
            // 
            // WishListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 318);
            this.Controls.Add(this.listViewWish);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxWish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WishListForm";
            this.Text = "Lista zelja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaSaSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazIzSistemaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWish;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDateAndTime;
        private System.Windows.Forms.ListView listViewWish;
        private System.Windows.Forms.ToolStripStatusLabel dateAndTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel numberOfWishes;
    }
}