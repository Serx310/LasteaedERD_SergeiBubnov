uusing Microsoft.EntityFrameworkCore.Migrations;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Migrations
{
    public partial class KindergartenFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EHId",
                table: "Group",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "EatingHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbsenceId",
                table: "Child",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChildId",
                table: "Absence",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EatingHistory_GroupId",
                table: "EatingHistory",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Absence_ChildId",
                table: "Absence",
                column: "ChildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absence_Child_ChildId",
                table: "Absence",
                column: "ChildId",
                principalTable: "Child",
                principalColumn: "ChildId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EatingHistory_Group_GroupId",
                table: "EatingHistory",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absence_Child_ChildId",
                table: "Absence");

            migrationBuilder.DropForeignKey(
                name: "FK_EatingHistory_Group_GroupId",
                table: "EatingHistory");

            migrationBuilder.DropIndex(
                name: "IX_EatingHistory_GroupId",
                table: "EatingHistory");

            migrationBuilder.DropIndex(
                name: "IX_Absence_ChildId",
                table: "Absence");

            migrationBuilder.DropColumn(
                name: "EHId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "EatingHistory");

            migrationBuilder.DropColumn(
                name: "AbsenceId",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Absence");
        }
    }
}
