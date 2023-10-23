using Microsoft.EntityFrameworkCore;
using PersonelTracking_4_Entities.Concrete;
using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_3_DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<EmployeePersonalDocumnet> EmployeePersonalDocumnets { get; set; }
        public DbSet<EmployeeEducationInfo> EmployeeEducationInfos { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<EmployeeCompanyInfo> EmployeeCompanyInfos { get; set; }
        public DbSet<DayOf> DayOfs { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }


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

            mb.Entity<EmployeeCompanyInfo>()
              .HasKey(ecı => ecı.Id);

            mb.Entity<DayOf>()
              .HasKey(dayOf => dayOf.Id);

            mb.Entity<Payroll>()
              .HasKey(p => p.Id);
            //---------------------------------------------------Relations--------------------------------------------
            //Employee-EmployeeDetail Relation
            mb.Entity<Employee>()
              .HasOne(e => e.employeeDetail)
              .WithOne(ed => ed.employee)
              .HasForeignKey<EmployeeDetail>(ed => ed.employeeID);

            //Employee-EmployeePersonalDocumnet Relation
            mb.Entity<Employee>()
              .HasOne(e => e.employeePersonalDocumnet)
              .WithOne(edoc => edoc.employee)
              .HasForeignKey<EmployeePersonalDocumnet>(edoc => edoc.employeeID);

            //Employee-EmployeeEducationInfo Relation
            mb.Entity<Employee>()
              .HasOne(e => e.employeeEducationInfo)
              .WithOne(eeı => eeı.employee)
              .HasForeignKey<EmployeeEducationInfo>(eeı => eeı.employeeID);

            // EmployeeEducation-Certificate Relation 
            mb.Entity<EmployeeEducationInfo>()
              .HasMany(eeı => eeı.Certificates)
              .WithOne(c => c.EmployeeEducationInfo)
              .HasForeignKey(c => c.EmployeeEducationInfoId);

            // Employee-EmployeeCompanyInfo Relation
            mb.Entity<Employee>()
              .HasOne(e => e.employeeCompanyInfo)
              .WithOne(ecı => ecı.employee)
              .HasForeignKey<EmployeeCompanyInfo>(ecı => ecı.employeeId);

            // DayOf-EmployeeCompanyInfo Relation
            mb.Entity<EmployeeCompanyInfo>()
              .HasMany(ecı => ecı.dayOfs)
              .WithOne(dayOf => dayOf.employeeCompanyInfo)
              .HasForeignKey(dayOf => dayOf.employeeCompanyInfoID);

            //Payroll-EmployeeCompanyInfo Relation
            mb.Entity<EmployeeCompanyInfo>()
              .HasMany(ecı => ecı.payrolls)
              .WithOne(p => p.employeeCompanyInfo)
              .HasForeignKey(p => p.employeeCompanyInfoID);
        }
    }
}
