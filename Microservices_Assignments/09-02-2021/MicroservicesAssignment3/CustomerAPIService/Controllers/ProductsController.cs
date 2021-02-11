using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        [HttpGet, Route("GetProducts")]
        public List<string> Get()
        {
            List<string> product = new List<string>();
            product.Add("apple");
            product.Add("mango");
            product.Add("banana");
            product.Add("leechi");
            product.Add("pineapple");
            return product;
        }
    }
}
