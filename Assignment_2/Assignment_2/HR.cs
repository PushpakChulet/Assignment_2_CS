using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class HR : Employee
    {
        public HR(int id, string name, string des, int sal, int exp, DateTime jd) : base(id, name, des, sal, exp, jd)
        {
        }

        public override int Salary()
        {
            return GetSal() + (GetExp() * 1000);
        }
    }
}
