using Microsoft.AspNetCore.Mvc;
using ProjectBL;

namespace ProjectPL.Controllers
{
    public class ApartmentController : Controller
    {
        [HttpGet("/AddOwner")]
        public IActionResult AddOwner(int fno,string name , string pno )
        {
            OwnerCrud.Add(fno, name, pno);

            return View("Owner");
        }
    }
}
