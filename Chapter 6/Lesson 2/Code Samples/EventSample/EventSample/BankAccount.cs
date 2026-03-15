using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    public class BankAccount
    {
        // public delegate void OverdrawnDelegate();
        public event Action<BankAccount, decimal> OverdrawnEvent;

        public BankAccount(decimal startingBalance)
        {
            m_Balance = startingBalance;
        }

        public decimal Credit(decimal Amount)
        {
            m_Balance += Amount;
            Console.WriteLine($"Credit: Balance is {m_Balance:C}");
            return m_Balance;
        }

        public decimal Debit(decimal Amount)
        {
            if (m_Balance >= Amount)
            {
                m_Balance -= Amount;
            }
            else
            {
                Console.WriteLine("Overdrawn!");

                if (OverdrawnEvent == null)
                    OverdrawnEvent(this, (Amount - m_Balance));
            }

            Console.WriteLine($"Debit: Balance is {m_Balance:C}");
            return m_Balance;
        }


        public decimal Balance
        {
            get
            {
                return m_Balance;
            }
        }

        private decimal m_Balance;
    }
}
