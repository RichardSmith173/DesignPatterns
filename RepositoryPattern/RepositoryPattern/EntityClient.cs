using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class EntityClient : Respository<Client>, IEntityClient
    {
        public void AddClient(Client client)
        {
            Add(client);
        }
    }
}
