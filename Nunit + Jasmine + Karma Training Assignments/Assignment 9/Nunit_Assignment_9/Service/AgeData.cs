using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class AgeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public virtual List<AgeData> DataUsers()
        {
            List<AgeData> ageData = new List<AgeData>() {
                new AgeData { Name = "Chetan", Age = 21, Address = "Maharashtra" },
                new AgeData { Name = "Devyani", Age = 19, Address = "Gujarat" },
                new AgeData { Name = "Sanjay", Age = 51, Address = "Keral" },
                new AgeData { Name = "Vandana", Age = 41, Address = "Goa" },
                new AgeData { Name = "Hemal", Age = 22, Address = "Panjab" },

        };
            return ageData;
        }

    }
}
