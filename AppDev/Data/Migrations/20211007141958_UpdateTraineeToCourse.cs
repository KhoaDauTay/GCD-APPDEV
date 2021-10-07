using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDev.Data.Migrations
{
    public partial class UpdateTraineeToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignTrainees_Trainers_TrainerId",
                table: "AssignTrainees");

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "AssignTrainees",
                newName: "TraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignTrainees_TrainerId",
                table: "AssignTrainees",
                newName: "IX_AssignTrainees_TraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignTrainees_Trainees_TraineeId",
                table: "AssignTrainees",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "ApplicationUserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignTrainees_Trainees_TraineeId",
                table: "AssignTrainees");

            migrationBuilder.RenameColumn(
                name: "TraineeId",
                table: "AssignTrainees",
                newName: "TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignTrainees_TraineeId",
                table: "AssignTrainees",
                newName: "IX_AssignTrainees_TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignTrainees_Trainers_TrainerId",
                table: "AssignTrainees",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "ApplicationUserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
