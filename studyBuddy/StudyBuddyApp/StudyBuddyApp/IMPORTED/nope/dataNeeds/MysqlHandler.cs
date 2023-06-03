

using System.Collections.Generic;

namespace studyBuddy.dataNeeds
{
    class MysqlHandler
    {
        public static string tblUsers = "Users";
        public static string tblSubjects = "Subjects";
        public static string tblForum = "ForumPosts";
        public static string tblUserInterests = "UserInterests";
        public static string tblInterests = "Interests";
        public static string tblForumComments = "ForumComments";
        public static string tblForumVotes = "ForumVotes";
        public static string tblForumCommentsVotes = "CommentVotes";
        private string host;
        private string username;
        private string password;
        private string database;
        private int port;
        private string con;
        private string cmdCon;
        public bool ready { get; private set; } //= false;//^auto
        public string messageToOutterWorld = "";
        public string lastError = "";
        public static object locker = new object();
        //private Data.MySqlClient a;

        public List<string[]> Select(string sqlWithoutSelect)
        {
            return null;
        }

        public string[] SelectOneRow(string sqlWithoutSelect)
        {
            return null;
        }

        public bool InsertInto(string sqlWithoutInsertInto, KeyValuePair<string, string>[] escapePair = null)
        {
            return false;
        }

        public bool Update(string sqlWithoutUpdate, KeyValuePair<string, string>[] escapePair = null)
        {
            return false;
        }

        public bool DeleteFrom(string sqlWithoutDeleteFrom, bool fullDeleteAllowed = false)
        {
            return false;
        }

        public static KeyValuePair<string, string>[] ConstructQueryParams(string[] keys, string[] values)
        {
            return null;
        }
    }
}


// //--------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;

///*
// * answer to FAQ from remote MySQL database provider:
// * 
// * In order to free up server space for new accounts 
// * we will delete any unactive accounts 
// * that haven't been used for over 30 days. 
// * 
// * You must update or insert data in your database 
// * at least once ever 30 days to remain active. 
// * 
// * Only selecting data will not prevent your MySQL account being deleted.
// * */

//using MySql.Data.MySqlClient;
//using System.Text.RegularExpressions;
//using System.Threading;

//namespace studyBuddy.dataNeeds
//{
//    class MysqlHandler
//    {
//        public static string tblUsers = "Users";
//        public static string tblSubjects = "Subjects";
//        public static string tblForum = "ForumPosts";
//        public static string tblUserInterests = "UserInterests";
//        public static string tblInterests = "Interests";
//        public static string tblForumComments = "ForumComments";
//        public static string tblForumVotes = "ForumVotes";
//        public static string tblForumCommentsVotes = "CommentVotes";
//        private string host;
//        private string username;
//        private string password;
//        private string database;
//        private int port;
//        private MySqlConnection con;
//        private MySqlCommand cmdCon;
//        public bool ready { get; private set; } //= false;//^auto
//        public string messageToOutterWorld = "";
//        public string lastError = "";
//        public static object locker = new object();
//        //private Data.MySqlClient a;

//        private void Initialize()
//        {
//            Connect();
//            OpenConnection();
//            messageToOutterWorld = con.State.ToString();
//            ready = (con.State == System.Data.ConnectionState.Open) ? true : false;
//        }

//        public MysqlHandler(string host, string username, string password, string database, int port)
//        {
//            this.host = host;
//            this.username = username;
//            this.password = password;
//            this.database = database;
//            this.port = port;
//            Initialize();
//        }

//        public MysqlHandler()
//        {
//            host = "remotemysql.com";
//            username = "cDKryxhEGc";
//            password = "rw0faFJV0H";
//            database = "cDKryxhEGc";
//            port = 3306;
//            Initialize();
//        }

//        ~MysqlHandler()
//        {
//            if (con == null)
//                return;
//            con.Close();
//        }

//        private void Connect()
//        {
//            string conArgs = $"server={this.host};port={this.port};database={this.database};" +
//                $"username={this.username};password={this.password};";
//            this.con = new MySqlConnection(conArgs);
//            messageToOutterWorld = this.con.ToString();
//        }

