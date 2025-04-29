using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Inherits the Person class
    public class Employee : Person
    {
        // Overrides the SayName() method from the Person class
        public override void SayName()
        {
            // Writes the employee's name to the console
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
