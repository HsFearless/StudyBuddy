//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;

////using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;

//namespace dataNeeds
//{
//    public class ForumPostsContext : DbContext
//    {
//        public DbSet<Problem> ForumPosts { get; set; }
//        //public DbSet<Post> Posts { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {

//            optionsBuilder.UseMySQL(
//                    studyBuddy.dataNeeds.Nope.MysqlHandler.DefaultConString()
//                ) ;
//                //UseSqlServer(
//                //@"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
//        }
//    }

//    //public class Blog
//    //{
//    //    public int BlogId { get; set; }
//    //    public string Url { get; set; }
//    //    public int Rating { get; set; }
//    //    public List<Post> Posts { get; set; }
//    //}

//    //public class Post
//    //{
//    //    public int PostId { get; set; }
//    //    public string Title { get; set; }
//    //    public string Content { get; set; }

//    //    public int BlogId { get; set; }
//    //    public Blog Blog { get; set; }
//    //}

//    public class Problem
//    {
//        public Int64 ID { get; set; }

//        public Int64 ownerID { get; set; }

//        public int votes { get; set; }

//        public int subjectID { get; set; }

//        [Required]
//        public string description { get; set; }

//        [Required]
//        public string name { get; set; }
//    }
//}