//        private bool OpenConnection()
//        {
//            try
//            {
//                //for(int i= 0; i< 20; i++)
//                //{
//                //    Task.Run(() => con.Open());
//                //}

//                if (con.State == System.Data.ConnectionState.Open)
//                    return true;
//                con.Open();
//                return true;
//            }
//            catch (MySqlException ex)
//            {
//                switch (ex.Number)
//                {
//                    case 0:
//                        lastError = "Cannot connect to server";
//                        break;

//                    case 1045:
//                        lastError = "Invalid DB username/password";
//                        break;

//                    default:
//                        lastError = "Exception: " + ex.Message;
//                        break;
//                }
//                return false;
//            }
//        }
//        private bool OpenNewConnection()
//        {
//            //Console.WriteLine("Request from thread id: " + Thread.CurrentThread.ManagedThreadId);
//            //bool opened = false;
//            //if (Program.mainThreadId == Thread.CurrentThread.ManagedThreadId)
//            //{
//            //    Program._blockThread2.WaitOne();
//            //    con.Close()
//            //    opened = OpenConnection();
//            //}
//            //else
//            //{
//            //    con.Close();
//            //    opened = OpenConnection();
//            //}
//            //return opened;

//            //while (true)
//            //{
//            //    if (!Program.ThreadSaysYes && Program.mainThreadId == Thread.CurrentThread.ManagedThreadId) //^thread fake lock
//            //        continue;
//            //    con.Close();
//            //    return OpenConnection();
//            //}

//            //Monitor.TryEnter(locker);
//            lock (locker)
//            {
//                con.Close();
//            }

//            return OpenConnection();

//            try
//            {
//                con.Close();
//                return OpenConnection();
//            }
//            catch
//            {
//                throw;
//            }
//            finally
//            {
//                Monitor.Exit(locker);
//            }


//        }

//        private void PrepareSql(ref string given)
//        {
//            given = (given[0] == ' ') ? given : " " + given;
//            given = (given[given.Length - 1] == ';') ? given : given + ";";
//            return;
//        }
//        public List<string[]> Select(string sqlWithoutSelect)
//        {
//            //string[,] toReturn = new string[0,0];
//            List<string[]> toReturn = new List<string[]>();
//            PrepareSql(ref sqlWithoutSelect);
//            string fullSql = "SELECT";
//            fullSql += sqlWithoutSelect;
//            if (OpenNewConnection())
//            {
//                //try
//                //{
//                cmdCon = new MySqlCommand(fullSql, this.con);
//                var result = cmdCon.ExecuteReader();
//                int item = 0;
//                string[] row;
//                while (result.Read())
//                {
//                    row = new string[result.FieldCount];
//                    for (item = 0; item < result.FieldCount; item++)
//                    {
//                        row[item] = result[item] + "";
//                    }
//                    toReturn.Add(row);
//                }
//                result.Close();
//                //}

//            }
//            return toReturn;
//        }

//        public string[] SelectOneRow(string sqlWithoutSelect)
//        {
//            string[] toReturn = new string[0];
//            PrepareSql(ref sqlWithoutSelect);
//            string fullSql = "SELECT";
//            fullSql += sqlWithoutSelect;
//            if (OpenNewConnection())
//            {
//                cmdCon = new MySqlCommand(fullSql, this.con);
//                var result = cmdCon.ExecuteReader();
//                //while used so we do not proceed with zero row returned
//                while (result.Read())
//                {
//                    toReturn = new string[result.FieldCount];
//                    for (int i = 0; i < result.FieldCount; i++)
//                        toReturn[i] = result[i] + "";
//                    //break after 1st iteration
//                    result.Close();
//                    con.Close();
//                    return toReturn;
//                }
//            }
//            return toReturn;
//        }

