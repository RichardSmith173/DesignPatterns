using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    [OperationContract]
    interface IEntityClient
    {
        [ServiceContract]
        void AddClient(Client client);
    }
}
