using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexiCloudPay.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnintoEmployee2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Employee",
                newName: "EPFNo");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employee",
                newName: "YOSMethod");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AutoDeduct",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Bank2",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BankAccount2",
                table: "Employee",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankIC2",
                table: "Employee",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Branch",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Charge",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComputeMethod",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CostCenter",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "CreditedAlternateBank",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Division",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "EIS",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EISReference",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EISTable",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "EPF",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EPFIC",
                table: "Employee",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EPFReference",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EPFTable",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EisNo",
                table: "Employee",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeType",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HRD",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "HolidayTable",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Job",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "LastBasic",
                table: "Employee",
                type: "decimal(2,2)",
                precision: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "LeaveTable",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Line",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PayMode",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Employee",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Project",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "SOCSO",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SOCSOIC",
                table: "Employee",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SOCSOReference",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SOCSOTable",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Scale",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Section",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftGroup",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SocsoNo",
                table: "Employee",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TAX",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TaxBranch",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TaxByEmployee",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TaxNo",
                table: "Employee",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxReference",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxTable",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutoDeduct",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Bank2",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "BankAccount2",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "BankIC2",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Charge",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ComputeMethod",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CostCenter",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CreditedAlternateBank",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Division",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EIS",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EISReference",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EISTable",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EPF",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EPFIC",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EPFReference",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EPFTable",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EisNo",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeType",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HRD",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HolidayTable",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "LastBasic",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "LeaveTable",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Line",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PayMode",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Project",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SOCSO",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SOCSOIC",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SOCSOReference",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SOCSOTable",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Scale",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ShiftGroup",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SocsoNo",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TAX",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TaxBranch",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TaxByEmployee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TaxNo",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TaxReference",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TaxTable",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "YOSMethod",
                table: "Employee",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "EPFNo",
                table: "Employee",
                newName: "Phone");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
