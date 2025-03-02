using Entity_FrameWork_Session02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session02
{
    internal class EnterPriceDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; DataBase = ITI ; Trusted_Connection = true; TrustServerCertificate = true;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_Id, sc.Course_Id });
            modelBuilder.Entity<Course_Inst>()
               .HasKey(sc => new { sc.Inst_Id, sc.Course_Id });
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                        .HasOne(S => S.department_Id)
                        .WithMany(D => D.Students);
            //modelBuilder.Entity<Instructor>()
            //            .HasMany(I => I.Courses)
            //            .WithMany(C => C.Instructors);
            //modelBuilder.Entity<Course>()
            //            .HasMany(C => C.Students)
            //            .WithMany(S => S.Courses);
            //modelBuilder.Entity<Course>()
            //            .HasMany(C => C.Course_Insts)
            //            .WithOne(CI => CI.Course)
            //            .HasForeignKey(CI => CI.Course_Id);

            //modelBuilder.Entity<Instructor>()
            //            .HasMany(I => I.Inst_Courses)
            //            .WithOne(IC => IC.Instructor)
            //            .HasForeignKey(IC => IC.Inst_Id);

            //modelBuilder.Entity<Course_Inst>()
            //            .HasKey(CI => new { CI.Course_Id, CI.Inst_Id });
            //////////////////////////////////////////////////////////////

            //modelBuilder.Entity<Course>()
            //            .HasMany(C => C.Course_Students)
            //            .WithOne(CS => CS.Course)
            //            .HasForeignKey(CS => CS.Course_Id);

            //modelBuilder.Entity<Student>()
            //            .HasMany(S => S.Stud_Courses)
            //            .WithOne(SC => SC.Student)
            //            .HasForeignKey(SC => SC.Stud_Id);

            //modelBuilder.Entity<Stud_Course>()
            //            .HasKey(SC => new { SC.Course_Id, SC.Stud_Id });
        }
    }
}
