using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace TestInheritance
{
    class Program
    {
        public static object HashTable { get; private set; }

        static void Main(string[] args)
        {


            Employee emp1 = new Employee("Steve Jobs", "111111111", 1.0f);

            Manager mg1 = new Manager("Bill Gates","000000000",1.0f,10000000000f);

           // Console.WriteLine(emp1.getFormattedSalary());

           // Console.WriteLine(mg1.getFormattedSalary());


            List<Employee> EmployeeList = new List<Employee>();

            EmployeeList.Add(emp1);
            EmployeeList.Add(mg1);
            // create an object on the fly 
            EmployeeList.Add(new CEO("Tommy Lewis","555555555",1,1000000000,10000000));

            for (int i = 0; i < EmployeeList.Count; i++)
            {
                Console.WriteLine(EmployeeList[i].getFormattedSalary());
            }

            

        }
    }
}
