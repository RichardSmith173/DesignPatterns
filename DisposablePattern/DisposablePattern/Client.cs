using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposablePattern
{
    class Client
    {
        public void InvokeDispose()
        {
            using (var connection = new SomeConnection())
            {
                //Do something
            }
        }
    }
}
