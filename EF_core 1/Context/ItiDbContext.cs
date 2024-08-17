using EF_core_1.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_1.Context
{
    
    internal class ItiDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course_inst>()
                .HasKey(ci => new { ci.ins_ID, ci.Course_ID });
           
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_Id, sc.Course_Id });

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-ND54KPV ; Database = Iti ; Trusted_Connection = True ; Encrypt = False ");
        }

        public DbSet<Student>  Students { get; set; } 
        public DbSet<Department> Departments {  get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_inst> Course_insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }
}
