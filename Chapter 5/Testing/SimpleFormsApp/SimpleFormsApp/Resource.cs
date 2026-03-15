using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFormsApp
{
    class Resource : IDisposable
    {
        private bool bDisposedAlready = false;
        public void Dispose()
        {
            ReleaseResources(true);
            GC.SuppressFinalize(this);
        }

        private void ReleaseResources(bool bReleaseManaged)
        {
            if (!bDisposedAlready)
            {
                if (bReleaseManaged)
                {
                    // can clean up other managed objects  
                }

                // Clean up unmanaged resources  
                bDisposedAlready = true;
            }
        }

        ~Resource()
        {
            ReleaseResources(false);
        }
    }
}
