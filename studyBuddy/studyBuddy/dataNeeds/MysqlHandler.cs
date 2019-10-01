using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/*
 * answer to FAQ from remote MySQL database provider:
 * 
 * In order to free up server space for new accounts 
 * we will delete any unactive accounts 
 * that haven't been used for over 30 days. 
 * 
 * You must update or insert data in your database 
 * at least once ever 30 days to remain active. 
 * 
 * Only selecting data will not prevent your MySQL account being deleted.
 * */

namespace studyBuddy
{
    class MysqlHandler
    {
        private string host;
        private string username;
        private string password;
        private string database;
        private int port;
        private MySql.Data.MySqlClient.MySqlConnection con;
        private MySql.Data.MySqlClient.MySqlCommand cmdCon;
        public bool ready { get; private set; } = false;
        public string messageToOutterWorld = "";
        public string lastError = "";
        //private Data.MySqlClient a;

        private void initialize()
        {
            connect();
            try
            {
                con.Open();
            }
            catch(Exception exce)
            {
                lastError = exce.Message;
            }
            messageToOutterWorld = con.State.ToString();
            if (con.State == System.Data.ConnectionState.Open)
                ready = true;
        }
        
        public MysqlHandler(string host, string username, string password, string database, int port)
        {
            this.host = host;
            this.username = username;
            this.password = password;
            this.database = database;
            this.port = port;
            initialize();
        }
        
        public MysqlHandler()
        {
            host = "remotemysql.com";
            username = "cDKryxhEGc";
            password = "rw0faFJV0H";
            database = "cDKryxhEGc";
            port = 3306;
            initialize();
        }

        ~MysqlHandler()
        {
            if (con == null)
                return;
            con.Close();
        }

        private void connect()
        {
            string conArgs = $"server={this.host};port={this.port};database={this.database};" +
                $"username={this.username};password={this.password};";
            this.con = new MySql.Data.MySqlClient.MySqlConnection(conArgs);
            messageToOutterWorld = this.con.ToString();
        }

        public void testSelectAllUsers()
        {
            string sql = "SELECT * FROM Users ;";
            this.cmdCon = new MySql.Data.MySqlClient.MySqlCommand(sql, this.con);
            try
            {
                con.Open();
                var resultReader = cmdCon.ExecuteReader();
                //# left here
            }
            catch(Exception ex)
            {
                lastError = ex.Message;
            }
        }

    }
}
