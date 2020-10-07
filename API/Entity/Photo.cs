// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: Photo.cs
// Created on: 10/05/2020 at 10:57 PM
// Edited on: 10/05/2020 at 10:57 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entity
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}