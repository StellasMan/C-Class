using System;
using System.IO;
using System.Runtime.InteropServices;

namespace RsrcCleanup
{
    public class ResourceItem : IDisposable
    {
        public ResourceItem(UInt32 uiNumber)
        {
            m_uiNumber = uiNumber;
            m_sFileName = $"ResourceItemFile{uiNumber}.txt";

            m_strWriter = new StreamWriter(m_sFileName);

            if (m_strWriter != null)
            {
                // Write a line of text
                m_strWriter.WriteLine($"Hello from ResourceItem number {m_uiNumber}");

                // Write the Date and Time
                DateTime dtNow = DateTime.Now;
                m_strWriter.WriteLine($"{dtNow:F}");
                m_strWriter.Flush();
            }

            this.m_intPtr = Marshal.AllocHGlobal(new IntPtr(1024*1024));
        }

        ~ResourceItem()
        {
            Dispose(false);
        }

        public void FreeManaged()
        {
            Console.WriteLine($"Freeing managed resources for ResourceItem {m_uiNumber}");
            m_strWriter.Close();
            File.Delete(m_sFileName);
        }

        public void FreeUnmanaged()
        {
            Console.WriteLine($"Freeing unmanaged resources for ResourceItem {m_uiNumber}");

            Marshal.FreeHGlobal(this.m_intPtr);
            this.m_intPtr = IntPtr.Zero;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    FreeManaged();
                }

                FreeUnmanaged();

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ResourceItem() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        private StreamWriter m_strWriter;
        private IntPtr m_intPtr = IntPtr.Zero;
        private string m_sFileName;
        private readonly UInt32 m_uiNumber;

    }
}
