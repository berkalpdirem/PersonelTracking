using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelTracking_3_DAL.Migrations
{
    /// <inheritdoc />
    public partial class MigDbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tcNo = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataStatus = table.Column<int>(type: "int", nullable: false),
                    employeeDetailID = table.Column<int>(type: "int", nullable: false),
                    employeePersonalDocumnetID = table.Column<int>(type: "int", nullable: false),
                    employeeEducationInfoID = table.Column<int>(type: "int", nullable: false),
                    employeeCompanyInfoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCompanyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeeStatus = table.Column<int>(type: "int", nullable: false),
                    unitOfWork = table.Column<int>(type: "int", nullable: false),
                    seniority = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: false),
                    dayOfCountRightYearly = table.Column<int>(type: "int", nullable: false),
                    dayOfCountRightCurrent = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCompanyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeCompanyInfos_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maritalStatus = table.Column<int>(type: "int", nullable: false),
                    livingCity = table.Column<int>(type: "int", nullable: false),
                    birthCity = table.Column<int>(type: "int", nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    motherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEducationInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    highSchoolGradued = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    highSchoolGraduedGPA = table.Column<int>(type: "int", nullable: false),
                    universityGradued = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    universityGraduedGPA = table.Column<int>(type: "int", nullable: false),
                    employeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEducationInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeEducationInfos_Employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePersonalDocumnets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    healthReport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criminalRecordCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    driversLicense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    companyContract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobApplication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    familyIdentityCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    militaryServiceCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePersonalDocumnets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePersonalDocumnets_Employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayOfs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dayOfStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dayOfLenghtByDay = table.Column<int>(type: "int", nullable: false),
                    dayOfEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeeCompanyInfoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOfs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayOfs_EmployeeCompanyInfos_employeeCompanyInfoID",
                        column: x => x.employeeCompanyInfoID,
                        principalTable: "EmployeeCompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payrolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    netSalaryAmount = table.Column<int>(type: "int", nullable: false),
                    depositDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeeCompanyInfoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payrolls_EmployeeCompanyInfos_employeeCompanyInfoID",
                        column: x => x.employeeCompanyInfoID,
                        principalTable: "EmployeeCompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeEducationInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_EmployeeEducationInfos_EmployeeEducationInfoId",
                        column: x => x.EmployeeEducationInfoId,
                        principalTable: "EmployeeEducationInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_EmployeeEducationInfoId",
                table: "Certificates",
                column: "EmployeeEducationInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DayOfs_employeeCompanyInfoID",
                table: "DayOfs",
                column: "employeeCompanyInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCompanyInfos_employeeId",
                table: "EmployeeCompanyInfos",
                column: "employeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_employeeID",
                table: "EmployeeDetails",
                column: "employeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducationInfos_employeeID",
                table: "EmployeeEducationInfos",
                column: "employeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePersonalDocumnets_employeeID",
                table: "EmployeePersonalDocumnets",
                column: "employeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payrolls_employeeCompanyInfoID",
                table: "Payrolls",
                column: "employeeCompanyInfoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "DayOfs");

            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "EmployeePersonalDocumnets");

            migrationBuilder.DropTable(
                name: "Payrolls");

            migrationBuilder.DropTable(
                name: "EmployeeEducationInfos");

            migrationBuilder.DropTable(
                name: "EmployeeCompanyInfos");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
