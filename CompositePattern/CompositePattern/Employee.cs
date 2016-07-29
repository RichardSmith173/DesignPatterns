using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeadKnowledge
{
    public class Employee : IPersonnel
    {
        public string Name {get; set;}

        public Employee(string name)
        {
            Name = name;
        }

        public string GetSalaryRange()
        {
            return string.Format("{0} can earn 20,000 - 40,000", Name);
        }

    }
}
