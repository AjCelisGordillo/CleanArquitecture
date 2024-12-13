using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Identity.Migrations
{
    public partial class updateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8",
                column: "ConcurrencyStamp",
                value: "1db4d006-1bad-42d8-8496-43bb22740488");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63",
                column: "ConcurrencyStamp",
                value: "fdcd1822-9719-4706-bd5f-0c74c3607631");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "294d249b-9b57-48c1-9689-11a91abb6447",
                columns: new[] { "Apellidos", "ConcurrencyStamp", "Email", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Celis", "d01bd741-ff5f-4fce-ae1a-b0846b200782", "celistony@yahoo.com", "Alvaro", "celistony@yahoo.com", "alvarocelis", "AQAAAAEAACcQAAAAEKbaEumDPg3EhqPYSNrxh4hR+kA2x94ulS+ZtoNV/F4AbXax4SrjXLvEPeacjsn/Qg==", "80b94064-fc89-4184-9962-51139e68513e", "alvarocelis" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76024d04-7e92-4b20-8cee-a6b3f5baebc7", "AQAAAAEAACcQAAAAEO34xrQwwBVAdEvmtuf3zjxavzW5tyRs9k6tyYWwuvFUboGLQ5Qwx3Ckw72OkS2IEg==", "5246faf4-9c09-44f6-bd44-7ec813272f5c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8",
                column: "ConcurrencyStamp",
                value: "af66e885-a884-4487-8cf1-193bb3d7246b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63",
                column: "ConcurrencyStamp",
                value: "476abfdf-9007-429e-ad9c-41e5e464f13c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "294d249b-9b57-48c1-9689-11a91abb6447",
                columns: new[] { "Apellidos", "ConcurrencyStamp", "Email", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Perez", "24f6e7bf-1fb8-471a-a80c-9a5548c7ac37", "juanperez@locahost.com", "Juan", "juanperez@locahost.com", "juanperez", "AQAAAAEAACcQAAAAEPoY1NL8nfyIDPWjpv7Qsvt/GmltN5fvLoz3LEdB8EnSLJrX2C7F4typ4u6B1Jo18A==", "4bdfd5da-f264-493c-b718-662ab0415459", "juanperez" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e53003f-72cd-44ef-a53c-19a30ed0aa15", "AQAAAAEAACcQAAAAENWtdrn6GOb1rjLWPIwP2qHmJR+FPwXhAKlpL8c7WnhrHwR19aE4kGV2B04r+NAelQ==", "ba36f476-a51b-42b9-ae3e-f9d56a02cec3" });
        }
    }
}
