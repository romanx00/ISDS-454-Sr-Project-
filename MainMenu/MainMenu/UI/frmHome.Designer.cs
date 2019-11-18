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
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooterCredit = new System.Windows.Forms.Label();
            this.lblIMS = new System.Windows.Forms.Label();
            this.lblMenuMain = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.browseToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(1195, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(6, 100, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(168, 744);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            this.menuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMain_ItemClicked);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.userToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.searchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1});
            this.browseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.browseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.browseToolStripMenuItem.Text = "Add";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(133, 36);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.editRemoveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.editRemoveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.editRemoveToolStripMenuItem.Text = "Edit/Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(176, 36);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(176, 36);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.reportsToolStripMenuItem.Text = "Reports";
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
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripMenuItem1});
            this.addRemoveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.addRemoveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addRemoveToolStripMenuItem.Text = "Edit/ Remove";
            this.addRemoveToolStripMenuItem.Click += new System.EventHandler(this.addRemoveToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.addToolStripMenuItem.Text = "Edit";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 36);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblFooterCredit);
            this.panelFooter.Controls.Add(this.lblIMS);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 702);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1195, 42);
            this.panelFooter.TabIndex = 1;
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
            // lblMenuMain
            // 
            this.lblMenuMain.AutoSize = true;
            this.lblMenuMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMenuMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenuMain.Location = new System.Drawing.Point(1205, 34);
            this.lblMenuMain.Name = "lblMenuMain";
            this.lblMenuMain.Size = new System.Drawing.Size(146, 31);
            this.lblMenuMain.TabIndex = 2;
            this.lblMenuMain.Text = "Main Menu";
            this.lblMenuMain.Click += new System.EventHandler(this.lblMenuMain_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1363, 744);
            this.Controls.Add(this.lblMenuMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
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
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblIMS;
        private System.Windows.Forms.Label lblFooterCredit;
        private System.Windows.Forms.Label lblMenuMain;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
    }
}

