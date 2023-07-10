using System;

namespace SRPDemoApp
{
    class EmployeeIdGenerator
    {
        string empId;
        public string GenerateEmployeedId(string empFirstName)
        {
            int random = new System.Random().Next(1000);
            empId = String.Concat(empFirstName[0], random);
            return empId;
        }
    }
}
