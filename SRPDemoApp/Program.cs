using System;

namespace SRPDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* A demo that follows SRP.*******************");
            Employee robin = new Employee("Robin", "Musau", 6);
            PrintEmployeeDetail(robin);
            PrintEmployeeId(robin);
            PrintSeniority(robin);

            Console.WriteLine("\n**********************************\n");

            Employee rachel = new Employee("Rachel", "Ntumba", 8.9);
            PrintEmployeeDetail(rachel);
            PrintEmployeeId(rachel);
            PrintSeniority(rachel);

            Console.ReadKey();
        }

        private static void PrintSeniority(Employee robin)
        {
            SeniorityChecker seniorityChecker = new SeniorityChecker();
            string seniorLevel = seniorityChecker.CheckSeniority(robin.experienceInYears);
            Console.WriteLine($"This employee is a {seniorLevel} employee.");
        }

        private static void PrintEmployeeId(Employee robin)
        {
            EmployeeIdGenerator idGenerator = new EmployeeIdGenerator();
            string empId = idGenerator.GenerateEmployeedId(robin.empLastName);
            Console.WriteLine($"The employee id: {empId}");
        }

        private static void PrintEmployeeDetail(Employee robin)
        {
            robin.DisplayEmployeeDetail();
        }
    }
}
