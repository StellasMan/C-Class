using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
	public class MyDisposable : IDisposable
	{
		private bool _disposed = false;

		public void Dispose()
		{
			FreeResources(true);
			GC.SuppressFinalize(this);
		}

		// Only include a destructor/finalizer if there are unmanaged resources
		~MyDisposable()
		{
			FreeResources(false);
		}

		private void FreeResources(bool bDisposeManaged)
		{
			if (!_disposed)
			{
				if (bDisposeManaged)
				{
					// Dispose of managed resources here
				}

				// Dispose of unmanaged resources here

				_disposed = true;
			}
		}
	}
}
