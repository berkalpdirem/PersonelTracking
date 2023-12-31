﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelTracking_3_DAL.Context;

#nullable disable

namespace PersonelTracking_3_DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonelTracking_4_Entities.Concrete.Payroll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("depositDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("employeeCompanyInfoID")
                        .HasColumnType("int");

                    b.Property<int>("netSalaryAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("employeeCompanyInfoID");

                    b.ToTable("Payrolls");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CertificateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeEducationInfoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeEducationInfoId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.DayOf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("dayOfEndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("dayOfLenghtByDay")
                        .HasColumnType("int");

                    b.Property<DateTime>("dayOfStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("employeeCompanyInfoID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("employeeCompanyInfoID");

                    b.ToTable("DayOfs");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("dataStatus")
                        .HasColumnType("int");

                    b.Property<int>("employeeCompanyInfoID")
                        .HasColumnType("int");

                    b.Property<int>("employeeDetailID")
                        .HasColumnType("int");

                    b.Property<int>("employeeEducationInfoID")
                        .HasColumnType("int");

                    b.Property<int>("employeePersonalDocumnetID")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tcNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeeCompanyInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("dayOfCountRightCurrent")
                        .HasColumnType("int");

                    b.Property<int>("dayOfCountRightYearly")
                        .HasColumnType("int");

                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.Property<int>("employeeStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDateOfWork")
                        .HasColumnType("datetime2");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.Property<int>("seniority")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDateOfWork")
                        .HasColumnType("datetime2");

                    b.Property<int>("unitOfWork")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("employeeId")
                        .IsUnique();

                    b.ToTable("EmployeeCompanyInfos");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("birthCity")
                        .HasColumnType("int");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("employeeID")
                        .HasColumnType("int");

                    b.Property<string>("fatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("livingCity")
                        .HasColumnType("int");

                    b.Property<int>("maritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("motherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("employeeID")
                        .IsUnique();

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeeEducationInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("employeeID")
                        .HasColumnType("int");

                    b.Property<string>("highSchoolGradued")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("highSchoolGraduedGPA")
                        .HasColumnType("int");

                    b.Property<string>("universityGradued")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("universityGraduedGPA")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("employeeID")
                        .IsUnique();

                    b.ToTable("EmployeeEducationInfos");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeePersonalDocumnet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyContract")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("criminalRecordCertificate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("driversLicense")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employeeID")
                        .HasColumnType("int");

                    b.Property<string>("familyIdentityCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("healthReport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobApplication")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("militaryServiceCertificate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("employeeID")
                        .IsUnique();

                    b.ToTable("EmployeePersonalDocumnets");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Concrete.Payroll", b =>
                {
                    b.HasOne("PersonelTracking_4_Entities.Contrete.EmployeeCompanyInfo", "employeeCompanyInfo")
                        .WithMany("payrolls")
                        .HasForeignKey("employeeCompanyInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employeeCompanyInfo");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.Certificate", b =>
                {
                    b.HasOne("PersonelTracking_4_Entities.Contrete.EmployeeEducationInfo", "EmployeeEducationInfo")
                        .WithMany("Certificates")
                        .HasForeignKey("EmployeeEducationInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeEducationInfo");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.DayOf", b =>
                {
                    b.HasOne("PersonelTracking_4_Entities.Contrete.EmployeeCompanyInfo", "employeeCompanyInfo")
                        .WithMany("dayOfs")
                        .HasForeignKey("employeeCompanyInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employeeCompanyInfo");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeeCompanyInfo", b =>
                {
                    b.HasOne("PersonelTracking_4_Entities.Contrete.Employee", "employee")
                        .WithOne("employeeCompanyInfo")
                        .HasForeignKey("PersonelTracking_4_Entities.Contrete.EmployeeCompanyInfo", "employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeeDetail", b =>
                {
                    b.HasOne("PersonelTracking_4_Entities.Contrete.Employee", "employee")
                        .WithOne("employeeDetail")
                        .HasForeignKey("PersonelTracking_4_Entities.Contrete.EmployeeDetail", "employeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeeEducationInfo", b =>
                {
                    b.HasOne("PersonelTracking_4_Entities.Contrete.Employee", "employee")
                        .WithOne("employeeEducationInfo")
                        .HasForeignKey("PersonelTracking_4_Entities.Contrete.EmployeeEducationInfo", "employeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeePersonalDocumnet", b =>
                {
                    b.HasOne("PersonelTracking_4_Entities.Contrete.Employee", "employee")
                        .WithOne("employeePersonalDocumnet")
                        .HasForeignKey("PersonelTracking_4_Entities.Contrete.EmployeePersonalDocumnet", "employeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.Employee", b =>
                {
                    b.Navigation("employeeCompanyInfo")
                        .IsRequired();

                    b.Navigation("employeeDetail")
                        .IsRequired();

                    b.Navigation("employeeEducationInfo")
                        .IsRequired();

                    b.Navigation("employeePersonalDocumnet")
                        .IsRequired();
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeeCompanyInfo", b =>
                {
                    b.Navigation("dayOfs");

                    b.Navigation("payrolls");
                });

            modelBuilder.Entity("PersonelTracking_4_Entities.Contrete.EmployeeEducationInfo", b =>
                {
                    b.Navigation("Certificates");
                });
#pragma warning restore 612, 618
        }
    }
}
