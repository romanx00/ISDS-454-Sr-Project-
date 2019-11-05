using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when user button is clicked //

            this.Hide();
            UI.frmUser newUserForm = new UI.frmUser();
            newUserForm.Show();
           
          

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
            // opens new form whn add/remove is called//
            this.Hide();
            UI.frmRemove frmAddRemove = new UI.frmRemove();
            frmAddRemove.Show();

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblMenuMain_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new form when order is called//
            this.Hide();
            UI.frmOrder frmOrder = new UI.frmOrder();
            frmOrder.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //opens new form when Edit is called//
            this.Hide();
            UI.frmEdit frmEdit = new UI.frmEdit();
            frmEdit.Show();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //opens new form when remove is called//
            this.Hide();
            UI.frmRemove frmRemove = new UI.frmRemove();
            frmRemove.Show();
        }
    }
}
