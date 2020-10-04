// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: RegisterDto.cs
// Created on: 09/29/2020 at 10:58 PM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] public string Username { get; set; }
        // [Required] public string KnownAs { get; set; }
        // [Required] public string Gender { get; set; }
        // [Required] public DateTime DateOfBirth { get; set; }
        // [Required] public string City { get; set; }
        // [Required] public string Country { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
        
    }
}