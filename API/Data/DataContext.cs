// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: DataContext.cs
// Created on: 09/28/2020 at 11:26 AM
// Edited on: 09/28/2020 at 12:52 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using API.Entity;
using Microsoft.EntityFrameworkCore;

#endregion

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}