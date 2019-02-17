using Aula005.Entities;
using Aula005.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string DeptName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Worker data: ");
            Console.WriteLine("Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Level(JUNIOR/MID_LEVEL/SENIOR): ");
            WorkerLevel level;  
            Enum.TryParse(Console.ReadLine(), true, out level);
            Console.WriteLine();

            Console.Write("Base Salary");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);



            
            
        }
    }
}
