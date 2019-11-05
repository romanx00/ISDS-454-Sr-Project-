using System;
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
    public partial class frmRemove : Form
    {
        public frmRemove()
        {
            InitializeComponent();
        }

        private void lblFooterIMS_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when user is called//
            this.Hide();
            UI.frmUser frmUser = new UI.frmUser();
            frmUser.Show();
        }

        private void lblMenuAdd_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when Search is called//
            this.Hide();
            UI.frmSearch frmSearch = new UI.frmSearch();
            frmSearch.Show();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when add is called//
            this.Hide();
            UI.frmAdd frmAdd = new UI.frmAdd();
            frmAdd.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when edit is called//
            this.Hide();
            UI.frmEdit frmEdit = new UI.frmEdit();
            frmEdit.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when remove is called//
            this.Hide();
            UI.frmRemove frmRemove = new UI.frmRemove();
            frmRemove.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when reports is called//
            this.Hide();
            UI.frmReports frmReports = new UI.frmReports();
            frmReports.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when order is called//
            this.Hide();
            UI.frmOrder frmOrder = new UI.frmOrder();
            frmOrder.Show();
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
