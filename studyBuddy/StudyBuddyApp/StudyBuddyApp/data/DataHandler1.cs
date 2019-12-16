using MySql.Data.MySqlClient;
using studyBuddy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace StudyBuddyApp
{
    public class DataHandler1
    {
        private readonly MySqlConnection cn;
       

        public DataHandler1()
        {
            DbConnection db = new DbConnection();
            this.cn = db.GetMySqlConnection();
        }

        public void GetForum()
        {
            return;
            SqlDataAdapter da = new SqlDataAdapter();
            cn.Open();
            //SqlCommand command = new SqlCommand("ID, name, subjectID, description, ownerID, votes FROM ForumPosts", cn);
           // da.SelectCommand = command;
           // DataSet ds = new DataSet();
           // da.Fill(ds, "ForumPosts");
            cn.Close();
            da.Dispose();
           // Console.WriteLine(ds.Tables[0].Rows[0]["name"]);
        }
    }
}
