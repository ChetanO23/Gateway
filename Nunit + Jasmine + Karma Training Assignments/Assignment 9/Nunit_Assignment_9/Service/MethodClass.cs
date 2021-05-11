using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Data;
using Constraint = NUnit.Framework.Constraints.Constraint;

namespace Service
{
    public class MethodClass
    {

        public List<UserData> GetUserData()
        {

            return new List<UserData>
            {
                new UserData { Name = "Chetan", Age = 21, Address = "Maharashtra" },
                new UserData { Name = "Devyani", Age = 19, Address = "Gujarat" },
                new UserData { Name = "Sanjay", Age = 51, Address = "Keral" },
                new UserData { Name = "Vandana", Age = 41, Address = "Goa" },
                new UserData { Name = "Hemal", Age = 22, Address = "Panjab" },
            };

        }
    }
}