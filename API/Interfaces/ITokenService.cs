// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: ITokenService.cs
// Created on: 09/29/2020 at 11:53 PM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using API.Entity;

#endregion

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}