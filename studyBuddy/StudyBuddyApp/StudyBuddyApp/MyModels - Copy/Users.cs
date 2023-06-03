using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyBuddyApp.MyModelsc
{
    public partial class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string Salt { get; set; }
        public int Karma { get; set; }
        public int Rating { get; set; }
        public int LastActivity { get; set; }
        public string LoggedInHash { get; set; }
        public string ProfileInfo { get; set; }
        public sbyte UpForTeaching { get; set; }
    }
}

//            modelBuilder.Entity<Users>(entity =>
//            {
//                entity.HasIndex(e => e.Email)
//                    .HasName("email")
//                    .IsUnique();

//                entity.HasIndex(e => e.Username)
//                    .HasName("username")
//                    .IsUnique();

//                entity.HasIndex(e => new { e.Username, e.Email, e.Salt, e.LastActivity, e.LoggedInHash })
//                    .HasName("username_2");

//                entity.Property(e => e.Id)
//                    .HasColumnName("ID")
//                    .HasColumnType("int(9)");

//                entity.Property(e => e.Email)
//                    .IsRequired()
//                    .HasColumnName("email")
//                    .HasColumnType("varchar(70)")
//                    .HasCharSet("ascii")
//                    .HasCollation("ascii_general_ci");

//                entity.Property(e => e.Karma)
//                    .HasColumnName("karma")
//                    .HasColumnType("int(11)");

//                entity.Property(e => e.LastActivity)
//                    .HasColumnName("lastActivity")
//                    .HasColumnType("int(11)");

//                entity.Property(e => e.LoggedInHash)
//                    .HasColumnName("loggedInHash")
//                    .HasColumnType("char(28)")
//                    .HasComment("hashed using device identifier")
//                    .HasCharSet("ascii")
//                    .HasCollation("ascii_general_ci");

//                entity.Property(e => e.Password)
//                    .IsRequired()
//                    .HasColumnName("password")
//                    .HasColumnType("char(52)")
//                    .HasCharSet("ascii")
//                    .HasCollation("ascii_general_ci");

//                entity.Property(e => e.ProfileInfo)
//                    .HasColumnName("profileInfo")
//                    .HasColumnType("varchar(255)")
//                    .HasCharSet("ascii")
//                    .HasCollation("ascii_general_ci");

//                entity.Property(e => e.Rating)
//                    .HasColumnName("rating")
//                    .HasColumnType("int(11)");

//                entity.Property(e => e.Salt)
//                    .IsRequired()
//                    .HasColumnName("salt")
//                    .HasColumnType("char(16)")
//                    .HasCharSet("ascii")
//                    .HasCollation("ascii_general_ci");

//                entity.Property(e => e.UpForTeaching)
//                    .HasColumnName("upForTeaching")
//                    .HasColumnType("tinyint(5)");

//                entity.Property(e => e.Username)
//                    .IsRequired()
//                    .HasColumnName("username")
//                    .HasColumnType("varchar(24)")
//                    .HasCharSet("ascii")
//                    .HasCollation("ascii_general_ci");
//            });

