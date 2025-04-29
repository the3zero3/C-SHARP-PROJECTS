using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiates a new Employee object
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            // Calls the SayName() method from the Employee object
            employee.SayName();
            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
