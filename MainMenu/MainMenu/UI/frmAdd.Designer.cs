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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFooterIMS = new System.Windows.Forms.Label();
            this.lblFooterCredit = new System.Windows.Forms.Label();
            this.lblMenuBrowse = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnDepartmnet = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.txtDepartmentDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
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
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBarcode.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblBarcode.Location = new System.Drawing.Point(613, 48);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(105, 20);
            this.lblBarcode.TabIndex = 5;
            this.lblBarcode.Text = "Item Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(780, 48);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(365, 20);
            this.txtBarcode.TabIndex = 6;
            this.txtBarcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(780, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(365, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(780, 100);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(365, 20);
            this.txtDesc.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(780, 152);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(365, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(780, 126);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(365, 20);
            this.txtLocation.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblName.Location = new System.Drawing.Point(613, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Item Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocation.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblLocation.Location = new System.Drawing.Point(613, 126);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(110, 20);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Item Location ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDescription.Location = new System.Drawing.Point(613, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(129, 20);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Item Description ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblQuantity.Location = new System.Drawing.Point(613, 152);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(108, 20);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Item Quantity ";
            this.lblQuantity.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(908, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Item Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(188, 18);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 13);
            this.lblSupplier.TabIndex = 17;
            this.lblSupplier.Text = "Add Supplier ";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(48, 277);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(93, 13);
            this.lblDepartmentName.TabIndex = 18;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(188, 244);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(84, 13);
            this.lblDepartment.TabIndex = 19;
            this.lblDepartment.Text = "Add Department";
            this.lblDepartment.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(85, 55);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 20;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(172, 274);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(100, 20);
            this.txtDepartmentName.TabIndex = 21;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(172, 55);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 22;
            // 
            // btnDepartmnet
            // 
            this.btnDepartmnet.Location = new System.Drawing.Point(407, 283);
            this.btnDepartmnet.Name = "btnDepartmnet";
            this.btnDepartmnet.Size = new System.Drawing.Size(110, 23);
            this.btnDepartmnet.TabIndex = 23;
            this.btnDepartmnet.Text = "Department Add";
            this.btnDepartmnet.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(407, 84);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(110, 23);
            this.btnSupplier.TabIndex = 24;
            this.btnSupplier.Text = "Supplier Add";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // txtDepartmentDescription
            // 
            this.txtDepartmentDescription.Location = new System.Drawing.Point(172, 300);
            this.txtDepartmentDescription.Name = "txtDepartmentDescription";
            this.txtDepartmentDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDepartmentDescription.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Department Description";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(172, 84);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 28;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(85, 84);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 27;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(172, 139);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 32;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(85, 139);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(172, 110);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 30;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(85, 110);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 29;
            this.lblStreet.Text = "Street";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(172, 194);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 36;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(85, 194);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 35;
            this.lblZip.Text = "Zip";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(172, 165);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 34;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(85, 165);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 33;
            this.lblState.Text = "State";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1363, 744);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtDepartmentDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnDepartmnet);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcode);
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
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnDepartmnet;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.TextBox txtDepartmentDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
    }
}