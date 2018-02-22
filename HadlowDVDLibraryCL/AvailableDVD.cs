using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AshfordDVDLibraryCL
{
    class AvailableDVD
    {
        public static OleDbDataAdapter checkInStock() {
            try
            {
                OleDbConnection myConnection = DBConnectivity.GetConnection();
                String myQuery = "SELECT * FROM DVD WHERE Stock > 0 ORDER BY DVDID ASC";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    return da;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in DBHandler", ex);
                    myConnection.Close();
                    return null;
                }
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
