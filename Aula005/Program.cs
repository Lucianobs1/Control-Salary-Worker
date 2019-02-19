using ControlWorker.Entities;
using ControlWorker.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ControlWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string DeptName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Worker data: ");
            Console.WriteLine();

            Console.WriteLine("Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Level(JUNIOR/MID_LEVEL/SENIOR): ");
            WorkerLevel level;
            Enum.TryParse(Console.ReadLine(), true, out level);
            Console.WriteLine();

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(DeptName);
            Worker worker = new Worker(Name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter #{i} Contract data: ");
                Console.Write("Date (DD/MM/YYYY) ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Preace per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.WriteLine("Duration (hours): ");

                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calcule income (MM/YYYY)");

            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departmente: " + worker.Department.Nome);
            Console.WriteLine("income for " + monthAndYear + ": " + worker.Income(year,month));

            Console.ReadLine();
            
        }
    }
}
