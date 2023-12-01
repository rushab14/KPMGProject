using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectBL;
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
        [HttpPost("/api/createowner")]
        public IActionResult CreateOwner([FromBody] Owner o)
        {
            OwnerOperations.CreateOwner(o);
            return Ok($"Owner created with {o.Name}");
        }

        [HttpGet("/api/getowners")]
        public IActionResult GetOwner()
        {
            var owners = OwnerOperations.GetPeople();
            return Ok(owners);
        }
        [HttpPost("/api/CreateFacility")]
        public IActionResult CreateFacility([FromForm] Facility f) 
        {
            FacilityOperations.CreateFacility(f);
            return Ok($"Facility is created with {f.FacilityName}");
        }

        [HttpGet("/api/getFacilities")]
        public IActionResult GetFacility()
        {
            var Facilities = FacilityOperations.GetFacilities();
            return Ok(Facilities);
        }

        [HttpPost("/bookFacility")]
        public IActionResult BookFacility(string facname,int flatId )
        {
             FacilityMgmt.BookFacility(facname, flatId);
            return Ok("Facility booked for:" + facname + "for the flat id " + flatId+"on"+DateTime.Now);
        }

        [HttpGet("/SearchbyFName")]
        public IActionResult SearchByFacilityName(string fname)
        {
            var result = FacilityCrud.SearchOne(fname);
                return Ok(result);
        }
        [HttpGet("/SearchByPName")]
        public IActionResult SearchByFlatOwner(string pname)
        {
            var result = OwnerCrud.SearchOne(pname);
            return Ok(result);
        }
        [HttpPost("/freeFacility")]
        public IActionResult FreeFacility(string facname, int flatId)
        {
            FacilityMgmt.FreeFacility(facname, flatId);
            return Ok("Facility freed by:" + facname + "for the flat id " + flatId+ "on"+ DateTime.Now);
        }

    }
}
