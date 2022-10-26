using Microsoft.EntityFrameworkCore.Migrations;

namespace IS405.Migrations
{
    public partial class initial : Migration
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
                    qualtricsSurveySent = table.Column<bool>(nullable: false),
                    submittedForm = table.Column<bool>(nullable: false),
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
                values: new object[] { "11-222-1234", "Mickey Mouse", "IS-201", "mmouse@gmail.com", null, "8-5", "Mickey", "Male", "08-10-2022", null, false, "Mouse", null, null, false, null, false, null, null, "801-123-4567", "TA", false, "Winter", false, "Hilton", false, null, null, false, 2023 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "byuID", "byuName", "classCode", "email", "emplRecord", "expectedWorkHours", "firstName", "gender", "hireDate", "increaseInputDate", "international", "lastName", "lastPayIncrease", "majorYear", "nameChangeCompleted", "notes", "payGradTuition", "payIncreaseAmount", "payRate", "phone", "positionType", "qualtricsSurveySent", "semester", "submittedForm", "supervisor", "terminated", "terminationDate", "workAuthorizationEmailSent", "workAuthorizationReceived", "year" },
                values: new object[] { "89-161-7523", "Walter White", "IS-413", "heisenberg@gmail.com", null, "8-5", "Walter", "Male", "05-17-2021", null, false, "White", null, null, false, null, false, null, null, "425-555-7711", "TA", false, "Fall", false, "Hilton", true, "12-17-2021", null, false, 2021 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "byuID", "byuName", "classCode", "email", "emplRecord", "expectedWorkHours", "firstName", "gender", "hireDate", "increaseInputDate", "international", "lastName", "lastPayIncrease", "majorYear", "nameChangeCompleted", "notes", "payGradTuition", "payIncreaseAmount", "payRate", "phone", "positionType", "qualtricsSurveySent", "semester", "submittedForm", "supervisor", "terminated", "terminationDate", "workAuthorizationEmailSent", "workAuthorizationReceived", "year" },
                values: new object[] { "45-233-1110", "Elenor Shellstrop", "IS-115", "badplace@gmail.com", null, "12-4", "Elenor", "Female", "01-10-2020", "04-29-2020", false, "Shellstrop", "05-01-2020", null, false, null, false, "$0.67", null, "413-887-9145", "TA", false, "Spring", false, "Burton", false, null, null, false, 2020 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "byuID", "byuName", "classCode", "email", "emplRecord", "expectedWorkHours", "firstName", "gender", "hireDate", "increaseInputDate", "international", "lastName", "lastPayIncrease", "majorYear", "nameChangeCompleted", "notes", "payGradTuition", "payIncreaseAmount", "payRate", "phone", "positionType", "qualtricsSurveySent", "semester", "submittedForm", "supervisor", "terminated", "terminationDate", "workAuthorizationEmailSent", "workAuthorizationReceived", "year" },
                values: new object[] { "22-355-8870", "Elena Gilbert", "IS-403", "vampiresrules@gmail.com", null, "7-11", "Elena", "Female", "07-31-2021", null, false, "Gilbert", null, null, false, null, false, null, null, "685-773-6592", "RA", false, "Fall", false, "Anderson", false, null, null, false, 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
