// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: 20200930003543_UserPasswordAdded.cs
// Created on: 09/29/2020 at 8:35 PM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using Microsoft.EntityFrameworkCore.Migrations;

#endregion

namespace API.Data.Migrations
{
    public partial class UserPasswordAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                "PasswordHash",
                "Users",
                "BLOB",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                "PasswordSalt",
                "Users",
                "BLOB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "PasswordHash",
                "Users");

            migrationBuilder.DropColumn(
                "PasswordSalt",
                "Users");
        }
    }
}