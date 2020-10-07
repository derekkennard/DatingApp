// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: PhotoDto.cs
// Created on: 10/06/2020 at 10:41 PM
// Edited on: 10/06/2020 at 10:41 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

namespace API.DTOs
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
    }
}