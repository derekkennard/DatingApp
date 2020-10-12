// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: AutoMapperProfiles.cs
// Created on: 10/06/2020 at 10:44 PM
// Edited on: 10/06/2020 at 11:13 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using System.Linq;
using API.DTOs;
using API.Entity;
using API.Extensions;
using AutoMapper;

#endregion

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(dest => dest.PhotoUrl,
                    opt => opt.MapFrom(src =>
                        src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt 
                    => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>();
        }
    }
}