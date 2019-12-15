using MySql.Data.MySqlClient;
using studyBuddy.dataNeeds;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy
{
    class DataFetcherDA : UserDataAbstract
    {
        private MySqlConnection con;

        public DataFetcherDA(MysqlHandler mySqlHandler)
        {
            this.con = mySqlHandler.GetMySqlConnection();
        }

        public void SetUser(int id, List<string> interests)
        {   
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            MySqlCommand command = new MySqlCommand("SELECT ID, username, email, "
                                                    + "karma, rating, lastActivity, profileInfo, upForTeaching "
                                                    + "FROM " + MysqlHandler.tblUsers + $" WHERE ID = '{id}' ;", con);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                var IDCurrent = (int)row[0];
                var username = (string)row[1];
                var karma = (int)row[3];
                var rating = (int)row[4];
                var profileInfo = (string)row[6];
                var upForTeaching = row[7];

                CurrentUser.SetUserInfo(username, IDCurrent, karma, rating, profileInfo, interests);
            }
            con.Close();
            da.Dispose();
            dt.Dispose();
        }

        public void UpdateIfUserIsUpForTeaching(int isUpForTeaching)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            
            con.Open();
            MySqlCommand update = new MySqlCommand();
            update.Connection = con;
            update.CommandType = CommandType.Text;
            update.CommandText = "UPDATE " + MysqlHandler.tblUsers +
                $" SET upForTeaching = '{isUpForTeaching}'" +
                $" WHERE ID = '{CurrentUser.id}'";
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT ID, upForTeaching " 
                                                       + "FROM " + MysqlHandler.tblUsers, con);
            da.UpdateCommand = update;
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
            da.Dispose();
        }


    }
}
