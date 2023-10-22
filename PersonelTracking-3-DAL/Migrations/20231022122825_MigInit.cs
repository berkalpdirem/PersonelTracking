using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelTracking_3_DAL.Migrations
{
    /// <inheritdoc />
    public partial class MigInit : Migration
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
                    employeeDetailID = table.Column<int>(type: "int", nullable: false),
                    employeePersonalDocumnetID = table.Column<int>(type: "int", nullable: false),
                    employeeEducationInfoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maritalStatus = table.Column<int>(type: "int", nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    birthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    motherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    livingPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "EmployeeEducationInfos");

            migrationBuilder.DropTable(
                name: "EmployeePersonalDocumnets");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
