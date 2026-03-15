using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
	public class Simple
	{
		public Simple(int Dividend, int Divisor)
		{
			m_Dividend = Dividend;
			m_Divisor = Divisor;
		}

		public decimal PerformOp()
		{
			decimal result = 0;

			try
			{
				result = ((decimal)m_Dividend / m_Divisor);
			}
			catch (Exception ex)
			{
				System.Reflection.MethodInfo preserveStackTrace = typeof(Exception).GetMethod("InternalPreserveStackTrace",
					  System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
				preserveStackTrace.Invoke(ex, null);
				throw;
			}

			return result;
		}

		protected readonly int m_Dividend;
		protected readonly int m_Divisor;
	}
}
