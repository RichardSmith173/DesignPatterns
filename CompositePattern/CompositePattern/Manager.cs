using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadKnowledge
{
    public class Manager : IPersonnel
    {
        List<IPersonnel> personnel = new List<IPersonnel>();
        
        public string Name { get; set; }

        public int MyProperty { get; set; }
        public Manager(string name)
        {
            Name = name;
        }

        public string GetSalaryRange()
        {
            return string.Format("{0} can earn 40,000 - 60,000", Name);
        }

        public void AddEmployee(Employee employee)
        {
            personnel.Add(employee);
        }

        public void GetEmployees()
        {
            foreach (var worker in personnel)
            {
                Console.WriteLine("{0} works for {1}.", worker.Name, Name);
            }
        }

    }
}
