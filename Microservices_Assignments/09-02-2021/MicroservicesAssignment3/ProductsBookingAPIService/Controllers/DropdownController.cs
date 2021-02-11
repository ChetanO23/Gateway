using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsBookingAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
