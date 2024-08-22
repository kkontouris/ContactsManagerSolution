using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsManager.Infrastructure.Migrations
{
    public partial class NewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("012107df-862f-4f16-ba94-e5c16886f005"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("28d11936-9466-4a4b-b9c5-2f0a8e0cbde9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("29339209-63f5-492f-8459-754943c74abf"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("2a6d3738-9def-43ac-9279-0310edc7ceca"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("89e5f445-d89f-4e12-94e0-5ad5b235d704"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("a3b9833b-8a4d-43e9-8690-61e08df81a9a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("ac660a73-b0b7-4340-abc1-a914257a6189"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("c03bbe45-9aeb-4d24-99e0-4743016ffce9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("c3abddbd-cf50-41d2-b6c4-cc7d5a750928"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("c6d50a47-f7e6-4482-8be0-4ddfc057fa6e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("cb035f22-e7cf-4907-bd07-91cfee5240f3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("d15c6d9f-70b4-48c5-afd3-e71261f1a9be"));

            migrationBuilder.AlterColumn<string>(
                name: "PersonName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                column: "CountryName",
                value: "France");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"),
                column: "CountryName",
                value: "Greece");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"),
                column: "CountryName",
                value: "Italy");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"),
                column: "CountryName",
                value: "England");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"),
                column: "CountryName",
                value: "Germany");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { new Guid("1adc9579-d0e4-484f-9ee9-73bf4bb98f09"), "New York" },
                    { new Guid("1c6a6c34-2e1c-4cd5-bb2d-502fbd035e25"), "Romania" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "CountryId", "DateOfBirth", "Email", "Gender", "PersonName", "ReceiveNewsLeters" },
                values: new object[,]
                {
                    { new Guid("0abc338f-1af9-4ec0-80c5-a055d10a0a57"), "50467 Holy Cross Crossing", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1995, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ttregona4@stumbleupon.com", "Gender", "Tani", false },
                    { new Guid("13a3114c-058a-4e41-9c79-dc0618d52c40"), "57449 Brown Way", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1983, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "mjarrell6@wisc.edu", "Male", "Maddy", false },
                    { new Guid("74b53d18-1e62-4e3a-b37d-caf0115fef2f"), "97570 Raven Circle", new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), new DateTime(1988, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "mlingfoot5@netvibes.com", "Male", "Mitchael", false },
                    { new Guid("78a7af98-c9ca-4596-b4d1-38e23cd8282c"), "4 Parkside Point", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "mwebsdale0@people.com.cn", "Female", "Marguerite", false },
                    { new Guid("7be19fda-340e-47f6-93fa-456dce95f0b0"), "83187 Merry Drive", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1987, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "asarvar3@dropbox.com", "Male", "Angie", false },
                    { new Guid("9ec160cf-30e9-49c4-877e-f0050e12ea34"), "6 Morningstar Circle", new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ushears1@globo.com", "Female", "Ursa", false },
                    { new Guid("bd47ace5-1975-4554-8408-feb91c2a84b8"), "73 Heath Avenue", new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbowsher2@howstuffworks.com", "Male", "Franchot", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("1adc9579-d0e4-484f-9ee9-73bf4bb98f09"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("1c6a6c34-2e1c-4cd5-bb2d-502fbd035e25"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("0abc338f-1af9-4ec0-80c5-a055d10a0a57"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("13a3114c-058a-4e41-9c79-dc0618d52c40"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("74b53d18-1e62-4e3a-b37d-caf0115fef2f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("78a7af98-c9ca-4596-b4d1-38e23cd8282c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("7be19fda-340e-47f6-93fa-456dce95f0b0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("9ec160cf-30e9-49c4-877e-f0050e12ea34"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("bd47ace5-1975-4554-8408-feb91c2a84b8"));

            migrationBuilder.AlterColumn<string>(
                name: "PersonName",
                table: "Persons",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Persons",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Persons",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Persons",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                column: "CountryName",
                value: "China");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"),
                column: "CountryName",
                value: "Philippines");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"),
                column: "CountryName",
                value: "China");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"),
                column: "CountryName",
                value: "Thailand");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"),
                column: "CountryName",
                value: "Palestinian Territory");

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "CountryId", "DateOfBirth", "Email", "Gender", "PersonName", "ReceiveNewsLeters" },
                values: new object[,]
                {
                    { new Guid("012107df-862f-4f16-ba94-e5c16886f005"), "413 Sachtjen Way", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1990, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "hmosco8@tripod.com", "Male", "Hansiain", false },
                    { new Guid("28d11936-9466-4a4b-b9c5-2f0a8e0cbde9"), "2 Warrior Avenue", new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"), new DateTime(1990, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "mconachya@va.gov", "Female", "Minta", false },
                    { new Guid("29339209-63f5-492f-8459-754943c74abf"), "57449 Brown Way", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1983, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "mjarrell6@wisc.edu", "Male", "Maddy", false },
                    { new Guid("2a6d3738-9def-43ac-9279-0310edc7ceca"), "97570 Raven Circle", new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), new DateTime(1988, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "mlingfoot5@netvibes.com", "Male", "Mitchael", false },
                    { new Guid("89e5f445-d89f-4e12-94e0-5ad5b235d704"), "50467 Holy Cross Crossing", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1995, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ttregona4@stumbleupon.com", "Gender", "Tani", false },
                    { new Guid("a3b9833b-8a4d-43e9-8690-61e08df81a9a"), "9334 Fremont Street", new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "vklussb@nationalgeographic.com", "Female", "Verene", false },
                    { new Guid("ac660a73-b0b7-4340-abc1-a914257a6189"), "4 Stuart Drive", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1998, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "pretchford7@virginia.edu", "Female", "Pegeen", false },
                    { new Guid("c03bbe45-9aeb-4d24-99e0-4743016ffce9"), "4 Parkside Point", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "mwebsdale0@people.com.cn", "Female", "Marguerite", false },
                    { new Guid("c3abddbd-cf50-41d2-b6c4-cc7d5a750928"), "6 Morningstar Circle", new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ushears1@globo.com", "Female", "Ursa", false },
                    { new Guid("c6d50a47-f7e6-4482-8be0-4ddfc057fa6e"), "73 Heath Avenue", new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbowsher2@howstuffworks.com", "Male", "Franchot", false },
                    { new Guid("cb035f22-e7cf-4907-bd07-91cfee5240f3"), "484 Clarendon Court", new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), new DateTime(1997, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "lwoodwing9@wix.com", "Male", "Lombard", false },
                    { new Guid("d15c6d9f-70b4-48c5-afd3-e71261f1a9be"), "83187 Merry Drive", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1987, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "asarvar3@dropbox.com", "Male", "Angie", false }
                });
        }
    }
}
