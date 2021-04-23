using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Service
    {
        /// <summary>
        /// For String Array
        /// </summary>
        /// <returns>List of strings</returns>
        public async Task<IEnumerable<string>> GetStringArray()
        {
            IEnumerable<string> someStrings = new[] { "abc", "cat", "bad", "hat" };

            await Task.Delay(100);

            return someStrings;
        }

        /// <summary>
        /// For get users data
        /// </summary>
        /// <returns>List of the users data</returns>
        public async Task<IEnumerable<User>> GetUsersData()
        {
            User[] users = new User[] {
                new User{ Id = 1, Name = "Chetan", Email = "chetan.more@gmail.com", Address = "Surat"},
                new User{ Id = 2, Name = "Darshan", Email = "darshan.kava@gmail.com", Address = "Junagadha"},
                new User{ Id = 3, Name = "Vishal", Email = "vishal.patel@gmail.com", Address = null},
            };

            await Task.Delay(100);

            return users;
        }

        /// <summary>
        /// for generate table of given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>array of int</returns>
        public int[] GetTable(int number)
        {
            int[] table = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                table[i] = (i + 1) * number;
            }
            return table;
        }

        /// <summary>
        /// For Get Name
        /// </summary>
        /// <returns>name</returns>
        public string GetName()
        {
            return "chetan more";
        }

        /// <summary>
        /// For Get Submission date
        /// </summary>
        /// <returns>submission date</returns>
        public DateTime GetSubmissionDate()
        {
            return new DateTime(2021, 04, 23);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
