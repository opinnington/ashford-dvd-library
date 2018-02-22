namespace AshfordDVDLibraryCL
{
    partial class Form1
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
            this.dgvLibraryTable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCheckFilms = new System.Windows.Forms.TabPage();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnCheckReset = new System.Windows.Forms.Button();
            this.cboCheckDVDID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckFilm = new System.Windows.Forms.Button();
            this.txtFilmTitle = new System.Windows.Forms.TextBox();
            this.tabLoan = new System.Windows.Forms.TabPage();
            this.btnLoanReset = new System.Windows.Forms.Button();
            this.btnLoanCheck = new System.Windows.Forms.Button();
            this.txtLoanCheckMember = new System.Windows.Forms.TextBox();
            this.cboLoanCheckMemberID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoanFilmTitle = new System.Windows.Forms.TextBox();
            this.cboLoanDVDID = new System.Windows.Forms.ComboBox();
            this.txtLoanName = new System.Windows.Forms.TextBox();
            this.btnLoan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.cboLoanMemberID = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.tabReturn = new System.Windows.Forms.TabPage();
            this.btnReturnReset = new System.Windows.Forms.Button();
            this.btnReturnCheck = new System.Windows.Forms.Button();
            this.txtReturnMemberID = new System.Windows.Forms.TextBox();
            this.cboReturnCheckMemberID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboReturnLoanID = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.cboMemberID = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cboTypeOfMember = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnLoanReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCheckFilms.SuspendLayout();
            this.tabLoan.SuspendLayout();
            this.tabReturn.SuspendLayout();
            this.tabMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibraryTable
            // 
            this.dgvLibraryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibraryTable.Location = new System.Drawing.Point(377, 70);
            this.dgvLibraryTable.Name = "dgvLibraryTable";
            this.dgvLibraryTable.ReadOnly = true;
            this.dgvLibraryTable.Size = new System.Drawing.Size(526, 322);
            this.dgvLibraryTable.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCheckFilms);
            this.tabControl1.Controls.Add(this.tabLoan);
            this.tabControl1.Controls.Add(this.tabReturn);
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Location = new System.Drawing.Point(21, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 331);
            this.tabControl1.TabIndex = 3;
            // 
            // tabCheckFilms
            // 
            this.tabCheckFilms.Controls.Add(this.btnAvailable);
            this.tabCheckFilms.Controls.Add(this.btnCheckReset);
            this.tabCheckFilms.Controls.Add(this.cboCheckDVDID);
            this.tabCheckFilms.Controls.Add(this.label1);
            this.tabCheckFilms.Controls.Add(this.label3);
            this.tabCheckFilms.Controls.Add(this.btnCheckFilm);
            this.tabCheckFilms.Controls.Add(this.txtFilmTitle);
            this.tabCheckFilms.Location = new System.Drawing.Point(4, 22);
            this.tabCheckFilms.Name = "tabCheckFilms";
            this.tabCheckFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckFilms.Size = new System.Drawing.Size(342, 305);
            this.tabCheckFilms.TabIndex = 0;
            this.tabCheckFilms.Text = "Check Films";
            this.tabCheckFilms.UseVisualStyleBackColor = true;
            // 
            // btnAvailable
            // 
            this.btnAvailable.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailable.Location = new System.Drawing.Point(10, 276);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(129, 23);
            this.btnAvailable.TabIndex = 9;
            this.btnAvailable.Text = "Show Available Only";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnCheckReset
            // 
            this.btnCheckReset.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckReset.Location = new System.Drawing.Point(260, 276);
            this.btnCheckReset.Name = "btnCheckReset";
            this.btnCheckReset.Size = new System.Drawing.Size(75, 23);
            this.btnCheckReset.TabIndex = 8;
            this.btnCheckReset.Text = "Reset";
            this.btnCheckReset.UseVisualStyleBackColor = true;
            this.btnCheckReset.Click += new System.EventHandler(this.btnCheckReset_Click);
            // 
            // cboCheckDVDID
            // 
            this.cboCheckDVDID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheckDVDID.FormattingEnabled = true;
            this.cboCheckDVDID.Location = new System.Drawing.Point(58, 63);
            this.cboCheckDVDID.Name = "cboCheckDVDID";
            this.cboCheckDVDID.Size = new System.Drawing.Size(121, 21);
            this.cboCheckDVDID.TabIndex = 0;
            this.cboCheckDVDID.SelectedIndexChanged += new System.EventHandler(this.cboCheckDVDID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DVDID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Film:";
            // 
            // btnCheckFilm
            // 
            this.btnCheckFilm.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckFilm.Location = new System.Drawing.Point(10, 116);
            this.btnCheckFilm.Name = "btnCheckFilm";
            this.btnCheckFilm.Size = new System.Drawing.Size(75, 23);
            this.btnCheckFilm.TabIndex = 5;
            this.btnCheckFilm.Text = "Check";
            this.btnCheckFilm.UseVisualStyleBackColor = true;
            this.btnCheckFilm.Click += new System.EventHandler(this.btnCheckFilm_Click);
            // 
            // txtFilmTitle
            // 
            this.txtFilmTitle.Enabled = false;
            this.txtFilmTitle.Location = new System.Drawing.Point(58, 90);
            this.txtFilmTitle.Name = "txtFilmTitle";
            this.txtFilmTitle.Size = new System.Drawing.Size(235, 20);
            this.txtFilmTitle.TabIndex = 2;
            this.txtFilmTitle.TabStop = false;
            // 
            // tabLoan
            // 
            this.tabLoan.Controls.Add(this.btnLoanReset);
            this.tabLoan.Controls.Add(this.btnLoanCheck);
            this.tabLoan.Controls.Add(this.txtLoanCheckMember);
            this.tabLoan.Controls.Add(this.cboLoanCheckMemberID);
            this.tabLoan.Controls.Add(this.label7);
            this.tabLoan.Controls.Add(this.label5);
            this.tabLoan.Controls.Add(this.txtLoanFilmTitle);
            this.tabLoan.Controls.Add(this.cboLoanDVDID);
            this.tabLoan.Controls.Add(this.txtLoanName);
            this.tabLoan.Controls.Add(this.btnLoan);
            this.tabLoan.Controls.Add(this.label10);
            this.tabLoan.Controls.Add(this.label9);
            this.tabLoan.Controls.Add(this.txtDue);
            this.tabLoan.Controls.Add(this.cboLoanMemberID);
            this.tabLoan.Controls.Add(this.lblMember);
            this.tabLoan.Controls.Add(this.txtIssue);
            this.tabLoan.Location = new System.Drawing.Point(4, 22);
            this.tabLoan.Name = "tabLoan";
            this.tabLoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoan.Size = new System.Drawing.Size(342, 305);
            this.tabLoan.TabIndex = 1;
            this.tabLoan.Text = "Loan";
            this.tabLoan.UseVisualStyleBackColor = true;
            // 
            // btnLoanReset
            // 
            this.btnLoanReset.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanReset.Location = new System.Drawing.Point(261, 276);
            this.btnLoanReset.Name = "btnLoanReset";
            this.btnLoanReset.Size = new System.Drawing.Size(75, 23);
            this.btnLoanReset.TabIndex = 32;
            this.btnLoanReset.Text = "Reset";
            this.btnLoanReset.UseVisualStyleBackColor = true;
            this.btnLoanReset.Click += new System.EventHandler(this.btnLoanReset_Click);
            // 
            // btnLoanCheck
            // 
            this.btnLoanCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLoanCheck.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanCheck.Location = new System.Drawing.Point(66, 211);
            this.btnLoanCheck.Name = "btnLoanCheck";
            this.btnLoanCheck.Size = new System.Drawing.Size(75, 23);
            this.btnLoanCheck.TabIndex = 31;
            this.btnLoanCheck.Text = "Check Member";
            this.btnLoanCheck.UseVisualStyleBackColor = true;
            this.btnLoanCheck.Click += new System.EventHandler(this.btnLoanCheck_Click);
            // 
            // txtLoanCheckMember
            // 
            this.txtLoanCheckMember.Enabled = false;
            this.txtLoanCheckMember.Location = new System.Drawing.Point(193, 183);
            this.txtLoanCheckMember.Name = "txtLoanCheckMember";
            this.txtLoanCheckMember.Size = new System.Drawing.Size(108, 20);
            this.txtLoanCheckMember.TabIndex = 30;
            this.txtLoanCheckMember.TabStop = false;
            // 
            // cboLoanCheckMemberID
            // 
            this.cboLoanCheckMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanCheckMemberID.FormattingEnabled = true;
            this.cboLoanCheckMemberID.Location = new System.Drawing.Point(66, 183);
            this.cboLoanCheckMemberID.Name = "cboLoanCheckMemberID";
            this.cboLoanCheckMemberID.Size = new System.Drawing.Size(121, 21);
            this.cboLoanCheckMemberID.TabIndex = 28;
            this.cboLoanCheckMemberID.SelectedIndexChanged += new System.EventHandler(this.cboLoanCheckMemberID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Member ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "DVDID:";
            // 
            // txtLoanFilmTitle
            // 
            this.txtLoanFilmTitle.Enabled = false;
            this.txtLoanFilmTitle.Location = new System.Drawing.Point(194, 17);
            this.txtLoanFilmTitle.Name = "txtLoanFilmTitle";
            this.txtLoanFilmTitle.Size = new System.Drawing.Size(107, 20);
            this.txtLoanFilmTitle.TabIndex = 26;
            this.txtLoanFilmTitle.TabStop = false;
            // 
            // cboLoanDVDID
            // 
            this.cboLoanDVDID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanDVDID.FormattingEnabled = true;
            this.cboLoanDVDID.Location = new System.Drawing.Point(66, 17);
            this.cboLoanDVDID.Name = "cboLoanDVDID";
            this.cboLoanDVDID.Size = new System.Drawing.Size(121, 21);
            this.cboLoanDVDID.TabIndex = 0;
            this.cboLoanDVDID.SelectedIndexChanged += new System.EventHandler(this.cboLoanDVDID_SelectedIndexChanged);
            // 
            // txtLoanName
            // 
            this.txtLoanName.Enabled = false;
            this.txtLoanName.Location = new System.Drawing.Point(193, 44);
            this.txtLoanName.Name = "txtLoanName";
            this.txtLoanName.Size = new System.Drawing.Size(108, 20);
            this.txtLoanName.TabIndex = 24;
            this.txtLoanName.TabStop = false;
            // 
            // btnLoan
            // 
            this.btnLoan.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.Location = new System.Drawing.Point(66, 124);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(75, 23);
            this.btnLoan.TabIndex = 4;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Due: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Issue: ";
            // 
            // txtDue
            // 
            this.txtDue.Enabled = false;
            this.txtDue.Location = new System.Drawing.Point(66, 98);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(235, 20);
            this.txtDue.TabIndex = 3;
            // 
            // cboLoanMemberID
            // 
            this.cboLoanMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanMemberID.FormattingEnabled = true;
            this.cboLoanMemberID.Location = new System.Drawing.Point(66, 44);
            this.cboLoanMemberID.Name = "cboLoanMemberID";
            this.cboLoanMemberID.Size = new System.Drawing.Size(121, 21);
            this.cboLoanMemberID.TabIndex = 1;
            this.cboLoanMemberID.SelectedIndexChanged += new System.EventHandler(this.cboLoanMemberID_SelectedIndexChanged);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(2, 47);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(62, 13);
            this.lblMember.TabIndex = 18;
            this.lblMember.Text = "Member ID:";
            // 
            // txtIssue
            // 
            this.txtIssue.Enabled = false;
            this.txtIssue.Location = new System.Drawing.Point(66, 71);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(235, 20);
            this.txtIssue.TabIndex = 2;
            // 
            // tabReturn
            // 
            this.tabReturn.Controls.Add(this.btnReturnReset);
            this.tabReturn.Controls.Add(this.btnReturnCheck);
            this.tabReturn.Controls.Add(this.txtReturnMemberID);
            this.tabReturn.Controls.Add(this.cboReturnCheckMemberID);
            this.tabReturn.Controls.Add(this.label8);
            this.tabReturn.Controls.Add(this.label6);
            this.tabReturn.Controls.Add(this.cboReturnLoanID);
            this.tabReturn.Controls.Add(this.btnReturn);
            this.tabReturn.Location = new System.Drawing.Point(4, 22);
            this.tabReturn.Name = "tabReturn";
            this.tabReturn.Size = new System.Drawing.Size(342, 305);
            this.tabReturn.TabIndex = 2;
            this.tabReturn.Text = "Return";
            this.tabReturn.UseVisualStyleBackColor = true;
            // 
            // btnReturnReset
            // 
            this.btnReturnReset.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnReset.Location = new System.Drawing.Point(264, 279);
            this.btnReturnReset.Name = "btnReturnReset";
            this.btnReturnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReturnReset.TabIndex = 43;
            this.btnReturnReset.Text = "Reset";
            this.btnReturnReset.UseVisualStyleBackColor = true;
            this.btnReturnReset.Click += new System.EventHandler(this.btnReturnReset_Click);
            // 
            // btnReturnCheck
            // 
            this.btnReturnCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReturnCheck.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnCheck.Location = new System.Drawing.Point(66, 101);
            this.btnReturnCheck.Name = "btnReturnCheck";
            this.btnReturnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnReturnCheck.TabIndex = 42;
            this.btnReturnCheck.Text = "Check Member";
            this.btnReturnCheck.UseVisualStyleBackColor = true;
            this.btnReturnCheck.Click += new System.EventHandler(this.btnReturnCheck_Click);
            // 
            // txtReturnMemberID
            // 
            this.txtReturnMemberID.Enabled = false;
            this.txtReturnMemberID.Location = new System.Drawing.Point(193, 73);
            this.txtReturnMemberID.Name = "txtReturnMemberID";
            this.txtReturnMemberID.Size = new System.Drawing.Size(108, 20);
            this.txtReturnMemberID.TabIndex = 41;
            this.txtReturnMemberID.TabStop = false;
            // 
            // cboReturnCheckMemberID
            // 
            this.cboReturnCheckMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReturnCheckMemberID.FormattingEnabled = true;
            this.cboReturnCheckMemberID.Location = new System.Drawing.Point(66, 73);
            this.cboReturnCheckMemberID.Name = "cboReturnCheckMemberID";
            this.cboReturnCheckMemberID.Size = new System.Drawing.Size(121, 21);
            this.cboReturnCheckMemberID.TabIndex = 39;
            this.cboReturnCheckMemberID.SelectedIndexChanged += new System.EventHandler(this.cboReturnCheckMemberID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Member ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "LoanID:";
            // 
            // cboReturnLoanID
            // 
            this.cboReturnLoanID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReturnLoanID.FormattingEnabled = true;
            this.cboReturnLoanID.Location = new System.Drawing.Point(66, 17);
            this.cboReturnLoanID.Name = "cboReturnLoanID";
            this.cboReturnLoanID.Size = new System.Drawing.Size(121, 21);
            this.cboReturnLoanID.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(66, 44);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.btnUpdateMember);
            this.tabMembers.Controls.Add(this.btnRemoveMember);
            this.tabMembers.Controls.Add(this.label25);
            this.tabMembers.Controls.Add(this.cboMemberID);
            this.tabMembers.Controls.Add(this.label24);
            this.tabMembers.Controls.Add(this.label23);
            this.tabMembers.Controls.Add(this.txtPostCode);
            this.tabMembers.Controls.Add(this.txtCounty);
            this.tabMembers.Controls.Add(this.txtLastName);
            this.tabMembers.Controls.Add(this.label22);
            this.tabMembers.Controls.Add(this.btnRegister);
            this.tabMembers.Controls.Add(this.cboTypeOfMember);
            this.tabMembers.Controls.Add(this.txtTitle);
            this.tabMembers.Controls.Add(this.txtFirstName);
            this.tabMembers.Controls.Add(this.txtAddress);
            this.tabMembers.Controls.Add(this.txtTelephone);
            this.tabMembers.Controls.Add(this.label21);
            this.tabMembers.Controls.Add(this.label20);
            this.tabMembers.Controls.Add(this.label19);
            this.tabMembers.Controls.Add(this.label18);
            this.tabMembers.Controls.Add(this.label17);
            this.tabMembers.Location = new System.Drawing.Point(4, 22);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Size = new System.Drawing.Size(342, 305);
            this.tabMembers.TabIndex = 3;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.Location = new System.Drawing.Point(96, 275);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMember.TabIndex = 11;
            this.btnUpdateMember.Text = "Update";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMember.Location = new System.Drawing.Point(177, 275);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMember.TabIndex = 12;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 251);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 19;
            this.label25.Text = "Member ID:";
            // 
            // cboMemberID
            // 
            this.cboMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberID.FormattingEnabled = true;
            this.cboMemberID.Location = new System.Drawing.Point(96, 248);
            this.cboMemberID.Name = "cboMemberID";
            this.cboMemberID.Size = new System.Drawing.Size(121, 21);
            this.cboMemberID.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(2, 148);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Post Code:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 121);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "County:";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(96, 145);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(205, 20);
            this.txtPostCode.TabIndex = 6;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(96, 118);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(205, 20);
            this.txtCounty.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(96, 61);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(205, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Last Name:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(96, 219);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cboTypeOfMember
            // 
            this.cboTypeOfMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeOfMember.FormattingEnabled = true;
            this.cboTypeOfMember.Location = new System.Drawing.Point(96, 195);
            this.cboTypeOfMember.Name = "cboTypeOfMember";
            this.cboTypeOfMember.Size = new System.Drawing.Size(121, 21);
            this.cboTypeOfMember.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(96, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(96, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(205, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(96, 169);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(205, 20);
            this.txtTelephone.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 195);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Type of Member:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Telephone:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Address:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "First Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Title:";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(828, 22);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 100;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ashford DVD Library";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(568, 395);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(115, 23);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "Progress...";
            // 
            // btnLoanReport
            // 
            this.btnLoanReport.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanReport.Location = new System.Drawing.Point(700, 22);
            this.btnLoanReport.Name = "btnLoanReport";
            this.btnLoanReport.Size = new System.Drawing.Size(75, 23);
            this.btnLoanReport.TabIndex = 99;
            this.btnLoanReport.Text = "Loan Report";
            this.btnLoanReport.UseVisualStyleBackColor = true;
            this.btnLoanReport.Click += new System.EventHandler(this.btnLoanReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 426);
            this.Controls.Add(this.btnLoanReport);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvLibraryTable);
            this.Name = "Form1";
            this.Text = "Ashford DVD Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCheckFilms.ResumeLayout(false);
            this.tabCheckFilms.PerformLayout();
            this.tabLoan.ResumeLayout(false);
            this.tabLoan.PerformLayout();
            this.tabReturn.ResumeLayout(false);
            this.tabReturn.PerformLayout();
            this.tabMembers.ResumeLayout(false);
            this.tabMembers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibraryTable;
        private System.Windows.Forms.TabPage tabCheckFilms;
        private System.Windows.Forms.TabPage tabLoan;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabReturn;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnCheckFilm;
        private System.Windows.Forms.TextBox txtFilmTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.ComboBox cboLoanMemberID;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLoanReport;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cboTypeOfMember;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtCounty;
        public System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.ComboBox cboMemberID;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtLoanName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoanDVDID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboReturnLoanID;
        private System.Windows.Forms.Button btnReturn;
        public System.Windows.Forms.TextBox txtLoanFilmTitle;
        private System.Windows.Forms.Button btnLoanCheck;
        private System.Windows.Forms.TextBox txtLoanCheckMember;
        private System.Windows.Forms.ComboBox cboLoanCheckMemberID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReturnCheck;
        private System.Windows.Forms.TextBox txtReturnMemberID;
        private System.Windows.Forms.ComboBox cboReturnCheckMemberID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCheckDVDID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckReset;
        private System.Windows.Forms.Button btnLoanReset;
        private System.Windows.Forms.Button btnReturnReset;
        private System.Windows.Forms.Button btnAvailable;
    }
}

