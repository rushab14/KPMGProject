using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDAL;
using ProjectWeb.Models;
using System;
using Owner = ProjectDAL.Owner;

namespace ProjectWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AptController : ControllerBase
    {
        [HttpPost("/api/create")]
        public IActionResult CreateOwner([FromBody] Owner o)
        {
            OwnerOperations.CreateOwner(o);
            return Ok($"Owner created with {o.Name}");
        }

        [HttpGet("/api/get")]
        public IActionResult GetOwner()
        {
            var owners = OwnerOperations.GetPeople();
            return Ok(owners);
        }
    }
}
