using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AshfordDVDLibraryCL
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            tabControl1.Selected += new TabControlEventHandler(tabControl1_Selected);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadMemberID();
            refreshTable();

            cboTypeOfMember.Items.Add("Adult");
            cboTypeOfMember.Items.Add("Child");
            cboTypeOfMember.Items.Add("Senior");
            cboTypeOfMember.SelectedItem = "Adult";
        }



//Quit Button
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//Tab Control
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            lblProgress.Text = "Progress...";
            refreshTable();
        }
//Refresh Table
        public void refreshTable()
        {
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            DataTable dt = new DataTable();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        String myQuery = "SELECT * FROM DVD ORDER BY DVDID ASC";
                        OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                        OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
                        da.Fill(dt);
                        dgvLibraryTable.DataSource = dt;
                        loadDVDID();
                    }
                    break;
                case 1:
                    {
                        String myQuery = "SELECT * FROM  Loan ORDER BY LoanID ASC";
                        OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                        OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
                        da.Fill(dt);
                        dgvLibraryTable.DataSource = dt;
                        txtIssue.Text = (DateTime.Now.ToString("d"));
                        txtDue.Text = (DateTime.Now.AddDays(3).ToString("d"));
                        loadDVDID();
                    }
                    break;
                case 2:
                    {
                        String myQuery = "SELECT * FROM  Loan ORDER BY LoanID ASC";
                        OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                        OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
                        da.Fill(dt);
                        dgvLibraryTable.DataSource = dt;
                        loadLoanID();
                    }
                    break;
                case 3:
                    {
                        String myQuery = "SELECT * FROM Member ORDER BY MembershipID ASC";
                        OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                        OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
                        da.Fill(dt);
                        dgvLibraryTable.DataSource = dt;
                    }
                    break;

            }
        }
