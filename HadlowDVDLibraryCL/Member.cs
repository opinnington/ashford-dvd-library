using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AshfordDVDLibraryCL
{
    class Member
    {

        public static void updateMember(string mI, string ti, string fn, string ln, string a, string c, string p, string te, string ty) {
            OleDbConnection myConnection = DBConnectivity.GetConnection();
            String myQuery = "UPDATE Member SET Title='" + ti +  
                             "', FirstName ='" + fn +
                             "', Surname ='" + ln +
                             "', Address ='" + a +
                             "', County ='" + c +
                             "', PostCode ='" + p +
                             "', Telephone ='" + te +
                             "', TypeOfMember ='" + ty +

                             "' WHERE MembershipID=" + mI + "";
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

        public static void registerMember(string ti, string fn, string ln, string a, string c, string p, string te, string ty) {
            try
            {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "INSERT INTO Member(Title, FirstName, Surname, Address, County, PostCode, Telephone, TypeOfMember) VALUES (@ti, @fn, @ln, @a, @c, @p, @te, @t)";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                
                myCommand.Parameters.Add("@ti", OleDbType.VarChar).Value = ti;
                myCommand.Parameters.Add("@fn", OleDbType.VarChar).Value = fn;
                myCommand.Parameters.Add("@ln", OleDbType.VarChar).Value = ln;
                myCommand.Parameters.Add("@a", OleDbType.VarChar).Value = a;
                myCommand.Parameters.Add("@c", OleDbType.VarChar).Value = c;
                myCommand.Parameters.Add("@p", OleDbType.VarChar).Value = p;
                myCommand.Parameters.Add("@te", OleDbType.VarChar).Value = te;
                myCommand.Parameters.Add("@ty", OleDbType.VarChar).Value = ty;

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
                MessageBox.Show("Error connecting to database");
            }

        }
        public static void deleteMember(string mI) {
            try {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "DELETE FROM Member WHERE [MembershipID] =" + mI + "";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                try
                {
                    MessageBox.Show(myQuery);
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
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void displayMemberID(string mI) {
            try
            {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "SELECT FirstName Member WHERE [MembershipID] =" + mI + "";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                try
                {
                    MessageBox.Show(myQuery);
                    myConnection.Open();
                    myCommand.ExecuteReader();
                    
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
    }
}
