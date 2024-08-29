using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsManager.Infrastructure.Migrations
{
    public partial class ChangeFluentValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxIdentificationNumber",
                table: "Persons",
                type: "varchar(9)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(9)",
                oldNullable: true,
                oldDefaultValue: "123456789");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxIdentificationNumber",
                table: "Persons",
                type: "varchar(9)",
                nullable: true,
                defaultValue: "123456789",
                oldClrType: typeof(string),
                oldType: "varchar(9)",
                oldNullable: true);
        }
    }
}
