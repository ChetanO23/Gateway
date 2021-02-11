using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.HttpAggregator.CustomAttribute;
using Web.HttpAggregator.Util;

namespace Web.HttpAggregator.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class DropdownController : ControllerBase
    {
        [RateLimit(Name = "Limit Request", Seconds = 5)]

        public async Task<List<string>> Get()
        {
            var customer = await HttpCall.GetRequest<List<string>>("https://localhost:44394/Dropdown/GetCustomers");
            var product = await HttpCall.GetRequest<List<string>>("https://localhost:44394/Dropdown/GetProducts");
            customer.AddRange(product);
            return customer;
        }

    }
}
