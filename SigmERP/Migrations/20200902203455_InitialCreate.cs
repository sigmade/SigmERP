using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SigmERP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Person",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        Name = table.Column<string>(nullable: true),
            //        TaxNumber = table.Column<string>(nullable: true),
            //        SocNumber = table.Column<string>(nullable: true),
            //        DateBirth = table.Column<DateTime>(nullable: false),
            //        Address = table.Column<string>(nullable: true),
            //        TypeDocument = table.Column<string>(nullable: true),
            //        SeriesDoc = table.Column<string>(nullable: true),
            //        NumDoc = table.Column<string>(nullable: true),
            //        DateDoc = table.Column<DateTime>(nullable: false),
            //        Authority = table.Column<string>(nullable: true),
            //        AuthorityCode = table.Column<string>(nullable: true),
            //        Sex = table.Column<string>(nullable: true),
            //        Email = table.Column<string>(nullable: true),
            //        Phone = table.Column<string>(nullable: true),
            //        BirthPlace = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Person", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Roles",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Roles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Employee",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        PersonId = table.Column<string>(nullable: true),
            //        StartDate = table.Column<DateTime>(nullable: false),
            //        ExpirationDate = table.Column<DateTime>(nullable: false),
            //        WorkplaceId = table.Column<string>(nullable: true),
            //        Rate = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employee", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Employee_Person_PersonId",
            //            column: x => x.PersonId,
            //            principalTable: "Person",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Email = table.Column<string>(nullable: true),
            //        Password = table.Column<string>(nullable: true),
            //        RoleId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Users_Roles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "Roles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.InsertData(
            //    table: "Roles",
            //    columns: new[] { "Id", "Name" },
            //    values: new object[] { 1, "admin" });

            //migrationBuilder.InsertData(
            //    table: "Roles",
            //    columns: new[] { "Id", "Name" },
            //    values: new object[] { 2, "user" });

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "Email", "Password", "RoleId" },
            //    values: new object[] { 1, "admin@mail.ru", "123456", 1 });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Employee_PersonId",
            //    table: "Employee",
            //    column: "PersonId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_RoleId",
            //    table: "Users",
            //    column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
