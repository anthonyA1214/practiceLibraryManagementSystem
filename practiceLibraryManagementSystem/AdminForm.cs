using practiceLibraryManagementSystem.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceLibraryManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            pnlBookManagementSubMenu.Visible = false;
            pnlMemberManagementSubMenu.Visible = false;
            pnlBorrowingAndReturningSubMenu.Visible = false;
            pnlReportingAndAnalyticsSubMenu.Visible = false;
        }

        private void openSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }          
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {           
            openSubMenu(pnlBookManagementSubMenu);
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            openSubMenu(pnlMemberManagementSubMenu);
        }

        private void btnBorrowingAndReturning_Click(object sender, EventArgs e)
        {
            openSubMenu(pnlBorrowingAndReturningSubMenu);
        }

        private void btnReportingAndAnalytics_Click(object sender, EventArgs e)
        {
            openSubMenu(pnlReportingAndAnalyticsSubMenu);
        }

        private Form activeForm = null;

        private void openForm(Form newForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlContainer.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void btnAddEditBook_Click(object sender, EventArgs e)
        {
            openForm(new AddEditBook());
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            openForm(new SearchBook());
        }

        private void btnInventoryTracking_Click(object sender, EventArgs e)
        {
            openForm(new InventoryTracking());
        }

        private void btnAddEditMember_Click(object sender, EventArgs e)
        {
            openForm(new AddEditMember());
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            openForm(new SearchMember());
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            openForm(new IssueBook());
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            openForm(new ReturnBook());
        }

        private void bookCurrentLoansOverview_Click(object sender, EventArgs e)
        {
            openForm(new CurrentLoansOverview());
        }

        private void btnCirculationReports_Click(object sender, EventArgs e)
        {
            openForm(new CirculationReports());
        }

        private void btnMemberActivityReports_Click(object sender, EventArgs e)
        {
            openForm(new MemberActivityReports());
        }

        private void btnOverdueItemsReport_Click(object sender, EventArgs e)
        {
            openForm(new OverdueItemsReport());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }    
    }
}
