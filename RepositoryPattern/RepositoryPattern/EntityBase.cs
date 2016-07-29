using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryPattern
{
    public abstract class EntityBase
    {
        protected int Id { get; protected set; }
    }
}
