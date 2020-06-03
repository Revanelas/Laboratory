using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndPersons
{
    public class Employee : Person
    {
        private string password;

        new public string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 6)
                {
                    password = value;
                }
                else
                {
                    throw new System.ArgumentException("Password is too short. Min. 6 characters are required", "Password");
                };
            }
        }


        public string Department { get; set; }


        public void AddPerson(string login, string password, string name, string department)
        {
            this.Login = login;
            this.Password = password;
            this.Name = name;
            this.Department = department;
        }
    }
}
