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
using System.Text.RegularExpressions;
using System.Threading;

namespace studyBuddy
{
    public class DbConnection
    {
        private string host;
        private string username;
        private string password;
        private string database;
        private int port;
        private MySqlConnection con;
        public bool ready { get; private set; } //= false;//^auto
        public string messageToOutterWorld = "";
        public string lastError = "";
        public static object locker = new object();
        //private Data.MySqlClient a;

        private void Initialize()
        {
            Connect();
            //OpenConnection();
            messageToOutterWorld = con.State.ToString();
            ready = (con.State == System.Data.ConnectionState.Open) ? true : false;
        }

        public DbConnection(string host, string username, string password, string database, int port)
        {
            this.host = host;
            this.username = username;
            this.password = password;
            this.database = database;
            this.port = port;
            Initialize();
        }

        public DbConnection()
        {
            host = "remotemysql.com";
            username = "cDKryxhEGc";
            password = "rw0faFJV0H";
            database = "cDKryxhEGc";
            port = 3306;
            Initialize();
        }

        private void Connect()
        {
            string conArgs = $"server={this.host};port={this.port};database={this.database};" +
                $"username={this.username};password={this.password};";
            this.con = new MySqlConnection(conArgs);
            messageToOutterWorld = this.con.ToString();
        }

        private bool OpenConnection()
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

        public MySqlConnection GetMySqlConnection()
        {
            return this.con;
        }





    }
}
