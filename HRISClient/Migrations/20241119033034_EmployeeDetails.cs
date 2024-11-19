using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRISClient.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeDetails : Migration
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
                    EmployeeNo = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseSalary = table.Column<double>(type: "float", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PermanentDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyEmail",
                table: "Employees",
                column: "CompanyEmail",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
