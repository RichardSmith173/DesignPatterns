using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class BuildAccountSingleContributions : Builder
    {
        private Account _account = new Account();

        internal override void BuildContributions()
        {
            _account.AddContribution(Contributions.Single);
        }

        internal override void BuildFees()
        {
            _account.AddFee(Fees.Iaf);
        }

        internal override Account GetResult()
        {
            return _account;
        }
    }
}
