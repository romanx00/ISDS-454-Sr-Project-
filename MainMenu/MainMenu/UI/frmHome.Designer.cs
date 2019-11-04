namespace MainMenu
{
    partial class MainMenu
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIMS = new System.Windows.Forms.Label();
            this.lblFooterCredit = new System.Windows.Forms.Label();
            this.lblMenuMain = new System.Windows.Forms.Label();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.Window;
            this.menuMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.browseToolStripMenuItem,
            this.addRemoveToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(1192, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(6, 100, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(171, 744);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.userToolStripMenuItem.Size = new System.Drawing.Size(158, 66);
            this.userToolStripMenuItem.Text = "User";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(158, 66);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(158, 66);
            this.browseToolStripMenuItem.Text = "Browse";
            // 
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.addRemoveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(158, 66);
            this.addRemoveToolStripMenuItem.Text = "Add/Remove";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(158, 66);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(158, 66);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(158, 66);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFooterCredit);
            this.panel1.Controls.Add(this.lblIMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 42);
            this.panel1.TabIndex = 1;
            // 
            // lblIMS
            // 
            this.lblIMS.AutoSize = true;
            this.lblIMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblIMS.Location = new System.Drawing.Point(45, 9);
            this.lblIMS.Name = "lblIMS";
            this.lblIMS.Size = new System.Drawing.Size(313, 24);
            this.lblIMS.TabIndex = 0;
            this.lblIMS.Text = "VHA Inventory Management System";
            this.lblIMS.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFooterCredit
            // 
            this.lblFooterCredit.AutoSize = true;
            this.lblFooterCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFooterCredit.Location = new System.Drawing.Point(374, 9);
            this.lblFooterCredit.Name = "lblFooterCredit";
            this.lblFooterCredit.Size = new System.Drawing.Size(86, 24);
            this.lblFooterCredit.TabIndex = 1;
            this.lblFooterCredit.Text = "ISDS 454";
            // 
            // lblMenuMain
            // 
            this.lblMenuMain.AutoSize = true;
            this.lblMenuMain.BackColor = System.Drawing.Color.White;
            this.lblMenuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMenuMain.Location = new System.Drawing.Point(1205, 34);
            this.lblMenuMain.Name = "lblMenuMain";
            this.lblMenuMain.Size = new System.Drawing.Size(146, 31);
            this.lblMenuMain.TabIndex = 2;
            this.lblMenuMain.Text = "Main Menu";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 36);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 36);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1363, 744);
            this.Controls.Add(this.lblMenuMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIMS;
        private System.Windows.Forms.Label lblFooterCredit;
        private System.Windows.Forms.Label lblMenuMain;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

