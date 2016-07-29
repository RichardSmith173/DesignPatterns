using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class BuildAccountRegularContributions : Builder
    {
        private Account _account = new Account();

        internal override void BuildContributions()
        {
            _account.AddContribution(Contributions.Regular);
        }

        internal override void BuildFees()
        {
            _account.AddFee(Fees.Oaf);
        }

        internal override Account GetResult()
        {
            return _account;
        }
    }
}
