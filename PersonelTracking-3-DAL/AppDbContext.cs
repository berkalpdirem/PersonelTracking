using Microsoft.EntityFrameworkCore;
using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_3_DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<EmployeePersonalDocumnet> EmployeePersonalDocumnets { get; set; }
        public DbSet<EmployeeEducationInfo> EmployeeEducationInfos { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["PersonelTracking"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Primary Keys
            mb.Entity<Employee>()
            .HasKey(e => e.Id);

            mb.Entity<EmployeeDetail>()
               .HasKey(ed => ed.Id);

            mb.Entity<EmployeePersonalDocumnet>()
              .HasKey(edoc => edoc.Id);

            mb.Entity<EmployeeEducationInfo>()
                .HasKey(eeı => eeı.Id);

            mb.Entity<Certificate>()
              .HasKey(c => c.Id);
            //Employee-EmployeeDetail Relation
            mb.Entity<Employee>()
              .HasOne(e => e.employeeDetail)
              .WithOne(ed => ed.employee)
              .HasForeignKey<EmployeeDetail>(ed => ed.employeeID);

            //Employee-EmployeePersonalDocumnet Relation
            mb.Entity<Employee>()
              .HasOne(e=>e.employeePersonalDocumnet)
              .WithOne(edoc => edoc.employee)
              .HasForeignKey<EmployeePersonalDocumnet>(edoc => edoc.employeeID);

            //Employee-EmployeeEducationInfo Relation
            mb.Entity<Employee>()
              .HasOne(e => e.employeeEducationInfo)
              .WithOne(eeı => eeı.employee)
              .HasForeignKey<EmployeeEducationInfo>(eeı =>eeı.employeeID);

            // EmployeeEducation-Certificate Relation 
            mb.Entity<EmployeeEducationInfo>()
              .HasMany(eeı => eeı.Certificates) 
              .WithOne(c => c.EmployeeEducationInfo) 
              .HasForeignKey(c => c.EmployeeEducationInfoId); 

        }
    }
}
