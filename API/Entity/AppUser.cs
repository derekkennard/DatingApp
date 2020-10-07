// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: AppUser.cs
// Created on: 09/28/2020 at 11:09 AM
// Edited on: 10/05/2020 at 10:52 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using System;
using System.Collections;
using System.Collections.Generic;
using API.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#endregion

namespace API.Entity
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }

        // public int GetAge()
        // {
        //     return DateOfBirth.CalculateAge();
        // }
    }
}