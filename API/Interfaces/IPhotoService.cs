// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: IPhotoService.cs
// Created on: 10/12/2020 at 10:44 PM
// Edited on: 10/12/2020 at 10:44 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace API.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
        
    }
}