using Aula005.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula005.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {

        }



        public Worker(string name, WorkerLevel level, double baseSalary,Department deptName)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = deptName;
        }

        public void AddContract(HourContract Contract) {

            Contracts.Add(Contract);
        }

        public void RemoveContract(HourContract Contract) {

            Contracts.Remove(Contract);
        }

        public double Income(int Year,int Month) {

            double Sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Data.Year == Year && contract.Data.Month == Month)
                {
                    Sum += contract.Value();
                }
            }

            return Sum;
        }

    }
}
