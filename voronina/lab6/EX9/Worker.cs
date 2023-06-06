using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9
{
    internal class Worker
    {
        public string FamilyName { get; set; }
        public double[] Salary { get; set; }
        public int DepartmentNumber { get; set; }
        public string Post { get; set; }

        public Worker(string familyName, double[] salary, int departmentNumber, string post)
        {
            FamilyName = familyName;
            Salary = salary;
            DepartmentNumber = departmentNumber;
            Post = post;
        }

        public double GetAverageYearSalary()
        {
            return Salary.Average();
        }
    }
}