//Register Member Button
        private void btnRegister_Click(object sender, EventArgs e)
        {
                try
                {
                    String TypeOfMemberStr = cboTypeOfMember.SelectedItem.ToString();
                    Member.registerMember(txtTitle.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCounty.Text, txtPostCode.Text, txtTelephone.Text, TypeOfMemberStr);
                    lblProgress.Text = "Member Added...";
                    refreshTable();
                    loadMemberID();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
           
            String cboSelectedItem = cboMemberID.SelectedValue.ToString();
            Member.deleteMember(cboSelectedItem);

            loadMemberID();
            refreshTable();
            lblProgress.Text = "Member Removed...";
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            String cboSelectedItem = cboMemberID.SelectedValue.ToString();
            String TypeOfMemberStr = cboTypeOfMember.SelectedItem.ToString();
            Member.updateMember(cboSelectedItem, txtTitle.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCounty.Text, txtPostCode.Text, txtTelephone.Text, TypeOfMemberStr);

            loadMemberID();
            refreshTable();
            lblProgress.Text = "Member Updated...";
        }

        private void btnCheckFilm_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                string checkStr = cboCheckDVDID.SelectedValue.ToString();

                OleDbConnection myConnection = DBConnectivity.GetConnection();
                DataTable dt = new DataTable();
                String myQuery = "SELECT * FROM DVD WHERE DVDID=" + checkStr + "";                
                        OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);             
                        OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
                        da.Fill(dt);
                        dgvLibraryTable.DataSource = dt;
                lblProgress.Text = "Table Updated...";
                fillFilmTitle(checkStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void fillFilmTitle(string cS) {
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            DataTable dt = new DataTable();
            String myQuery = "SELECT DVDTitle FROM DVD WHERE DVDID=" + cS + "";
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            try
            {
                
                string DVDIDStr = cboLoanDVDID.SelectedValue.ToString();
                string memberIDStr = cboLoanMemberID.SelectedValue.ToString();
                String issueStr = (DateTime.Now.ToString("d"));
                String dueStr = (DateTime.Now.AddDays(3).ToString("d"));
                Loan.registerLoan(memberIDStr, DVDIDStr, issueStr, dueStr);
                lblProgress.Text = "Loan Added...";
                stock();
                refreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                String loanIDStr = cboReturnLoanID.Text;
                stock();
                Loan.returnLoan(loanIDStr);
                
                lblProgress.Text = "Loan Removed...";
                refreshTable();
                loadLoanID();
                loadMemberID();

            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
        }

        private void btnLoanCheck_Click(object sender, EventArgs e)
        {
            try
            {

                string checkStr = cboLoanCheckMemberID.SelectedValue.ToString();

                OleDbConnection myConnection = DBConnectivity.GetConnection();
                DataTable dt = new DataTable();
                String myQuery = "SELECT * FROM Loan WHERE MemberID=" + checkStr + "";
                        OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                        OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
                        da.Fill(dt);
                        dgvLibraryTable.DataSource = dt;
                lblProgress.Text = "Table Updated...";
                fillFilmTitle(checkStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCheckReset_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btnLoanReset_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btnReturnReset_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btnReturnCheck_Click(object sender, EventArgs e)
        {
            string checkStr = cboReturnCheckMemberID.SelectedValue.ToString();

            OleDbConnection myConnection = DBConnectivity.GetConnection();
            DataTable dt = new DataTable();
            String myQuery = "SELECT * FROM Loan WHERE MemberID=" + checkStr + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            da.Fill(dt);
            dgvLibraryTable.DataSource = dt;
            lblProgress.Text = "Table Updated...";
            fillFilmTitle(checkStr);
        }

        private void cboCheckDVDID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cboSelectedItem = cboCheckDVDID.Text;
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            String myQuery = "SELECT DVDTitle FROM DVD WHERE DVDID="+cboSelectedItem+"";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    txtFilmTitle.Text = reader["DVDTitle"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                myConnection.Close();
            }
        }

        private void cboLoanDVDID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cboSelectedItem = cboLoanDVDID.Text;
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            String myQuery = "SELECT DVDTitle FROM DVD WHERE DVDID=" + cboSelectedItem + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    txtLoanFilmTitle.Text = reader["DVDTitle"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void cboLoanMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cboSelectedItem = cboLoanMemberID.Text;
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            String myQuery = "SELECT FirstName FROM Member WHERE MembershipID=" + cboSelectedItem + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                { 
                    txtLoanName.Text = reader["FirstName"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void cboLoanCheckMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cboSelectedItem = cboLoanCheckMemberID.Text;
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            String myQuery = "SELECT FirstName FROM Member WHERE MembershipID=" + cboSelectedItem + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    txtLoanCheckMember.Text = reader["FirstName"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void cboReturnCheckMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cboSelectedItem = cboReturnCheckMemberID.Text;
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            String myQuery = "SELECT FirstName FROM Member WHERE MembershipID=" + cboSelectedItem + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    txtReturnMemberID.Text = reader["FirstName"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }
//Aquire information to edit the Stock field in the database
        public void stock(){
            String DVDminus = cboLoanDVDID.Text;
            String DVDadd = cboReturnLoanID.Text;
            if (tabControl1.SelectedIndex == 1){
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "SELECT DVDID FROM DVD WHERE DVDID=" + DVDminus + "";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                int DVDID;
                String DVDIDStr;
                try
                {
                    myConnection.Open();
                    OleDbDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read())
                        {
                            DVDID = Int32.Parse(reader["DVDID"].ToString());
                            DVDIDStr = DVDID.ToString();
                            Loan.stockMinus(DVDminus);
                        }
                        reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    myConnection.Close();
                }
            }
            if (tabControl1.SelectedIndex == 2) {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "SELECT DVDID FROM Loan WHERE LoanID=" + DVDadd + "";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                String DVDIDStr;
                try
                {
                    myConnection.Open();
                    OleDbDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        DVDIDStr = reader["DVDID"].ToString();
                        Loan.stockAdd(DVDIDStr);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    myConnection.Close();
                }
                
            }

            refreshTable();
        }
//Load Data into Combo Boxes
        public void loadMemberID()
        {
            try
            {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "SELECT MembershipID FROM Member ORDER BY MembershipID ASC";
                OleDbDataAdapter dAdapter = new OleDbDataAdapter(myQuery, myConnection);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);

                
                cboMemberID.DataSource = ds.Tables[0];
                cboMemberID.ValueMember = "MembershipID";
                cboLoanMemberID.DataSource = ds.Tables[0];
                cboLoanMemberID.ValueMember = "MembershipID";
                cboLoanCheckMemberID.DataSource = ds.Tables[0];
                cboLoanCheckMemberID.ValueMember = "MembershipID";
                cboReturnCheckMemberID.DataSource = ds.Tables[0];
                cboReturnCheckMemberID.ValueMember = "MembershipID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void loadDVDID()
        { 
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            switch (tabControl1.SelectedIndex)
            {
                case 0: case 2:
                    {
                        try
                        {
                            String myQuery = "SELECT DVDID FROM DVD ORDER BY DVDID ASC";
                            OleDbDataAdapter dAdapter = new OleDbDataAdapter(myQuery, myConnection);
                            DataSet ds = new DataSet();
                            dAdapter.Fill(ds);

                            cboCheckDVDID.DataSource = ds.Tables[0];
                            cboCheckDVDID.ValueMember = "DVDID";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                     }
                    break;
                case 1:
                    {
                        try
                        {
                            String myQuery = "SELECT DVDID FROM DVD WHERE Stock > 0 ORDER BY DVDID ASC";
                            OleDbDataAdapter dAdapter = new OleDbDataAdapter(myQuery, myConnection);
                            DataSet ds = new DataSet();
                            dAdapter.Fill(ds);
                            cboLoanDVDID.DataSource = ds.Tables[0];
                            cboLoanDVDID.ValueMember = "DVDID";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    break;
                    }
               }
        }

        public void loadLoanID()
        {
            try
            {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "SELECT LoanID FROM Loan ORDER BY LoanID ASC";
                OleDbDataAdapter dA = new OleDbDataAdapter(myQuery, myConnection);
                DataSet ds = new DataSet();
                dA.Fill(ds);

                cboReturnLoanID.DataSource = ds.Tables[0];
                cboReturnLoanID.ValueMember = "LoanID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLoanReport_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            
            OleDbDataAdapter da = AvailableDVD.checkInStock();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLibraryTable.DataSource = dt;
        }

    }

}
