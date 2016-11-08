using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance
{
    class Employee
    {
        private string fullname;
        private string SSN;
        private float salary;

        public virtual string getFormattedSalary()// we can override this method in derived classes
        {
            return "$"+ Math.Round(salary,3);

        }

        public Employee(string fullname, string sSN, float salary)
        {
            Fullname = fullname;
            SSN1 = sSN;
            Salary = salary;
        }
        public Employee()
        {
            Fullname = "";
            SSN1 = "";
            Salary = 0.0f;


        }

        public string Fullname
        {
            get
            {
                return fullname;
            }

            set
            {
                fullname = value;
            }
        }

        public string SSN1
        {
            get
            {
                return SSN;
            }

            set
            {
                SSN = value;
            }
        }

        public float Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
    }
}
