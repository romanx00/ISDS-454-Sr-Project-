﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu.UI
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void uSerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when user button is clicked //

            this.Hide();
            UI.frmUser newUserForm = new UI.frmUser();
            newUserForm.Show();
        }

        private void frmBrowse_Load(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when Search button is clicked //

            this.Hide();
            UI.frmSearch newSearchForm = new UI.frmSearch();
            newSearchForm.Show();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // opens new form when browse is clicked //
            this.Hide();
            UI.frmAdd newBrowseForm = new UI.frmAdd();
            newBrowseForm.Show();
        }

        private void addRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void repotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // opens new form when reports is called //
            this.Hide();
            UI.frmReports frmReports = new UI.frmReports();
            frmReports.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when log out is called//
            this.Hide();
            UI.frmLogin frmLogin = new UI.frmLogin();
            frmLogin.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when Edit is called//
            this.Hide();
            UI.frmEdit frmEdit = new UI.frmEdit();
            frmEdit.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when Remove is called//
            this.Hide();
            UI.frmRemove frmRemove = new UI.frmRemove();
            frmRemove.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when order is called//
            this.Hide();
            UI.frmOrder frmOrder = new UI.frmOrder();
            frmOrder.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
