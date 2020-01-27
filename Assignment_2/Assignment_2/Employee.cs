using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public abstract class Employee
    {
        private int Id;
        private string Name;
        private string Designation;
        private int Base_Sal;
        private int Exp;
        private DateTime Joiningdate;

        public Employee(int id, string name, string des, int sal, int exp, DateTime joindate)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = des;
            this.Base_Sal = sal;
            this.Exp = exp;
            this.Joiningdate = joindate;
        }

        public int GetSal()
        {
            return this.Base_Sal;
        }

        public int GetExp()
        {
            return this.Exp;
        }

        public abstract int Salary();

    }
}
