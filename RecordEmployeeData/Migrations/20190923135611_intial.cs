using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordEmployeeData.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeName = table.Column<string>(nullable: true),
                    BirthPlace = table.Column<int>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: true),
                    IDNumber = table.Column<string>(nullable: true),
                    IssuerCode = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: true),
                    Nationality = table.Column<int>(nullable: true),
                    Religion = table.Column<int>(nullable: true),
                    EmployeeAddress = table.Column<string>(nullable: true),
                    SectionCenter = table.Column<int>(nullable: true),
                    Governorate = table.Column<int>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    SocialStatus = table.Column<int>(nullable: true),
                    LastQualifiedCode = table.Column<string>(nullable: true),
                    LastQualifiedDate = table.Column<DateTime>(nullable: true),
                    Specialization = table.Column<int>(nullable: true),
                    JobTitle = table.Column<int>(nullable: true),
                    JobGroup = table.Column<int>(nullable: true),
                    FanaticalDegree = table.Column<int>(nullable: true),
                    AppointmentType = table.Column<int>(nullable: true),
                    DecisionNumber = table.Column<string>(nullable: true),
                    DecisionDate = table.Column<DateTime>(nullable: true),
                    ReceiptDate = table.Column<DateTime>(nullable: true),
                    CentralAdministration = table.Column<int>(nullable: true),
                    SubAdministration = table.Column<int>(nullable: true),
                    SeniorityHistoryDate = table.Column<DateTime>(nullable: true),
                    EmployeeStatus = table.Column<int>(nullable: true),
                    LevelDate = table.Column<DateTime>(nullable: true),
                    CurrentJobDate = table.Column<DateTime>(nullable: true),
                    LastFinancialDisclosure = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
