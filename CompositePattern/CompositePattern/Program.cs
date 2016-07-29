using HeadKnowledge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPersonnel> personnel = new List<IPersonnel>();

            Manager david = new Manager("David");
            Employee john = new Employee("John");
            Employee sarah = new Employee("Sarah");

            david.AddEmployee(john);
            david.AddEmployee(sarah);

            personnel.Add(david);
            personnel.Add(john);
            personnel.Add(sarah);

            david.GetEmployees();

            foreach (var person in personnel)
            {
                Console.WriteLine(person.GetSalaryRange());
            }

            Console.ReadLine();
        }
    }
}
