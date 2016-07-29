using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadKnowledge
{
    public class Client
    {
        List<IPersonnel> personnel = new List<IPersonnel>();

        public void Setup()
        {
            Manager manager = new Manager("David");
            Employee employee = new Employee("John");
            Employee employee2 = new Employee("Sarah");

            manager.AddEmployee(employee);
            manager.AddEmployee(employee2);

            personnel.Add(manager);
            personnel.Add(employee);
            personnel.Add(employee2);

            manager.GetEmployees();

            foreach (var person in personnel)
            {
                Console.WriteLine(person.GetSalaryRange());
            }

            Console.ReadLine();

        }

    }
}
