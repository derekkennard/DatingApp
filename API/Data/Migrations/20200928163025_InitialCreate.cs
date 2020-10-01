// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: 20200928163025_InitialCreate.cs
// Created on: 09/28/2020 at 12:30 PM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using Microsoft.EntityFrameworkCore.Migrations;

#endregion

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Users",
                table => new
                {
                    Id = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Users", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Users");
        }
    }
}