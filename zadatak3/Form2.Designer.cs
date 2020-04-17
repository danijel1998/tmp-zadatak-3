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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WishListForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaSaSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazIzSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.odjavaSaSistemaToolStripMenuItem.Name = "odjavaSaSistemaToolStripMenuItem";
            this.odjavaSaSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odjavaSaSistemaToolStripMenuItem.Text = "Odjava sa sistema";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // izlazIzSistemaToolStripMenuItem
            // 
            this.izlazIzSistemaToolStripMenuItem.Name = "izlazIzSistemaToolStripMenuItem";
            this.izlazIzSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazIzSistemaToolStripMenuItem.Text = "Izlaz iz sistema";
            // 
            // WishListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 318);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WishListForm";
            this.Text = "Lista zelja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaSaSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazIzSistemaToolStripMenuItem;
    }
}