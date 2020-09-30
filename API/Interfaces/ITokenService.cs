// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: TokenService.cs
// Created on: 09/29/2020 at 11:53 PM
// Edited on: 09/29/2020 at 11:53 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

using API.Entity;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}