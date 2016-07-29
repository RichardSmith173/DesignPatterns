using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposablePattern
{
    class SomeConnection : IDisposable
    {
        private bool dispose = false;

        protected virtual void Dispose(bool disposing)
        {
            if (dispose)
            {

            }

            if (disposing)
            {

            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
