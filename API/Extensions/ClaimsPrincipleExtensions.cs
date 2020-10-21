// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: ClaimsPrincipleExtensions.cs
// Created on: 10/12/2020 at 10:59 PM
// Edited on: 10/12/2020 at 10:59 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}