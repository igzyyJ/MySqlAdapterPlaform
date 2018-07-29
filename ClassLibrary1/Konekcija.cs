using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data.MySql;

namespace ClassLibrary1
{
   public class Konekcija
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

       public string connectionString = "SERVER=144.76.54.83;DATABASE=sferasof_testRemote;UID=sferasof_test;PASSWORD=YTZQSKSUAVw&;"; 
            
            
         

        public void Initialize()
        {
            server = "localhost";
            database = "transfer";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

    }
}
