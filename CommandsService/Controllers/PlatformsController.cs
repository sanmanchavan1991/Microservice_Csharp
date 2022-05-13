using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }
        [HttpPost]
        public ActionResult TestInBoundConnection()
        {
            Console.WriteLine("==>InBound Post c# service");
            return Ok("InBound test platform controller");
        }
    }
}