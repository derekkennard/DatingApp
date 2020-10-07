// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: DateTimeExtensions.cs
// Created on: 10/05/2020 at 11:01 PM
// Edited on: 10/05/2020 at 11:01 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}