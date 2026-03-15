using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample2
{
    public class BankAccount
    {
        protected event Action<decimal> OverdrawnEvent;

        public BankAccount(decimal startingBalance)
        {
            m_Balance = startingBalance;
        }

        public decimal Balance
        {
            get 
            {
                return m_Balance;
            }
        }

        public decimal Credit(decimal creditAmt)
        {
            if (creditAmt < 0)
                Debit(-creditAmt);
            else
                m_Balance += creditAmt;

            return m_Balance;
        }

        public decimal Debit(decimal debitAmt)
        {
            if (debitAmt < 0)
                Credit(-debitAmt);
            else
            {
                if (debitAmt <= m_Balance)
                {
                    m_Balance -= debitAmt;
                }
                else
                {
                    Console.WriteLine($"Attempt to overdraw account by {debitAmt - m_Balance:C}");
                    
                    if (OverdrawnEvent != null)
                        OverdrawnEvent(debitAmt - m_Balance);
                }
            }

            return m_Balance;
        }

        private decimal m_Balance;
    }
}
