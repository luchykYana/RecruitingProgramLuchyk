using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitingProgramLuchyk.Migrations
{
    public partial class ForgetPublic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicantId",
                table: "Interviews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "During",
                table: "Interviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InterviewerId",
                table: "Interviews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_ApplicantId",
                table: "Interviews",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_InterviewerId",
                table: "Interviews",
                column: "InterviewerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Applicants_ApplicantId",
                table: "Interviews",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Interviewers_InterviewerId",
                table: "Interviews",
                column: "InterviewerId",
                principalTable: "Interviewers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Applicants_ApplicantId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Interviewers_InterviewerId",
                table: "Interviews");

            migrationBuilder.DropIndex(
                name: "IX_Interviews_ApplicantId",
                table: "Interviews");

            migrationBuilder.DropIndex(
                name: "IX_Interviews_InterviewerId",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "During",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "InterviewerId",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Interviews");
        }
    }
}
