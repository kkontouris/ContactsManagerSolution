using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsManager.Infrastructure.Migrations
{
    public partial class NewSeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                column: "CountryName",
                value: "Belgium");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"),
                column: "CountryName",
                value: "Argentina");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("1adc9579-d0e4-484f-9ee9-73bf4bb98f09"),
                column: "CountryName",
                value: "Colombia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("1c6a6c34-2e1c-4cd5-bb2d-502fbd035e25"),
                column: "CountryName",
                value: "China");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"),
                column: "CountryName",
                value: "Bulgaria");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"),
                column: "CountryName",
                value: "Austria");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"),
                column: "CountryName",
                value: "Brazil");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { new Guid("01005ec7-121a-4d1f-973d-6bfdeb3b7f56"), "Slovenia" },
                    { new Guid("09ef2aee-08f2-454f-a20b-86cec64530bb"), "Sweeden" },
                    { new Guid("0cea258e-be82-44ed-b673-fc257bf8c7df"), "Hungary" },
                    { new Guid("15a46298-67ed-4dce-9509-9e3eeb2f4e4c"), "Uruguay" },
                    { new Guid("1705d418-6b17-482d-abd6-2bf3b2ece5a4"), "Russia" },
                    { new Guid("21cc9df2-76a4-4c8b-bad6-826d812509ce"), "Poland" },
                    { new Guid("36aac634-b449-48e8-b4d3-bf3ca905f7fd"), "United Kingdom" },
                    { new Guid("382bfca7-304f-4ba4-8361-5bf663e5fff8"), "Croatia" },
                    { new Guid("39374b6c-04d0-405c-8ba8-bbdf420d25ae"), "Mexico" },
                    { new Guid("58db45b9-8b47-4171-8678-b21436ed5a41"), "Romania" },
                    { new Guid("5ff91c1a-0054-4605-8be3-46f6bc69c02b"), "Ireland" },
                    { new Guid("606ab180-460f-4d2a-b4bf-260e8d5e07f5"), "Czechia" },
                    { new Guid("67e14d87-9021-43ee-a848-0883ca27b5df"), "Finland" },
                    { new Guid("6df7a76c-8f1f-4238-9261-0af30392d25e"), "Spain" },
                    { new Guid("792bd91e-1fd0-4d76-b2cf-b41982c3efbe"), "New Zeland" },
                    { new Guid("999d162f-90f0-4cd6-b922-ac5f345e7036"), "Greece" },
                    { new Guid("9f1837a1-f292-4201-963a-2c51acaa480b"), "Italy" },
                    { new Guid("a1ae044e-92e6-4b99-819a-d439097546b2"), "France" },
                    { new Guid("a4868117-8ad2-4cf6-971d-62bd0ed3cc92"), "Venezuela" },
                    { new Guid("abdbd6fa-64cb-415f-adf0-b2f8b38fb04c"), "Monaco" },
                    { new Guid("b887bcf4-fd45-492b-9ffc-8a1e17352acb"), "Malta" },
                    { new Guid("c4cf75e9-c4bd-4f88-9a8c-b39793502f33"), "Cyprus" },
                    { new Guid("d62a9029-1f35-4d28-960e-d5c2813a1486"), "North Macedonia" },
                    { new Guid("dd251e52-6f3f-4e4b-9ba4-bc1fbb8b3d33"), "Luxenburg" },
                    { new Guid("e0c52fad-c0d8-4ec1-a791-a5edc4ce9fb2"), "Netherlands" },
                    { new Guid("f0258764-2723-408c-8201-1b0ae8ed084c"), "Germany" },
                    { new Guid("f33c50b8-e595-4e25-84b2-a3f6b86cb410"), "Portogal" },
                    { new Guid("fb154007-565b-4b98-bedd-9e48338b129d"), "Slovakia" },
                    { new Guid("fb2a83ef-d392-47fd-b0a8-40088ad6bc84"), "Turkey" },
                    { new Guid("fbe47559-5c93-4f9f-91d7-340238f2cf64"), "Aigypt" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "CountryId", "DateOfBirth", "Email", "Gender", "PersonName", "ReceiveNewsLeters" },
                values: new object[,]
                {
                    { new Guid("29d9a055-2ad4-44cb-8e7d-861586cb3783"), "50467 Holy Cross Crossing", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1995, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ttregona4@stumbleupon.com", "Gender", "Tani", false },
                    { new Guid("4e4f360a-6ff5-4932-ad5e-6467f85b02e4"), "83187 Merry Drive", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1987, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "asarvar3@dropbox.com", "Male", "Angie", false },
                    { new Guid("5ea9cd8c-7bb8-4a76-b823-781d92156c2a"), "57449 Brown Way", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1983, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "mjarrell6@wisc.edu", "Male", "Maddy", false },
                    { new Guid("a278a62f-5334-440f-9e96-18668da8d613"), "Parkside 54", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "mwebsdale0@people.com.cn", "Female", "Marguerite", false },
                    { new Guid("ff575830-ab31-41d0-b5ec-a3ab360bd1be"), "97570 Raven Circle", new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), new DateTime(1988, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "mlingfoot5@netvibes.com", "Male", "Mitchael", false }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "CountryId", "DateOfBirth", "Email", "Gender", "PersonName", "ReceiveNewsLeters" },
                values: new object[] { new Guid("1fcf80f6-22b2-4024-8680-14f69c85c369"), "73 Heath Avenue", new Guid("a1ae044e-92e6-4b99-819a-d439097546b2"), new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbowsher2@howstuffworks.com", "Male", "Franchot", false });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "CountryId", "DateOfBirth", "Email", "Gender", "PersonName", "ReceiveNewsLeters" },
                values: new object[] { new Guid("7cfa6961-1d7c-4b80-a879-d3da56aff603"), "6 Morningstar Circle", new Guid("1705d418-6b17-482d-abd6-2bf3b2ece5a4"), new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ushears1@globo.com", "Female", "Ursa", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("01005ec7-121a-4d1f-973d-6bfdeb3b7f56"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("09ef2aee-08f2-454f-a20b-86cec64530bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("0cea258e-be82-44ed-b673-fc257bf8c7df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("15a46298-67ed-4dce-9509-9e3eeb2f4e4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("21cc9df2-76a4-4c8b-bad6-826d812509ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("36aac634-b449-48e8-b4d3-bf3ca905f7fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("382bfca7-304f-4ba4-8361-5bf663e5fff8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("39374b6c-04d0-405c-8ba8-bbdf420d25ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("58db45b9-8b47-4171-8678-b21436ed5a41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("5ff91c1a-0054-4605-8be3-46f6bc69c02b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("606ab180-460f-4d2a-b4bf-260e8d5e07f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("67e14d87-9021-43ee-a848-0883ca27b5df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("6df7a76c-8f1f-4238-9261-0af30392d25e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("792bd91e-1fd0-4d76-b2cf-b41982c3efbe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("999d162f-90f0-4cd6-b922-ac5f345e7036"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("9f1837a1-f292-4201-963a-2c51acaa480b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("a4868117-8ad2-4cf6-971d-62bd0ed3cc92"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("abdbd6fa-64cb-415f-adf0-b2f8b38fb04c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("b887bcf4-fd45-492b-9ffc-8a1e17352acb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("c4cf75e9-c4bd-4f88-9a8c-b39793502f33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("d62a9029-1f35-4d28-960e-d5c2813a1486"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("dd251e52-6f3f-4e4b-9ba4-bc1fbb8b3d33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("e0c52fad-c0d8-4ec1-a791-a5edc4ce9fb2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("f0258764-2723-408c-8201-1b0ae8ed084c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("f33c50b8-e595-4e25-84b2-a3f6b86cb410"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("fb154007-565b-4b98-bedd-9e48338b129d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("fb2a83ef-d392-47fd-b0a8-40088ad6bc84"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("fbe47559-5c93-4f9f-91d7-340238f2cf64"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("1fcf80f6-22b2-4024-8680-14f69c85c369"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("29d9a055-2ad4-44cb-8e7d-861586cb3783"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("4e4f360a-6ff5-4932-ad5e-6467f85b02e4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("5ea9cd8c-7bb8-4a76-b823-781d92156c2a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("7cfa6961-1d7c-4b80-a879-d3da56aff603"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("a278a62f-5334-440f-9e96-18668da8d613"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("ff575830-ab31-41d0-b5ec-a3ab360bd1be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("1705d418-6b17-482d-abd6-2bf3b2ece5a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("a1ae044e-92e6-4b99-819a-d439097546b2"));

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
                keyValue: new Guid("1adc9579-d0e4-484f-9ee9-73bf4bb98f09"),
                column: "CountryName",
                value: "New York");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: new Guid("1c6a6c34-2e1c-4cd5-bb2d-502fbd035e25"),
                column: "CountryName",
                value: "Romania");

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
    }
}
