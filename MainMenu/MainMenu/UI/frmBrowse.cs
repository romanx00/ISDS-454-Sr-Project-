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
    public partial class frmBrowse : Form
    {
        public frmBrowse()
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
            UI.frmBrowse newBrowseForm = new UI.frmBrowse();
            newBrowseForm.Show();
        }

        private void addRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // opens new form whn add/remove is called//
            this.Hide();
            UI.frmAddRemove frmAddRemove = new UI.frmAddRemove();
            frmAddRemove.Show();
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
    }
}
