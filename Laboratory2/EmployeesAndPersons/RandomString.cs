using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndPersons
{
    public class RandomString
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();

        public string RandomStrings()
        {
            int length = random.Next(6, 32);
            char[] rnd=new char[length];

            for (int i = 0; i < rnd.Length; i++)
            {
                rnd[i] = chars[random.Next(chars.Length)];
            }

            string solution = new string(rnd);

            return solution;
        }
    }
}
