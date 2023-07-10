using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemoApp
{
    class Employee
    {
        public string empFirstName, empLastName;
        public double experienceInYears;

        public Employee(string firstName, string lastName, double experience)
        {
            this.empFirstName = firstName;
            this.empLastName = lastName;
            this.experienceInYears = experience;

        }
        public void DisplayEmployeeDetail()
        {
            Console.WriteLine($"The employee name: {empLastName}, {empFirstName}");
            Console.WriteLine($"This employee has {experienceInYears} years of experience");
        }
    }
}
