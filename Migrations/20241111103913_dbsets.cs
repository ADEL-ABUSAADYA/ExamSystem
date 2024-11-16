using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class dbsets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestion_Exams_ExamID",
                table: "ExamQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestion_Question_QuestionID",
                table: "ExamQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourse_Courses_CourseID",
                table: "InstructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourse_Instructor_InstructorID",
                table: "InstructorCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamQuestion",
                table: "ExamQuestion");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "InstructorCourse",
                newName: "InstructorsCourse");

            migrationBuilder.RenameTable(
                name: "ExamQuestion",
                newName: "ExamQuestions");

            migrationBuilder.RenameIndex(
                name: "IX_InstructorCourse_InstructorID",
                table: "InstructorsCourse",
                newName: "IX_InstructorsCourse_InstructorID");

            migrationBuilder.RenameIndex(
                name: "IX_InstructorCourse_CourseID",
                table: "InstructorsCourse",
                newName: "IX_InstructorsCourse_CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_ExamQuestion_QuestionID",
                table: "ExamQuestions",
                newName: "IX_ExamQuestions_QuestionID");

            migrationBuilder.RenameIndex(
                name: "IX_ExamQuestion_ExamID",
                table: "ExamQuestions",
                newName: "IX_ExamQuestions_ExamID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorsCourse",
                table: "InstructorsCourse",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamQuestions",
                table: "ExamQuestions",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Exams_ExamID",
                table: "ExamQuestions",
                column: "ExamID",
                principalTable: "Exams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Questions_QuestionID",
                table: "ExamQuestions",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorsCourse_Courses_CourseID",
                table: "InstructorsCourse",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorsCourse_Instructor_InstructorID",
                table: "InstructorsCourse",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Exams_ExamID",
                table: "ExamQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Questions_QuestionID",
                table: "ExamQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorsCourse_Courses_CourseID",
                table: "InstructorsCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorsCourse_Instructor_InstructorID",
                table: "InstructorsCourse");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorsCourse",
                table: "InstructorsCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamQuestions",
                table: "ExamQuestions");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "InstructorsCourse",
                newName: "InstructorCourse");

            migrationBuilder.RenameTable(
                name: "ExamQuestions",
                newName: "ExamQuestion");

            migrationBuilder.RenameIndex(
                name: "IX_InstructorsCourse_InstructorID",
                table: "InstructorCourse",
                newName: "IX_InstructorCourse_InstructorID");

            migrationBuilder.RenameIndex(
                name: "IX_InstructorsCourse_CourseID",
                table: "InstructorCourse",
                newName: "IX_InstructorCourse_CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_ExamQuestions_QuestionID",
                table: "ExamQuestion",
                newName: "IX_ExamQuestion_QuestionID");

            migrationBuilder.RenameIndex(
                name: "IX_ExamQuestions_ExamID",
                table: "ExamQuestion",
                newName: "IX_ExamQuestion_ExamID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamQuestion",
                table: "ExamQuestion",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestion_Exams_ExamID",
                table: "ExamQuestion",
                column: "ExamID",
                principalTable: "Exams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestion_Question_QuestionID",
                table: "ExamQuestion",
                column: "QuestionID",
                principalTable: "Question",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourse_Courses_CourseID",
                table: "InstructorCourse",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourse_Instructor_InstructorID",
                table: "InstructorCourse",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
