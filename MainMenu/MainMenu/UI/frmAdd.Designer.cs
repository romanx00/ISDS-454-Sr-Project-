namespace MainMenu.UI
{
    partial class frmAdd
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
            this.menuBrowse = new System.Windows.Forms.MenuStrip();
            this.uSerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFooterIMS = new System.Windows.Forms.Label();
            this.lblFooterCredit = new System.Windows.Forms.Label();
            this.lblMenuBrowse = new System.Windows.Forms.Label();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBrowse.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBrowse
            // 
            this.menuBrowse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuBrowse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSerToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.browseToolStripMenuItem,
            this.addRemoveToolStripMenuItem,
            this.repotsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuBrowse.Location = new System.Drawing.Point(1195, 0);
            this.menuBrowse.Name = "menuBrowse";
            this.menuBrowse.Padding = new System.Windows.Forms.Padding(6, 100, 0, 2);
            this.menuBrowse.Size = new System.Drawing.Size(168, 744);
            this.menuBrowse.TabIndex = 0;
            this.menuBrowse.Text = "menuStrip1";
            // 
            // uSerToolStripMenuItem
            // 
            this.uSerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uSerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.uSerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uSerToolStripMenuItem.Name = "uSerToolStripMenuItem";
            this.uSerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.uSerToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.uSerToolStripMenuItem.Text = "User";
            this.uSerToolStripMenuItem.Click += new System.EventHandler(this.uSerToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.browseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.addRemoveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            // repotsToolStripMenuItem
            // 
            this.repotsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repotsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.repotsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repotsToolStripMenuItem.Name = "repotsToolStripMenuItem";
            this.repotsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.repotsToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.repotsToolStripMenuItem.Text = "Reports";
            this.repotsToolStripMenuItem.Click += new System.EventHandler(this.repotsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.logOutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(155, 66);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFooterIMS);
            this.panel1.Controls.Add(this.lblFooterCredit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 42);
            this.panel1.TabIndex = 1;
            // 
            // lblFooterIMS
            // 
            this.lblFooterIMS.AutoSize = true;
            this.lblFooterIMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFooterIMS.Location = new System.Drawing.Point(12, 12);
            this.lblFooterIMS.Name = "lblFooterIMS";
            this.lblFooterIMS.Size = new System.Drawing.Size(313, 24);
            this.lblFooterIMS.TabIndex = 2;
            this.lblFooterIMS.Text = "VHA Inventory Management System";
            // 
            // lblFooterCredit
            // 
            this.lblFooterCredit.AutoSize = true;
            this.lblFooterCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFooterCredit.Location = new System.Drawing.Point(403, 12);
            this.lblFooterCredit.Name = "lblFooterCredit";
            this.lblFooterCredit.Size = new System.Drawing.Size(86, 24);
            this.lblFooterCredit.TabIndex = 3;
            this.lblFooterCredit.Text = "ISDS 454";
            // 
            // lblMenuBrowse
            // 
            this.lblMenuBrowse.AutoSize = true;
            this.lblMenuBrowse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMenuBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenuBrowse.Location = new System.Drawing.Point(1228, 36);
            this.lblMenuBrowse.Name = "lblMenuBrowse";
            this.lblMenuBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMenuBrowse.Size = new System.Drawing.Size(105, 31);
            this.lblMenuBrowse.TabIndex = 4;
            this.lblMenuBrowse.Text = "Browse";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 36);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 36);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 744);
            this.Controls.Add(this.lblMenuBrowse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBrowse);
            this.MainMenuStrip = this.menuBrowse;
            this.Name = "frmAdd";
            this.Text = "frmBrowse";
            this.Load += new System.EventHandler(this.frmBrowse_Load);
            this.menuBrowse.ResumeLayout(false);
            this.menuBrowse.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBrowse;
        private System.Windows.Forms.ToolStripMenuItem uSerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFooterIMS;
        private System.Windows.Forms.Label lblFooterCredit;
        private System.Windows.Forms.Label lblMenuBrowse;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}