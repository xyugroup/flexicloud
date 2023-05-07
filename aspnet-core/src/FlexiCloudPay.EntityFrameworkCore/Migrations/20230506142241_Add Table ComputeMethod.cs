using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexiCloudPay.Migrations
{
    /// <inheritdoc />
    public partial class AddTableComputeMethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GenralSetup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayrollStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenralSetup", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenralSetup");
        }
    }
}
