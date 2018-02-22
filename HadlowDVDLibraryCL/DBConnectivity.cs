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
    class DBConnectivity
    {
        public static OleDbConnection GetConnection(){
            String connString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\..\..\AshfordDVDLibraryDB.accdb";
            return new OleDbConnection(connString);
        }
    }
}
