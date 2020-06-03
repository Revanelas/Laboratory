using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesAndPersons;


namespace Laboratory2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee() {Login="Alfa", Department="IT", Name="Mike Darrah", Password="pa$$w0rd" };
            Employee secondEmployee = new Employee() {Login="Beta", Department="HR", Name="Evangeline Bell", Password="enilegnavE" };
            Employee thirdEmployee = new Employee() {Login="Gamma", Department="PR",Name="John Tyler", Password="xyzQwerty" };
            Employee fourthEmployee = new Employee() {Login="Delta", Department="Marketing", Name="Agnes Wraith", Password="12pass34" };
            Employee lastEmployee = new Employee();

            lastEmployee.AddPerson("Omega", "str0NgpAssw0rd", "David Guider", "IT");


            ArrayList FirstEmployeesList = new ArrayList();
            FirstEmployeesList.Add(firstEmployee);
            FirstEmployeesList.Add(secondEmployee);
            FirstEmployeesList.Add(thirdEmployee);
            FirstEmployeesList.Add(fourthEmployee);
            FirstEmployeesList.Add(lastEmployee);

            foreach (Employee person in FirstEmployeesList)
            {
                Console.WriteLine(person.Login);
            }

            Console.WriteLine("\n");

            List<Employee> SecondEmployeesList = new List<Employee>();
            SecondEmployeesList.Add(firstEmployee);
            SecondEmployeesList.Add(secondEmployee);
            SecondEmployeesList.Add(thirdEmployee);
            SecondEmployeesList.Add(fourthEmployee);
            SecondEmployeesList.Add(lastEmployee);

            foreach (Employee person in SecondEmployeesList)
            {
                Console.WriteLine(person.Password);
            }

            Console.WriteLine("\n\n\n");
            //Zadanie 2: LINQ


            var orderedNames = from employee in SecondEmployeesList
                               orderby employee.Name
                               select employee;

            foreach (var person in orderedNames)
            {
                Console.WriteLine(person.Name.Remove(person.Name.IndexOf(" "),person.Name.Length-person.Name.Substring(0,person.Name.IndexOf(" ")).Length));
            }

            Console.WriteLine("\n");

            RandomString rndPassword = new RandomString();

           foreach (Employee person in SecondEmployeesList)
            {
                person.Password = rndPassword.RandomStrings();
            }

            foreach (Employee person in SecondEmployeesList)
            {
                Console.WriteLine(person.Password);
            }

            Console.WriteLine("\n");

            var itAndHr = SecondEmployeesList.Where(p => p.Department == "IT" || p.Department == "HR");
            foreach (var person in itAndHr)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadKey();
        }
    }
}
