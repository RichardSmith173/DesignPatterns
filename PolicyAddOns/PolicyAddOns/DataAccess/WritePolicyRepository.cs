using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns.DataAccess
{
    class WritePolicyRepository : IWriteRepository<Policy>
    {
        public void Update(Policy entity)
        {
            try
            {
                //Save to database
                Console.WriteLine("Saved to database");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