//        public bool InsertInto(string sqlWithoutInsertInto, KeyValuePair<string, string>[] escapePair=null)
//        {
//            PrepareSql(ref sqlWithoutInsertInto);
//            string fullSql = "INSERT INTO";
//            fullSql += sqlWithoutInsertInto;
//            if (!OpenNewConnection())
//                return false;
//            if (escapePair != null)
//                fullSql = EscapeString(fullSql, escapePair);
//            cmdCon = new MySqlCommand(fullSql, this.con);
//            int affectedRows = cmdCon.ExecuteNonQuery();
//            bool queryOk = (affectedRows > 0);

//            con.Close();
//            return queryOk; //probably?
//        }

//        public bool Update(string sqlWithoutUpdate, KeyValuePair<string, string>[] escapePair= null)
//        {
//            PrepareSql(ref sqlWithoutUpdate);
//            string fullSql = "UPDATE";
//            fullSql += sqlWithoutUpdate;
//            if (!OpenNewConnection())
//                return false;
//            if (escapePair != null)
//                fullSql = EscapeString(fullSql, escapePair);
//            cmdCon = new MySqlCommand(fullSql, this.con);
//            int affectedRows = cmdCon.ExecuteNonQuery();

//            bool queryOk = (affectedRows > 0);

//            con.Close();
//            return queryOk;
//        }

//        public bool DeleteFrom(string sqlWithoutDeleteFrom, bool fullDeleteAllowed = false)
//        {
//            PrepareSql(ref sqlWithoutDeleteFrom);
//            string fullSql = "DELETE FROM";
//            fullSql += sqlWithoutDeleteFrom;
//            if (fullDeleteAllowed == false)
//                if (!Regex.IsMatch(fullSql, Regex.Escape("WHERE"), RegexOptions.IgnoreCase))
//                    throw new exceptions.ConfirmationNotReceived(); //^unhandled exception
//            if (!OpenNewConnection())
//                return false;
//            cmdCon = new MySqlCommand(fullSql, this.con);
//            int affectedRows = cmdCon.ExecuteNonQuery();

//            bool queryOk = (affectedRows > 0);

//            con.Close();
//            return queryOk;
//        }

//        public void TestSelectAllUsers()
//        {
//            if (!OpenConnection())
//                return;

//            string aut = "";
//            string sql = "SELECT * FROM Users ;";
//            this.cmdCon = new MySqlCommand(sql, this.con);
//            try
//            {
//                var result = cmdCon.ExecuteReader();
//                while (result.Read())
//                {
//                    aut += "username=" + result["username"] + ";\n";
//                    aut += "password=" + result["password"] + ";\n";
//                    aut += "salt=" + result["salt"] + ";\n\n";
//                }
//                messageToOutterWorld = aut;
//            }
//            catch (Exception ex)
//            {
//                lastError = ex.Message;
//            }
//        }

//        public static KeyValuePair<string, string>[] ConstructQueryParams(string[] keys, string[] values)
//        {
//            if (keys.Length != values.Length)
//                throw new Exception();//#
//            KeyValuePair<string, string>[] toReturn = new KeyValuePair<string, string>[keys.Length];
//            for(int i = 0; i<keys.Length; i++)
//            {
//                toReturn[i] = new KeyValuePair<string, string>(keys[i], values[i]);
//            }
//            return toReturn;
//        }

//        private static string EscapeString(string sql, KeyValuePair<string, string>[] escapeTagContentPair)
//        {
//            string toReturn = sql;
//            if (escapeTagContentPair != null && escapeTagContentPair.Length > 0)
//            {
//                foreach (var qParam in escapeTagContentPair)
//                {
//                    //#cmdCon.Parameters.Add(qParam.Key, qParam.Value);
//                    toReturn = toReturn.Replace(qParam.Key,
//                        MySql.Data.MySqlClient.MySqlHelper.EscapeString(qParam.Value) + "");
//                    //System.Windows.Forms.MessageBox.Show("key: " + qParam.Key +
//                        //"\nval: " + qParam.Value);
//                    //escape bad symbols
//                }
//                //System.Windows.Forms.MessageBox.Show(toReturn);
//            }
//            return toReturn;
//        }

//    }
//}
