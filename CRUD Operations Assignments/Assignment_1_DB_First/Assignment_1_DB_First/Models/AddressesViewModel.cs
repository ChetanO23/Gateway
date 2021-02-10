using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_1_DB_First.Models
{
    public class AddressesViewModel
    {
        public int ID { get; set; }
        public int USER_ID { get; set; }
        public string ADDRESS_TYPE { get; set; }
        public string ADDRESS_VALUE { get; set; }
        public string USER_NAME { get; set; }


    }
}