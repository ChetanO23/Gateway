using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpGet, Route("GetCustomers")]
        public List<string> Get()
        {
            List<string> customer = new List<string>();
            customer.Add("chetan");
            customer.Add("manoj");
            customer.Add("shrikant"); 
            customer.Add("abc");
            customer.Add("xyz");
            
            return customer;
        }

    }
}
