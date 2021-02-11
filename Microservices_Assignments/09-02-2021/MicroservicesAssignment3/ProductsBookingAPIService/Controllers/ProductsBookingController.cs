using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsBookingAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsBookingController : Controller
    {
        [HttpGet, Route("GetBookings")]
        public List<string> Get()
        {
            List<string> bookings = new List<string>();
            bookings.Add("chetan - apple");
            bookings.Add("manoj - mango");
            bookings.Add("shrikant - banana");
            bookings.Add("abc - leechi");
            bookings.Add("xyz - pineapple");
            
            return bookings;
        }
    }
}
