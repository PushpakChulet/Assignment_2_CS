using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
                Employee emp_1 = new HR(007, "Reeves", "developer", 8000, 4, DateTime.Parse("26/11/2016"));
                Console.WriteLine(emp_1.Salary());

                Employee emp_2 = new Developer(009, "Keanu", "developer", 8000, 5, DateTime.Parse("11/09/2015"));
                Console.WriteLine(emp_2.Salary());
        }
    }
}
