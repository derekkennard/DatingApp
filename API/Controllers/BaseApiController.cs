// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: BaseApiController.cs
// Created on: 09/29/2020 at 8:39 PM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using Microsoft.AspNetCore.Mvc;

#endregion

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
    }
}