using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    public class OverdrawnEventArgs : EventArgs
    {
        public OverdrawnEventArgs(decimal acctBalance, decimal amtOverdrawn)
        {
            m_acctBalance = acctBalance;
            m_amtOverdrawn = amtOverdrawn;
        }

        public decimal m_acctBalance, m_amtOverdrawn;
    }

    public class BankAccount
    {
        protected EventHandler<OverdrawnEventArgs> overdrawnEvent;

        public void Subscribe(EventHandler<OverdrawnEventArgs> overdrawnDelegate)
        {
            overdrawnEvent -= overdrawnDelegate;
            overdrawnEvent += overdrawnDelegate;
        }

        public void Unsubscribe(EventHandler<OverdrawnEventArgs> overdrawnDelegate)
        {
            overdrawnEvent -= overdrawnDelegate;
        }

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
            {
                Debit(-creditAmt);
            }
            else
            {
                m_Balance += creditAmt;
            }

            return m_Balance;
        }

        public decimal Debit(decimal debitAmt)
        {
            if (debitAmt < 0)
            {
                Credit(-debitAmt);
            }
            else
            {
                if (debitAmt <= m_Balance)
                {
                    m_Balance -= debitAmt;
                }
                else
                {
                    Console.WriteLine($"Attempt to overdraw account by {debitAmt - m_Balance:C}");

                    // Call our overdrawn event handler
                    if (overdrawnEvent != null)
                    {
                        overdrawnEvent(this, new OverdrawnEventArgs(m_Balance, debitAmt - m_Balance));
                    }
                }
            }

            return m_Balance;
        }

        private decimal m_Balance;
    }
}   
