using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexiCloudPay.Migrations
{
    /// <inheritdoc />
    public partial class AddTableEmployeePaySource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmpNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<int>(type: "int", nullable: false),
                    AccessCode = table.Column<int>(type: "int", nullable: false),
                    NoICNew = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NoICOld = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ColorIC = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bloodtype = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<int>(type: "int", nullable: false),
                    Race = table.Column<int>(type: "int", nullable: false),
                    Religion = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<int>(type: "int", nullable: false),
                    NoOfPassport = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ExpiredOfPassport = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phoneno = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ContractDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractExpired = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermitNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PermitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermitExpired = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ORPTable = table.Column<int>(type: "int", nullable: false),
                    Bank = table.Column<int>(type: "int", nullable: false),
                    BankAccout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankIC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaySource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cycle = table.Column<int>(type: "int", nullable: false),
                    empno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    workday = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    daywork = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    allow = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    deduct = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ot10 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ot15 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ot20 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ot30 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    absent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaySource", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "MyEntity");

            migrationBuilder.DropTable(
                name: "PaySource");
        }
    }
}
