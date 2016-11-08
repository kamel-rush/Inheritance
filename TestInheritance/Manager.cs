using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance
{
    class Manager:Employee
    {
        private float bonus;

        public Manager(string fullName, string sSN, float salary, float bonus) :base(fullName, sSN, salary)
        {   
            Bonus = bonus;

           
        }


        public override string getFormattedSalary()
        {
            return "$" + Math.Round((Salary + Bonus),2);
        }

        public float Bonus
        {
            get
            {
                return bonus;
            }

            set
            {
                bonus = value;
            }
        }
    }
}
