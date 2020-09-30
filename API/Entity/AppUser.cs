// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: AppUser.cs
// Created on: 09/28/2020 at 11:09 AM
// Edited on: 09/28/2020 at 12:52 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

namespace API.Entity
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash {get;set;}
        public byte[] PasswordSalt { get; set; }

    }
}