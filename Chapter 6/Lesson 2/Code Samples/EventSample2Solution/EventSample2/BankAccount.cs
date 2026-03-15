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

    public class LargeDepositEventArgs : EventArgs
    {
        public LargeDepositEventArgs(decimal acctBalance, decimal amtOfDeposit)
        {
            m_acctBalance = acctBalance;
            m_amtOfDeposit = amtOfDeposit;
        }

        public decimal m_acctBalance, m_amtOfDeposit;
    }

    public class BankAccount
    {
        protected EventHandler<OverdrawnEventArgs> overdrawnEvent;
        protected EventHandler<LargeDepositEventArgs> largeDepositEvent;

        public void SubscribeToOverdrawnEvent(EventHandler<OverdrawnEventArgs> overdrawnDelegate)
        {
            overdrawnEvent -= overdrawnDelegate;
            overdrawnEvent += overdrawnDelegate;
        }

        public void SubscribeToLargeDepositEvent(EventHandler<LargeDepositEventArgs> largeDepositDelegate)
        {
            largeDepositEvent -= largeDepositDelegate;
            largeDepositEvent += largeDepositDelegate;
        }

        public void UnsubscribeFromOverdrawnEvent(EventHandler<OverdrawnEventArgs> overdrawnDelegate)
        {
            overdrawnEvent -= overdrawnDelegate;
        }

        public void UnsubscribeFromLargeDepositEvent(EventHandler<LargeDepositEventArgs> largeDepositDelegate)
        {
            largeDepositEvent -= largeDepositDelegate;
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

                if ((creditAmt >= 1000) && (largeDepositEvent != null))
                {
                    // Call our large deposit event handler
                    largeDepositEvent(this, new LargeDepositEventArgs(m_Balance, creditAmt));
                }
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
