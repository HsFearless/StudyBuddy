//using System;
//using System.Collections.Generic;
//using System.Text;
//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;

////namespace StudyBuddyApp.Models
////{
//using MySql.Data.EntityFrameworkCore;

//namespace EFModeling.FluentAPI.Requiredd
//    {
//        class MyContext : DbContext
//        {
//            public DbSet<Problem> Problems { get; set; }

//            //protected override void OnModelCreating(ModelBuilder modelBuilder)
//            //{
//            //    modelBuilder.Entity<Problem>()
//            //        .Property(b => b.Name)
//            //        .IsRequired();
//            //}
//        }

//        public class Problem
//        {
//            public int Id { get; set; }

//            [Required]
//            public string Desc { get; set; }

//            [Required]
//            public string Name { get; set; }
//        }
//    }


