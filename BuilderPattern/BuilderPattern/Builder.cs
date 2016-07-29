using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    internal abstract class Builder
    {
        internal abstract void BuildContributions();
        internal abstract void BuildFees();
        internal abstract Account GetResult();
    }
}
