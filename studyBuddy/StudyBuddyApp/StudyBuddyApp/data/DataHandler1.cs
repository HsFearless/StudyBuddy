using MySql.Data.MySqlClient;

using System.Data;


using System.Data.SqlClient;
using System.Text;

namespace StudyBuddyApp
{
    public class DataHandler1
    {
        private readonly MySqlConnection cn;
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
            //messageToOutterWorld = con.State.ToString();
           // ready = (con.State == System.Data.ConnectionState.Open) ? true : false;
        }

       

        private void Connect()
        {
            string conArgs = $"server={this.host};port={this.port};database={this.database};" +
                $"username={this.username};password={this.password};";
           // this.con = new MySqlConnection(conArgs);
            //messageToOutterWorld = this.con.ToString();
        }


        public DataHandler1()
        {
            this.host = "remotemysql.com";
            this.username = "cDKryxhEGc";
            this.password = "rw0faFJV0H";
            this.database = "cDKryxhEGc";
            this.port = 3306;
            Initialize();
        }

        public void GetForum()
        {
           /* string conArgs = $"server={this.host};port={this.port};database={this.database};" +
                $"username={this.username};password={this.password};";
            MySqlConnection con = new MySqlConnection("server=remotemysql.com;port=3306;database=cDKryxhEGc;user=cDKryxhEGc;password=rw0faFJV0H;");
           // con.Close();
           
            MySqlDataAdapter da = new MySqlDataAdapter();
            con.Open();
            MySqlCommand command = new MySqlCommand("ID, name, subjectID, description, ownerID, votes FROM ForumPosts", con);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds, "ForumPosts");
            con.Close();
            da.Dispose();
            System.Console.WriteLine(ds.Tables[0].Rows[0]["name"]);*/
        }
    }
}
