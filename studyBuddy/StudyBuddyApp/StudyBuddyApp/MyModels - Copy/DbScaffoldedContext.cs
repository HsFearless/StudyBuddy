using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
//using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace StudyBuddyApp.MyModelsc
{
    public partial class MyDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MyDbContext()
        {
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
                optionsBuilder.UseMySQL("server=remotemysql.com;port=3306;database=cDKryxhEGc;username=cDKryxhEGc;password=rw0faFJV0H"
                   //mySqlOptions => mySqlOptions
                   // replace with your Server Version and Type
                   // .ServerVersion(new ServerVersion(new Version(8, 0, 18), ServerType.MySql)));
                   );
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
                    .HasColumnType("int(9)");

                entity.Property(e => e.CommentId)
                    .HasColumnName("commentID")
                    .HasColumnType("bigint(18)");
            });

            modelBuilder.Entity<ForumComments>(entity =>
            {
                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(18)");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("text");
                    //.HasCharSet("utf8")
                    //.HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ForumId)
                    .HasColumnName("forumID")
                    .HasColumnType("bigint(17)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasColumnType("int(9)");
            });

            modelBuilder.Entity<ForumPosts>(entity =>
            {
                entity.HasIndex(e => new { e.OwnerId, e.SubjectId })
                    .HasName("ownerID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(17)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");
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
                    .HasColumnType("int(9)");

                entity.Property(e => e.SubjectId)
                    .HasColumnName("subjectID")
                    .HasColumnType("int(9)");

                entity.Property(e => e.Votes)
                    .HasColumnName("votes")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ForumVotes>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ForumId })
                    .HasName("PRIMARY");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasColumnType("int(9)");

                entity.Property(e => e.ForumId)
                    .HasColumnName("forumID")
                    .HasColumnType("bigint(17)");
            });

            modelBuilder.Entity<Interests>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(9)");

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
                    .HasColumnType("int(9)");

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
                    .HasColumnType("int(9)");

                entity.Property(e => e.InterestId)
                    .HasColumnName("interestID")
                    .HasColumnType("int(9)");
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
                    .HasColumnType("int(9)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(70)");
                    //.HasCharSet("ascii")
                    //.HasCollation("ascii_general_ci");

                entity.Property(e => e.Karma)
                    .HasColumnName("karma")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastActivity)
                    .HasColumnName("lastActivity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoggedInHash)
                    .HasColumnName("loggedInHash")
                    .HasColumnType("char(28)")
                    .HasComment("hashed using device identifier");
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
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasColumnName("salt")
                    .HasColumnType("char(16)");
                    //.HasCharSet("ascii")
                    //.HasCollation("ascii_general_ci");

                entity.Property(e => e.UpForTeaching)
                    .HasColumnName("upForTeaching")
                    .HasColumnType("tinyint(5)");

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
