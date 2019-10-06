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

using MySql.Data.MySqlClient;
namespace studyBuddy.dataNeeds
{
    class MysqlHandler
    {
        public static string tblUsers = "Users";
        private string host;
        private string username;
        private string password;
        private string database;
        private int port;
        private MySqlConnection con;
        private MySqlCommand cmdCon;
        public bool ready { get; private set; } = false;
        public string messageToOutterWorld = "";
        public string lastError = "";
        //private Data.MySqlClient a;

        private void initialize()
        {
            connect();
            openConnection();
            messageToOutterWorld = con.State.ToString();
            ready = (con.State == System.Data.ConnectionState.Open) ? true : false;
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
            this.con = new MySqlConnection(conArgs);
            messageToOutterWorld = this.con.ToString();
        }

        private bool openConnection()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                    return true;
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        lastError = "Cannot connect to server";
                        break;

                    case 1045:
                        lastError = "Invalid DB username/password";
                        break;

                    default:
                        lastError = "Exception: " + ex.Message;
                        break;
                }
                return false;
            }
        }
        private bool openNewConnection()
        {
            con.Close();
            return openConnection();
        }

        private void prepareSql(ref string given)
        {
            given = (given[0] == ' ') ? given : " " + given;
            given = (given[given.Length - 1] == ';') ? given : given + ";";
            return ;
        }
        public List<string[]> select(string sqlWithoutSelect)
        {
            //string[,] toReturn = new string[0,0];
            List<string[]> toReturn = new List<string[]>();
            prepareSql(ref sqlWithoutSelect);
            string fullSql = "SELECT";
            fullSql += sqlWithoutSelect;
            if (openNewConnection())
            {
                //try
                //{
                cmdCon = new MySqlCommand(fullSql, this.con);
                var result = cmdCon.ExecuteReader();
                int item = 0;
                string[] row;
                while(result.Read())
                {
                    row = new string[result.FieldCount];
                    for(item=0; item<result.FieldCount; item++)
                    {
                        row[item] = result[item] + "";
                    }
                    toReturn.Add(row);
                }
                result.Close();
                //}

            }
            return toReturn;
        }

        public string[] selectOneRow(string sqlWithoutSelect)
        {
            string[] toReturn = new string[0];
            prepareSql(ref sqlWithoutSelect);
            string fullSql = "SELECT";
            fullSql += sqlWithoutSelect;
            if(openNewConnection())
            {
                cmdCon = new MySqlCommand(fullSql, this.con);
                var result = cmdCon.ExecuteReader();
                //while used so we do not proceed with zero row returned
                while (result.Read())
                {
                    toReturn = new string[result.FieldCount];
                    for (int i = 0; i < result.FieldCount; i++)
                        toReturn[i] = result[i] + "";
                    //break after 1st iteration
                    result.Close();
                    return toReturn;
                }
            }
            return toReturn;
        }



        public void testSelectAllUsers()
        {
            if (!openConnection())
                return;

            string aut = "";
            string sql = "SELECT * FROM Users ;";
            this.cmdCon = new MySqlCommand(sql, this.con);
            try
            {
                var result = cmdCon.ExecuteReader();
                while(result.Read())
                {
                    aut += "username=" + result["username"] + ";\n";
                    aut += "password=" + result["password"] + ";\n";
                    aut += "salt=" + result["salt"] + ";\n\n";
                }
                messageToOutterWorld = aut;
            }
            catch(Exception ex)
            {
                lastError = ex.Message;
            }
        }

    }
}
