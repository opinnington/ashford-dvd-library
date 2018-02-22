using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace AshfordDVDLibraryCL
{
    class Loan
    {

        public static void registerLoan(String mI, String dI, String i, String d)
        {
            try
            {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "INSERT INTO Loan (DVDID, MemberID, StartDate, ReturnDate) VALUES (@dI, @mI, @i, @d)";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.Add("@dI", OleDbType.VarChar).Value = dI;
                myCommand.Parameters.Add("@mI", OleDbType.VarChar).Value = mI;
                myCommand.Parameters.Add("@i", OleDbType.VarChar).Value = i;
                myCommand.Parameters.Add("@d", OleDbType.VarChar).Value = d;
                

                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in DBHandler", ex);
                }
                finally
                {
                    myConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database", ex.ToString());
            }

        }
        public static void returnLoan(String lI)
        {
            try
            {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "DELETE FROM Loan WHERE [LoanID] =" + lI + "";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in DBHandler", ex);
                }
                finally
                {
                    myConnection.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void stockMinus(String m) {
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            String myQuery = "UPDATE DVD SET Stock = Stock - 1 WHERE DVDID=" + m + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
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

        public static void stockAdd(String a) {
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            String myQuery = "UPDATE DVD SET Stock = Stock + 1 WHERE DVDID=" + a + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
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

        
    }
    
}
