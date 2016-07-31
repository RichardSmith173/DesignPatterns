using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class AccountFacade
    {
        public Client Client;
        public Fee Fee;
        public Transaction Transaction;

        public AccountFacade()
        {
            Client = new Client();
            Fee = new Fee();
            Transaction = new Transaction();
        }

        internal void CreateAccount()
        {
            Client.AddClients();
            Fee.AddFees();
            Transaction.AddTransactions();
        }
    }
}
