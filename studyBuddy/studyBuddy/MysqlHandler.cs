using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace studyBuddy
{
    class MysqlHandler
    {
        private string host;
        private string username;
        private string password;
        private string database;
        private int port;
        //private Data.MySqlClient a;

        public MysqlHandler(string host, string username, string password, string database, int port)
        {
            this.host = host;
            this.username = username;
            this.password = password;
            this.database = database;
            this.port = port;
        }
        
        public MysqlHandler()
        {
            host = "remotemysql.com";
            username = "cDKryxhEGc";
            password = "rw0faFJV0H";
            database = "cDKryxhEGc";
            port = 3306;
        }



    }
}
