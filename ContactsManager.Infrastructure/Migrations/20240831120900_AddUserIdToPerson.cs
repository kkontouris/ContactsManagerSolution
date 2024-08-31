using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsManager.Infrastructure.Migrations
{
    public partial class AddUserIdToPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonName",
                table: "AspNetUsers",
                newName: "ApplicationUserName");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable:true);

            // Example: Set a specific UserId for all existing persons
            // Replace 'SOME_USER_ID' with the actual UserId you want to set
            migrationBuilder.Sql(@"
                UPDATE Persons
                SET UserId = (SELECT TOP 1 Id FROM AspNetUsers)
                WHERE UserId IS NULL;
            ");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_UserId",
                table: "Persons",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AspNetUsers_UserId",
                table: "Persons",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            // Optionally: After updating, make the UserId column NOT NULL
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AspNetUsers_UserId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_UserId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserName",
                table: "AspNetUsers",
                newName: "PersonName");
        }
    }
}
