using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
//using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
//using EntityFrameworkWithXamarin;
//using EntityFrameworkWithXamarin.Core;
using System.Collections.Generic;
using StudyBuddyApp.MyModelsc;

namespace StudyBuddyApp.MyModelsc
{

    /*public class PostDatabaseHelper<T> where T : MyDbContext
    {

        protected MyDbContext CrateContext()
        {
            MyDbContext postDatabaseContext = (T)Activator.CreateInstance(typeof(T));
            postDatabaseContext.Database.EnsureCreated();
            postDatabaseContext.Database.Migrate();
            return postDatabaseContext;
        }
    }*/


    public partial class MyDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MyDbContext()
        {
            this.Database.EnsureCreated();
            this.Database.Migrate();
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CommentVotes> CommentVotes { get; set; }
        public virtual DbSet<ForumComments> ForumComments { get; set; }
        public virtual DbSet<ForumPosts> ForumPosts { get; set; }
        public virtual DbSet<ForumVotes> ForumVotes { get; set; }
        public virtual DbSet<Interests> Interests { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<UserInterests> UserInterests { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseMySQL("server=remotemysql.com;port=3306;database=cDKryxhEGc;username=cDKryxhEGc;password=rw0faFJV0H;"
                //mySqlOptions => mySqlOptions
                // replace with your Server Version and Type
                // .ServerVersion(new ServerVersion(new Version(8, 0, 18), ServerType.MySql)));
                // );
                //optionsBuilder.UseMySQL("server=remotemysql.com;port=3306;database=cDKryxhEGc;user=cDKryxhEGc;password=rw0faFJV0H;");
                //optionsBuilder.UseSqlServer("Server=tcp:studybuddytop.database.windows.net,1433;Initial Catalog=studybuddyDB;Persist Security Info=False;User ID=studybuddy;Password=rw0faFJV0H;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                //optionsBuilder.UseSqlServer("Server = studybuddytop.database.windows.net; Database = studybuddyDB; User Id = myUsername;
                //Password = myPassword;"); 
                var databasePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myData.db");
                optionsBuilder.UseSqlite($"Filename={databasePath}");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommentVotes>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CommentId })
                    .HasName("PRIMARY");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasColumnType("int");

                entity.Property(e => e.CommentId)
                    .HasColumnName("commentID")
                    .HasColumnType("bigint");
            });

            modelBuilder.Entity<ForumComments>(entity =>
            {
                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("varchar(8000)");
                    //.HasCharSet("utf8")
                    //.HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ForumId)
                    .HasColumnName("forumID")
                    .HasColumnType("bigint");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasColumnType("int");
            });

            modelBuilder.Entity<ForumPosts>(entity =>
            {
                entity.HasIndex(e => new { e.OwnerId, e.SubjectId })
                    .HasName("ownerID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(8000)");
                //.HasCharSet("utf8mb4")
                //.HasCollation("utf8mb4_bin");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");
                    //.HasCharSet("utf8mb4")
                    //.HasCollation("utf8mb4_bin");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("ownerID")
                    .HasColumnType("int");

                entity.Property(e => e.SubjectId)
                    .HasColumnName("subjectID")
                    .HasColumnType("int");

                entity.Property(e => e.Votes)
                    .HasColumnName("votes")
                    .HasColumnType("int");
            });

            modelBuilder.Entity<ForumVotes>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ForumId })
                    .HasName("PRIMARY");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasColumnType("int");

                entity.Property(e => e.ForumId)
                    .HasColumnName("forumID")
                    .HasColumnType("bigint");
            });

            modelBuilder.Entity<Interests>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");
                    //.HasCharSet("utf8mb4")
                    //.HasCollation("utf8mb4_bin");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");
                    //.HasCharSet("utf8mb4")
                    //.HasCollation("utf8mb4_bin");
            });

            modelBuilder.Entity<UserInterests>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.InterestId })
                    .HasName("PRIMARY");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasColumnType("int");

                entity.Property(e => e.InterestId)
                    .HasColumnName("interestID")
                    .HasColumnType("int");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.HasIndex(e => new { e.Username, e.Email, e.Salt, e.LastActivity, e.LoggedInHash })
                    .HasName("username_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(70)");
                    //.HasCharSet("ascii")
                    //.HasCollation("ascii_general_ci");

                entity.Property(e => e.Karma)
                    .HasColumnName("karma")
                    .HasColumnType("int");

                entity.Property(e => e.LastActivity)
                    .HasColumnName("lastActivity")
                    .HasColumnType("int");

                entity.Property(e => e.LoggedInHash)
                    .HasColumnName("loggedInHash")
                    .HasColumnType("char(28)");
                    //.HasComment("hashed using device identifier");
                //.HasCharSet("ascii")
                //.HasCollation("ascii_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("char(52)");
                //.HasCharSet("ascii")
                //.HasCollation("ascii_general_ci");

                entity.Property(e => e.ProfileInfo)
                    .HasColumnName("profileInfo")
                    .HasColumnType("varchar(255)");
                    //.HasCharSet("ascii")
                    //.HasCollation("ascii_general_ci");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("int");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasColumnName("salt")
                    .HasColumnType("char(16)");
                    //.HasCharSet("ascii")
                    //.HasCollation("ascii_general_ci");

                entity.Property(e => e.UpForTeaching)
                    .HasColumnName("upForTeaching")
                    .HasColumnType("tinyint");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(24)");
                    //.HasCharSet("ascii")
                    //.HasCollation("ascii_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
