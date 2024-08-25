using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsManager.Infrastructure.Migrations
{
    public partial class TaxIdentificationNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "CountryId", "DateOfBirth", "Email", "Gender", "PersonName", "ReceiveNewsLeters", "TaxIdentificationNumber" },
                values: new object[,]
                {
                    { new Guid("04a15249-2c78-4d40-b827-02c45f51d906"), "97570 Raven Circle", new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), new DateTime(1988, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "mlingfoot5@netvibes.com", "Male", "Mitchael", false, "156950496" },
                    { new Guid("72ac986c-3c9b-41dd-82f1-63e2939cbc66"), "57449 Brown Way", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1983, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "mjarrell6@wisc.edu", "Male", "Maddy", false, "156950497" },
                    { new Guid("788ed820-a81c-49a7-9727-e0f162e2ddcb"), "50467 Holy Cross Crossing", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1995, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ttregona4@stumbleupon.com", "Gender", "Tani", false, "156950495" },
                    { new Guid("8bb39878-0fcc-498b-ac8a-1fdd58862c3b"), "73 Heath Avenue", new Guid("a1ae044e-92e6-4b99-819a-d439097546b2"), new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbowsher2@howstuffworks.com", "Male", "Franchot", false, "156950493" },
                    { new Guid("9a9e6f41-31f8-4474-8d99-886c36331e04"), "6 Morningstar Circle", new Guid("1705d418-6b17-482d-abd6-2bf3b2ece5a4"), new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ushears1@globo.com", "Female", "Ursa", false, "156950491" },
                    { new Guid("af07f91f-8631-4bf5-a9cf-22fcac279abe"), "83187 Merry Drive", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1987, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "asarvar3@dropbox.com", "Male", "Angie", false, "156950494" },
                    { new Guid("fc11e02d-80d9-4a0b-95f1-ca53cd4f86d4"), "Parkside 54", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "mwebsdale0@people.com.cn", "Female", "Marguerite", false, "156950492" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("04a15249-2c78-4d40-b827-02c45f51d906"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("72ac986c-3c9b-41dd-82f1-63e2939cbc66"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("788ed820-a81c-49a7-9727-e0f162e2ddcb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("8bb39878-0fcc-498b-ac8a-1fdd58862c3b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("9a9e6f41-31f8-4474-8d99-886c36331e04"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("af07f91f-8631-4bf5-a9cf-22fcac279abe"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("fc11e02d-80d9-4a0b-95f1-ca53cd4f86d4"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "CountryId", "DateOfBirth", "Email", "Gender", "PersonName", "ReceiveNewsLeters" },
                values: new object[,]
                {
                    { new Guid("1fcf80f6-22b2-4024-8680-14f69c85c369"), "73 Heath Avenue", new Guid("a1ae044e-92e6-4b99-819a-d439097546b2"), new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbowsher2@howstuffworks.com", "Male", "Franchot", false },
                    { new Guid("29d9a055-2ad4-44cb-8e7d-861586cb3783"), "50467 Holy Cross Crossing", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1995, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ttregona4@stumbleupon.com", "Gender", "Tani", false },
                    { new Guid("4e4f360a-6ff5-4932-ad5e-6467f85b02e4"), "83187 Merry Drive", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1987, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "asarvar3@dropbox.com", "Male", "Angie", false },
                    { new Guid("5ea9cd8c-7bb8-4a76-b823-781d92156c2a"), "57449 Brown Way", new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), new DateTime(1983, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "mjarrell6@wisc.edu", "Male", "Maddy", false },
                    { new Guid("7cfa6961-1d7c-4b80-a879-d3da56aff603"), "6 Morningstar Circle", new Guid("1705d418-6b17-482d-abd6-2bf3b2ece5a4"), new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ushears1@globo.com", "Female", "Ursa", false },
                    { new Guid("a278a62f-5334-440f-9e96-18668da8d613"), "Parkside 54", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "mwebsdale0@people.com.cn", "Female", "Marguerite", false },
                    { new Guid("ff575830-ab31-41d0-b5ec-a3ab360bd1be"), "97570 Raven Circle", new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), new DateTime(1988, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "mlingfoot5@netvibes.com", "Male", "Mitchael", false }
                });
        }
    }
}
