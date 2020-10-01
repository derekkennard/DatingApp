// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: IdentityServiceExtensions.cs
// Created on: 09/30/2020 at 12:36 AM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

#endregion

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"])),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            return services;
        }
    }
}