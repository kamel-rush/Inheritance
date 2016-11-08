using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance
{
    class CEO:Manager
    {
        public CEO(string fullName, string sSN, float salary, float bonus, int noOfStocks)
            : base(fullName, sSN, salary, bonus)
        {

            NumberOfStocks = noOfStocks; 

        }

        public override string getFormattedSalary()
        {
            return "$"+Math.Round(Salary+Bonus+NumberOfStocks*100,3); 
        }

        private int numberOfStocks;

        public int NumberOfStocks
        {
            get
            {
                return numberOfStocks;
            }

            set
            {
                numberOfStocks = value;
            }
        }
    }
}
