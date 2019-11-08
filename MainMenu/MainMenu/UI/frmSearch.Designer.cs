namespace MainMenu.UI
{
    partial class frmSearch
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSearchMenu = new System.Windows.Forms.Label();
            this.lblFooterIMS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFooterCredit = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.browseToolStripMenuItem,
            this.addRemoveToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1195, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 100, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(168, 744);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.userToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.userToolStripMenuItem.Text = "User ";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.searchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.searchToolStripMenuItem.Text = "Search ";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.browseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.browseToolStripMenuItem.Text = "Add";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.addRemoveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.addRemoveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.addRemoveToolStripMenuItem.Text = "Edit/Remove";
            this.addRemoveToolStripMenuItem.Click += new System.EventHandler(this.addRemoveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.reportsToolStripMenuItem.Text = "Reports ";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.settingsToolStripMenuItem.Text = "Order";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lblSearchMenu
            // 
            this.lblSearchMenu.AutoSize = true;
            this.lblSearchMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSearchMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchMenu.Location = new System.Drawing.Point(1227, 42);
            this.lblSearchMenu.Name = "lblSearchMenu";
            this.lblSearchMenu.Size = new System.Drawing.Size(100, 31);
            this.lblSearchMenu.TabIndex = 1;
            this.lblSearchMenu.Text = "Search";
            // 
            // lblFooterIMS
            // 
            this.lblFooterIMS.AutoSize = true;
            this.lblFooterIMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFooterIMS.Location = new System.Drawing.Point(12, 9);
            this.lblFooterIMS.Name = "lblFooterIMS";
            this.lblFooterIMS.Size = new System.Drawing.Size(313, 24);
            this.lblFooterIMS.TabIndex = 2;
            this.lblFooterIMS.Text = "VHA Inventory Management System";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFooterCredit);
            this.panel1.Controls.Add(this.lblFooterIMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 42);
            this.panel1.TabIndex = 3;
            // 
            // lblFooterCredit
            // 
            this.lblFooterCredit.AutoSize = true;
            this.lblFooterCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFooterCredit.Location = new System.Drawing.Point(352, 9);
            this.lblFooterCredit.Name = "lblFooterCredit";
            this.lblFooterCredit.Size = new System.Drawing.Size(86, 24);
            this.lblFooterCredit.TabIndex = 3;
            this.lblFooterCredit.Text = "ISDS 454";
            this.lblFooterCredit.UseMnemonic = false;
            this.lblFooterCredit.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1363, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearchMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmSearch";
            this.Text = "Search";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lblSearchMenu;
        private System.Windows.Forms.Label lblFooterIMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFooterCredit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}