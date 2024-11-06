namespace practiceLibraryManagementSystem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlReportingAndAnalyticsSubMenu = new System.Windows.Forms.Panel();
            this.btnOverdueItemsReport = new System.Windows.Forms.Button();
            this.btnMemberActivityReports = new System.Windows.Forms.Button();
            this.btnCirculationReports = new System.Windows.Forms.Button();
            this.btnReportingAndAnalytics = new System.Windows.Forms.Button();
            this.pnlBorrowingAndReturningSubMenu = new System.Windows.Forms.Panel();
            this.bookCurrentLoansOverview = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnBorrowingAndReturning = new System.Windows.Forms.Button();
            this.pnlMemberManagementSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnAddEditMember = new System.Windows.Forms.Button();
            this.btnMemberManagement = new System.Windows.Forms.Button();
            this.pnlBookManagementSubMenu = new System.Windows.Forms.Panel();
            this.btnInventoryTracking = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnAddEditBook = new System.Windows.Forms.Button();
            this.btnBookManagement = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlReportingAndAnalyticsSubMenu.SuspendLayout();
            this.pnlBorrowingAndReturningSubMenu.SuspendLayout();
            this.pnlMemberManagementSubMenu.SuspendLayout();
            this.pnlBookManagementSubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlSideMenu.Controls.Add(this.btnLogout);
            this.pnlSideMenu.Controls.Add(this.pnlReportingAndAnalyticsSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnReportingAndAnalytics);
            this.pnlSideMenu.Controls.Add(this.pnlBorrowingAndReturningSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnBorrowingAndReturning);
            this.pnlSideMenu.Controls.Add(this.pnlMemberManagementSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnMemberManagement);
            this.pnlSideMenu.Controls.Add(this.pnlBookManagementSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnBookManagement);
            this.pnlSideMenu.Controls.Add(this.btnDashboard);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(250, 561);
            this.pnlSideMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::practiceLibraryManagementSystem.Properties.Resources.profile;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 810);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(233, 45);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "        Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlReportingAndAnalyticsSubMenu
            // 
            this.pnlReportingAndAnalyticsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlReportingAndAnalyticsSubMenu.Controls.Add(this.btnOverdueItemsReport);
            this.pnlReportingAndAnalyticsSubMenu.Controls.Add(this.btnMemberActivityReports);
            this.pnlReportingAndAnalyticsSubMenu.Controls.Add(this.btnCirculationReports);
            this.pnlReportingAndAnalyticsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportingAndAnalyticsSubMenu.Location = new System.Drawing.Point(0, 685);
            this.pnlReportingAndAnalyticsSubMenu.Name = "pnlReportingAndAnalyticsSubMenu";
            this.pnlReportingAndAnalyticsSubMenu.Size = new System.Drawing.Size(233, 125);
            this.pnlReportingAndAnalyticsSubMenu.TabIndex = 9;
            // 
            // btnOverdueItemsReport
            // 
            this.btnOverdueItemsReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverdueItemsReport.FlatAppearance.BorderSize = 0;
            this.btnOverdueItemsReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnOverdueItemsReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnOverdueItemsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverdueItemsReport.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnOverdueItemsReport.ForeColor = System.Drawing.Color.White;
            this.btnOverdueItemsReport.Location = new System.Drawing.Point(0, 80);
            this.btnOverdueItemsReport.Name = "btnOverdueItemsReport";
            this.btnOverdueItemsReport.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOverdueItemsReport.Size = new System.Drawing.Size(233, 40);
            this.btnOverdueItemsReport.TabIndex = 2;
            this.btnOverdueItemsReport.Text = "       Overdue Items Report";
            this.btnOverdueItemsReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverdueItemsReport.UseVisualStyleBackColor = true;
            this.btnOverdueItemsReport.Click += new System.EventHandler(this.btnOverdueItemsReport_Click);
            // 
            // btnMemberActivityReports
            // 
            this.btnMemberActivityReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberActivityReports.FlatAppearance.BorderSize = 0;
            this.btnMemberActivityReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnMemberActivityReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnMemberActivityReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberActivityReports.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnMemberActivityReports.ForeColor = System.Drawing.Color.White;
            this.btnMemberActivityReports.Location = new System.Drawing.Point(0, 40);
            this.btnMemberActivityReports.Name = "btnMemberActivityReports";
            this.btnMemberActivityReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMemberActivityReports.Size = new System.Drawing.Size(233, 40);
            this.btnMemberActivityReports.TabIndex = 1;
            this.btnMemberActivityReports.Text = "       Member Activity Reports";
            this.btnMemberActivityReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberActivityReports.UseVisualStyleBackColor = true;
            this.btnMemberActivityReports.Click += new System.EventHandler(this.btnMemberActivityReports_Click);
            // 
            // btnCirculationReports
            // 
            this.btnCirculationReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCirculationReports.FlatAppearance.BorderSize = 0;
            this.btnCirculationReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCirculationReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCirculationReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculationReports.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCirculationReports.ForeColor = System.Drawing.Color.White;
            this.btnCirculationReports.Location = new System.Drawing.Point(0, 0);
            this.btnCirculationReports.Name = "btnCirculationReports";
            this.btnCirculationReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCirculationReports.Size = new System.Drawing.Size(233, 40);
            this.btnCirculationReports.TabIndex = 0;
            this.btnCirculationReports.Text = "       Circulation Reports";
            this.btnCirculationReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCirculationReports.UseVisualStyleBackColor = true;
            this.btnCirculationReports.Click += new System.EventHandler(this.btnCirculationReports_Click);
            // 
            // btnReportingAndAnalytics
            // 
            this.btnReportingAndAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportingAndAnalytics.FlatAppearance.BorderSize = 0;
            this.btnReportingAndAnalytics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnReportingAndAnalytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnReportingAndAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportingAndAnalytics.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportingAndAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnReportingAndAnalytics.Image = global::practiceLibraryManagementSystem.Properties.Resources.profile;
            this.btnReportingAndAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportingAndAnalytics.Location = new System.Drawing.Point(0, 640);
            this.btnReportingAndAnalytics.Name = "btnReportingAndAnalytics";
            this.btnReportingAndAnalytics.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportingAndAnalytics.Size = new System.Drawing.Size(233, 45);
            this.btnReportingAndAnalytics.TabIndex = 8;
            this.btnReportingAndAnalytics.Text = "        Reporting and Analytics";
            this.btnReportingAndAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportingAndAnalytics.UseVisualStyleBackColor = true;
            this.btnReportingAndAnalytics.Click += new System.EventHandler(this.btnReportingAndAnalytics_Click);
            // 
            // pnlBorrowingAndReturningSubMenu
            // 
            this.pnlBorrowingAndReturningSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlBorrowingAndReturningSubMenu.Controls.Add(this.bookCurrentLoansOverview);
            this.pnlBorrowingAndReturningSubMenu.Controls.Add(this.btnReturnBook);
            this.pnlBorrowingAndReturningSubMenu.Controls.Add(this.btnIssueBook);
            this.pnlBorrowingAndReturningSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorrowingAndReturningSubMenu.Location = new System.Drawing.Point(0, 515);
            this.pnlBorrowingAndReturningSubMenu.Name = "pnlBorrowingAndReturningSubMenu";
            this.pnlBorrowingAndReturningSubMenu.Size = new System.Drawing.Size(233, 125);
            this.pnlBorrowingAndReturningSubMenu.TabIndex = 7;
            // 
            // bookCurrentLoansOverview
            // 
            this.bookCurrentLoansOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookCurrentLoansOverview.FlatAppearance.BorderSize = 0;
            this.bookCurrentLoansOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.bookCurrentLoansOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.bookCurrentLoansOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookCurrentLoansOverview.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bookCurrentLoansOverview.ForeColor = System.Drawing.Color.White;
            this.bookCurrentLoansOverview.Location = new System.Drawing.Point(0, 80);
            this.bookCurrentLoansOverview.Name = "bookCurrentLoansOverview";
            this.bookCurrentLoansOverview.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bookCurrentLoansOverview.Size = new System.Drawing.Size(233, 40);
            this.bookCurrentLoansOverview.TabIndex = 2;
            this.bookCurrentLoansOverview.Text = "       Current Loans Overview";
            this.bookCurrentLoansOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookCurrentLoansOverview.UseVisualStyleBackColor = true;
            this.bookCurrentLoansOverview.Click += new System.EventHandler(this.bookCurrentLoansOverview_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(0, 40);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReturnBook.Size = new System.Drawing.Size(233, 40);
            this.btnReturnBook.TabIndex = 1;
            this.btnReturnBook.Text = "       Return Book";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnIssueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Location = new System.Drawing.Point(0, 0);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIssueBook.Size = new System.Drawing.Size(233, 40);
            this.btnIssueBook.TabIndex = 0;
            this.btnIssueBook.Text = "       Issue Book";
            this.btnIssueBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnBorrowingAndReturning
            // 
            this.btnBorrowingAndReturning.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowingAndReturning.FlatAppearance.BorderSize = 0;
            this.btnBorrowingAndReturning.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnBorrowingAndReturning.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBorrowingAndReturning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowingAndReturning.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowingAndReturning.ForeColor = System.Drawing.Color.White;
            this.btnBorrowingAndReturning.Image = global::practiceLibraryManagementSystem.Properties.Resources.profile;
            this.btnBorrowingAndReturning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowingAndReturning.Location = new System.Drawing.Point(0, 470);
            this.btnBorrowingAndReturning.Name = "btnBorrowingAndReturning";
            this.btnBorrowingAndReturning.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBorrowingAndReturning.Size = new System.Drawing.Size(233, 45);
            this.btnBorrowingAndReturning.TabIndex = 6;
            this.btnBorrowingAndReturning.Text = "        Borrowing and Returning";
            this.btnBorrowingAndReturning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowingAndReturning.UseVisualStyleBackColor = true;
            this.btnBorrowingAndReturning.Click += new System.EventHandler(this.btnBorrowingAndReturning_Click);
            // 
            // pnlMemberManagementSubMenu
            // 
            this.pnlMemberManagementSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlMemberManagementSubMenu.Controls.Add(this.btnSearchMember);
            this.pnlMemberManagementSubMenu.Controls.Add(this.btnAddEditMember);
            this.pnlMemberManagementSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMemberManagementSubMenu.Location = new System.Drawing.Point(0, 385);
            this.pnlMemberManagementSubMenu.Name = "pnlMemberManagementSubMenu";
            this.pnlMemberManagementSubMenu.Size = new System.Drawing.Size(233, 85);
            this.pnlMemberManagementSubMenu.TabIndex = 5;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchMember.FlatAppearance.BorderSize = 0;
            this.btnSearchMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSearchMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchMember.ForeColor = System.Drawing.Color.White;
            this.btnSearchMember.Location = new System.Drawing.Point(0, 40);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchMember.Size = new System.Drawing.Size(233, 40);
            this.btnSearchMember.TabIndex = 1;
            this.btnSearchMember.Text = "       Search Members";
            this.btnSearchMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnAddEditMember
            // 
            this.btnAddEditMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEditMember.FlatAppearance.BorderSize = 0;
            this.btnAddEditMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddEditMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditMember.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddEditMember.ForeColor = System.Drawing.Color.White;
            this.btnAddEditMember.Location = new System.Drawing.Point(0, 0);
            this.btnAddEditMember.Name = "btnAddEditMember";
            this.btnAddEditMember.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddEditMember.Size = new System.Drawing.Size(233, 40);
            this.btnAddEditMember.TabIndex = 0;
            this.btnAddEditMember.Text = "       Add / Edit Member";
            this.btnAddEditMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEditMember.UseVisualStyleBackColor = true;
            this.btnAddEditMember.Click += new System.EventHandler(this.btnAddEditMember_Click);
            // 
            // btnMemberManagement
            // 
            this.btnMemberManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberManagement.FlatAppearance.BorderSize = 0;
            this.btnMemberManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnMemberManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnMemberManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberManagement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberManagement.ForeColor = System.Drawing.Color.White;
            this.btnMemberManagement.Image = global::practiceLibraryManagementSystem.Properties.Resources.profile;
            this.btnMemberManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberManagement.Location = new System.Drawing.Point(0, 340);
            this.btnMemberManagement.Name = "btnMemberManagement";
            this.btnMemberManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMemberManagement.Size = new System.Drawing.Size(233, 45);
            this.btnMemberManagement.TabIndex = 4;
            this.btnMemberManagement.Text = "       Member Management";
            this.btnMemberManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberManagement.UseVisualStyleBackColor = true;
            this.btnMemberManagement.Click += new System.EventHandler(this.btnMemberManagement_Click);
            // 
            // pnlBookManagementSubMenu
            // 
            this.pnlBookManagementSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlBookManagementSubMenu.Controls.Add(this.btnInventoryTracking);
            this.pnlBookManagementSubMenu.Controls.Add(this.btnSearchBook);
            this.pnlBookManagementSubMenu.Controls.Add(this.btnAddEditBook);
            this.pnlBookManagementSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBookManagementSubMenu.Location = new System.Drawing.Point(0, 215);
            this.pnlBookManagementSubMenu.Name = "pnlBookManagementSubMenu";
            this.pnlBookManagementSubMenu.Size = new System.Drawing.Size(233, 125);
            this.pnlBookManagementSubMenu.TabIndex = 3;
            // 
            // btnInventoryTracking
            // 
            this.btnInventoryTracking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryTracking.FlatAppearance.BorderSize = 0;
            this.btnInventoryTracking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnInventoryTracking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnInventoryTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryTracking.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnInventoryTracking.ForeColor = System.Drawing.Color.White;
            this.btnInventoryTracking.Location = new System.Drawing.Point(0, 80);
            this.btnInventoryTracking.Name = "btnInventoryTracking";
            this.btnInventoryTracking.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInventoryTracking.Size = new System.Drawing.Size(233, 40);
            this.btnInventoryTracking.TabIndex = 2;
            this.btnInventoryTracking.Text = "       Inventory Tracking";
            this.btnInventoryTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryTracking.UseVisualStyleBackColor = true;
            this.btnInventoryTracking.Click += new System.EventHandler(this.btnInventoryTracking_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSearchBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(0, 40);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchBook.Size = new System.Drawing.Size(233, 40);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.Text = "       Search Books";
            this.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnAddEditBook
            // 
            this.btnAddEditBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEditBook.FlatAppearance.BorderSize = 0;
            this.btnAddEditBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddEditBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditBook.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddEditBook.ForeColor = System.Drawing.Color.White;
            this.btnAddEditBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddEditBook.Name = "btnAddEditBook";
            this.btnAddEditBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddEditBook.Size = new System.Drawing.Size(233, 40);
            this.btnAddEditBook.TabIndex = 0;
            this.btnAddEditBook.Text = "       Add / Edit Book";
            this.btnAddEditBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEditBook.UseVisualStyleBackColor = true;
            this.btnAddEditBook.Click += new System.EventHandler(this.btnAddEditBook_Click);
            // 
            // btnBookManagement
            // 
            this.btnBookManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookManagement.FlatAppearance.BorderSize = 0;
            this.btnBookManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnBookManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBookManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookManagement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookManagement.ForeColor = System.Drawing.Color.White;
            this.btnBookManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnBookManagement.Image")));
            this.btnBookManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManagement.Location = new System.Drawing.Point(0, 170);
            this.btnBookManagement.Name = "btnBookManagement";
            this.btnBookManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBookManagement.Size = new System.Drawing.Size(233, 45);
            this.btnBookManagement.TabIndex = 2;
            this.btnBookManagement.Text = "       Book Management";
            this.btnBookManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManagement.UseVisualStyleBackColor = true;
            this.btnBookManagement.Click += new System.EventHandler(this.btnBookManagement_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::practiceLibraryManagementSystem.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 125);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(233, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "       Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(233, 125);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::practiceLibraryManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(250, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(684, 561);
            this.pnlContainer.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlReportingAndAnalyticsSubMenu.ResumeLayout(false);
            this.pnlBorrowingAndReturningSubMenu.ResumeLayout(false);
            this.pnlMemberManagementSubMenu.ResumeLayout(false);
            this.pnlBookManagementSubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBookManagement;
        private System.Windows.Forms.Panel pnlBookManagementSubMenu;
        private System.Windows.Forms.Button btnAddEditBook;
        private System.Windows.Forms.Button btnInventoryTracking;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnMemberManagement;
        private System.Windows.Forms.Panel pnlBorrowingAndReturningSubMenu;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnBorrowingAndReturning;
        private System.Windows.Forms.Panel pnlMemberManagementSubMenu;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnAddEditMember;
        private System.Windows.Forms.Panel pnlReportingAndAnalyticsSubMenu;
        private System.Windows.Forms.Button btnOverdueItemsReport;
        private System.Windows.Forms.Button btnMemberActivityReports;
        private System.Windows.Forms.Button btnCirculationReports;
        private System.Windows.Forms.Button btnReportingAndAnalytics;
        private System.Windows.Forms.Button bookCurrentLoansOverview;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlContainer;
    }
}