using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyValidate
{
    public abstract class Validate<T>
    {
        protected Validate<T> _nextRule;

        internal abstract ValidationResult ValidateRule(T entity);

        internal void SetNextRule(Validate<T> nextRule)
        {
            _nextRule = nextRule;
        }
    }
}
