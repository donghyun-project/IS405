using Microsoft.EntityFrameworkCore.Migrations;

namespace IS405.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    byuID = table.Column<string>(nullable: false),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    international = table.Column<bool>(nullable: false),
                    gender = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    expectedWorkHours = table.Column<string>(nullable: true),
                    semester = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    phone = table.Column<string>(nullable: true),
                    positionType = table.Column<string>(nullable: true),
                    classCode = table.Column<string>(nullable: true),
                    emplRecord = table.Column<string>(nullable: true),
                    supervisor = table.Column<string>(nullable: true),
                    hireDate = table.Column<string>(nullable: true),
                    payRate = table.Column<string>(nullable: true),
                    lastPayIncrease = table.Column<string>(nullable: true),
                    payIncreaseAmount = table.Column<string>(nullable: true),
                    increaseInputDate = table.Column<string>(nullable: true),
                    majorYear = table.Column<string>(nullable: true),
                    payGradTuition = table.Column<bool>(nullable: false),
                    nameChangeCompleted = table.Column<bool>(nullable: false),
                    notes = table.Column<string>(nullable: true),
                    terminated = table.Column<bool>(nullable: false),
                    terminationDate = table.Column<string>(nullable: true),
                    qualtricsSurveySent = table.Column<string>(nullable: true),
                    submittedForm = table.Column<string>(nullable: true),
                    workAuthorizationReceived = table.Column<bool>(nullable: false),
                    workAuthorizationEmailSent = table.Column<string>(nullable: true),
                    byuName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.byuID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "byuID", "byuName", "classCode", "email", "emplRecord", "expectedWorkHours", "firstName", "gender", "hireDate", "increaseInputDate", "international", "lastName", "lastPayIncrease", "majorYear", "nameChangeCompleted", "notes", "payGradTuition", "payIncreaseAmount", "payRate", "phone", "positionType", "qualtricsSurveySent", "semester", "submittedForm", "supervisor", "terminated", "terminationDate", "workAuthorizationEmailSent", "workAuthorizationReceived", "year" },
                values: new object[] { "11-222-1234", "Mickey Mouse", "IS-201", "mmouse@gmail.com", null, "8-5", "Mickey", "Male", "08-12-2022", null, false, "Mouse", null, null, false, null, false, null, null, "801-123-4567", "TA", null, "Winter", null, "Hilton", false, null, null, false, 2023 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
