using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexiCloudPay.Migrations
{
    /// <inheritdoc />
    public partial class AddColumns4OTSettingonComputeMethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComputeMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    methodcode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    payrate = table.Column<int>(type: "int", nullable: false),
                    roundinterm = table.Column<int>(type: "int", nullable: false),
                    roundfinal = table.Column<int>(type: "int", nullable: false),
                    cycle1 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CutOffStart1 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CutOffEnd1 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    basicfactor1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    epf1 = table.Column<bool>(type: "bit", nullable: false),
                    socso1 = table.Column<bool>(type: "bit", nullable: false),
                    eis1 = table.Column<bool>(type: "bit", nullable: false),
                    tax1 = table.Column<bool>(type: "bit", nullable: false),
                    HRD1 = table.Column<bool>(type: "bit", nullable: false),
                    recal1 = table.Column<bool>(type: "bit", nullable: false),
                    cycle2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CutOffStart2 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CutOffEnd2 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    basicfactor2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    epf2 = table.Column<bool>(type: "bit", nullable: false),
                    socso2 = table.Column<bool>(type: "bit", nullable: false),
                    eis2 = table.Column<bool>(type: "bit", nullable: false),
                    tax2 = table.Column<bool>(type: "bit", nullable: false),
                    HRD2 = table.Column<bool>(type: "bit", nullable: false),
                    recal2 = table.Column<bool>(type: "bit", nullable: false),
                    cycle3 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CutOffStart3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CutOffEnd3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    basicfactor3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    epf3 = table.Column<bool>(type: "bit", nullable: false),
                    socso3 = table.Column<bool>(type: "bit", nullable: false),
                    eis3 = table.Column<bool>(type: "bit", nullable: false),
                    tax3 = table.Column<bool>(type: "bit", nullable: false),
                    HRD3 = table.Column<bool>(type: "bit", nullable: false),
                    recal3 = table.Column<bool>(type: "bit", nullable: false),
                    cycle4 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CutOffStart4 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CutOffEnd4 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    basicfactor4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    epf4 = table.Column<bool>(type: "bit", nullable: false),
                    socso4 = table.Column<bool>(type: "bit", nullable: false),
                    eis4 = table.Column<bool>(type: "bit", nullable: false),
                    tax4 = table.Column<bool>(type: "bit", nullable: false),
                    HRD4 = table.Column<bool>(type: "bit", nullable: false),
                    recal4 = table.Column<bool>(type: "bit", nullable: false),
                    cycle5 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CutOffStart5 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CutOffEnd5 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    basicfactor5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    epf5 = table.Column<bool>(type: "bit", nullable: false),
                    socso5 = table.Column<bool>(type: "bit", nullable: false),
                    eis5 = table.Column<bool>(type: "bit", nullable: false),
                    tax5 = table.Column<bool>(type: "bit", nullable: false),
                    HRD5 = table.Column<bool>(type: "bit", nullable: false),
                    recal5 = table.Column<bool>(type: "bit", nullable: false),
                    IncProrate = table.Column<int>(type: "int", nullable: false),
                    NRProrate = table.Column<int>(type: "int", nullable: false),
                    NegativePayMethod = table.Column<int>(type: "int", nullable: false),
                    RoundORPMEthod = table.Column<int>(type: "int", nullable: false),
                    MaxPayForOT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OT1F1 = table.Column<int>(type: "int", nullable: false),
                    OT1F2 = table.Column<int>(type: "int", nullable: false),
                    OT1F3 = table.Column<int>(type: "int", nullable: false),
                    OT1F4 = table.Column<int>(type: "int", nullable: false),
                    OT1F5 = table.Column<int>(type: "int", nullable: false),
                    OT1RoundMethod = table.Column<int>(type: "int", nullable: false),
                    OT2F1 = table.Column<int>(type: "int", nullable: false),
                    OT2F2 = table.Column<int>(type: "int", nullable: false),
                    OT2F3 = table.Column<int>(type: "int", nullable: false),
                    OT2F4 = table.Column<int>(type: "int", nullable: false),
                    OT2F5 = table.Column<int>(type: "int", nullable: false),
                    OT2RoundMethod = table.Column<int>(type: "int", nullable: false),
                    OT3F1 = table.Column<int>(type: "int", nullable: false),
                    OT3F2 = table.Column<int>(type: "int", nullable: false),
                    OT3F3 = table.Column<int>(type: "int", nullable: false),
                    OT3F4 = table.Column<int>(type: "int", nullable: false),
                    OT3F5 = table.Column<int>(type: "int", nullable: false),
                    OT3RoundMethod = table.Column<int>(type: "int", nullable: false),
                    OT4F1 = table.Column<int>(type: "int", nullable: false),
                    OT4F2 = table.Column<int>(type: "int", nullable: false),
                    OT4F3 = table.Column<int>(type: "int", nullable: false),
                    OT4F4 = table.Column<int>(type: "int", nullable: false),
                    OT4F5 = table.Column<int>(type: "int", nullable: false),
                    OT4RoundMethod = table.Column<int>(type: "int", nullable: false),
                    OT5F1 = table.Column<int>(type: "int", nullable: false),
                    OT5F2 = table.Column<int>(type: "int", nullable: false),
                    OT5F3 = table.Column<int>(type: "int", nullable: false),
                    OT5F4 = table.Column<int>(type: "int", nullable: false),
                    OT5F5 = table.Column<int>(type: "int", nullable: false),
                    OT5RoundMethod = table.Column<int>(type: "int", nullable: false),
                    OT6F1 = table.Column<int>(type: "int", nullable: false),
                    OT6F2 = table.Column<int>(type: "int", nullable: false),
                    OT6F3 = table.Column<int>(type: "int", nullable: false),
                    OT6F4 = table.Column<int>(type: "int", nullable: false),
                    OT6F5 = table.Column<int>(type: "int", nullable: false),
                    OT6RoundMethod = table.Column<int>(type: "int", nullable: false),
                    OT7F1 = table.Column<int>(type: "int", nullable: false),
                    OT7F2 = table.Column<int>(type: "int", nullable: false),
                    OT7F3 = table.Column<int>(type: "int", nullable: false),
                    OT7F4 = table.Column<int>(type: "int", nullable: false),
                    OT7F5 = table.Column<int>(type: "int", nullable: false),
                    OT7RoundMethod = table.Column<int>(type: "int", nullable: false),
                    OT8F1 = table.Column<int>(type: "int", nullable: false),
                    OT8F2 = table.Column<int>(type: "int", nullable: false),
                    OT8F3 = table.Column<int>(type: "int", nullable: false),
                    OT8F4 = table.Column<int>(type: "int", nullable: false),
                    OT8F5 = table.Column<int>(type: "int", nullable: false),
                    OT8RoundMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputeMethod", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputeMethod");
        }
    }
}
