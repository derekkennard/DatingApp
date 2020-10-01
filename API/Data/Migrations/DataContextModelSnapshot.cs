// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: DataContextModelSnapshot.cs
// Created on: 09/28/2020 at 12:30 PM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#endregion

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    internal class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("API.Entity.AppUser", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<byte[]>("PasswordHash")
                    .HasColumnType("BLOB");

                b.Property<byte[]>("PasswordSalt")
                    .HasColumnType("BLOB");

                b.Property<string>("UserName")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Users");
            });
#pragma warning restore 612, 618
        }
    }
}