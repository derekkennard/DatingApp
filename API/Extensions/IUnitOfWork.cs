// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: IUnitOfWork.cs
// Created on: 10/12/2020 at 11:36 PM
// Edited on: 10/12/2020 at 11:36 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

using System.Threading.Tasks;
using API.Interfaces;

namespace API.Extensions
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}