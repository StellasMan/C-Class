using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSample2
{
    public partial class Form1 : Form
    {
        public BankAccount bankAccount;
        public Action<decimal> actionHandler;

        public Form1()
        {
            InitializeComponent();
            bankAccount = new BankAccount(1000.00m);
			bankAccount.OverdrawnEvent += BankAccount_OverdrawnEvent;
            txtBalance.Text = $"{bankAccount.Balance:C}";
            txtAmount.Focus();
        }

		private void BankAccount_OverdrawnEvent(decimal obj)
		{
			throw new NotImplementedException();
		}

		private void OnCredit(object sender, EventArgs e)
        {
            string sAmount = txtAmount.Text;
            decimal dAmount;
            if (decimal.TryParse(sAmount, System.Globalization.NumberStyles.Currency, null, out dAmount))
            {
                decimal dBalance = bankAccount.Credit(dAmount);
                txtBalance.Text = $"{dBalance:C}";

                txtAmount.Clear();
                txtAmount.Focus();
            }
        }

        private void OnDebit(object sender, EventArgs e)
        {
            string sAmount = txtAmount.Text;
            decimal dAmount;
            if (decimal.TryParse(sAmount, System.Globalization.NumberStyles.Currency, null, out dAmount))
            {
                decimal dBalance = bankAccount.Debit(dAmount);
                txtBalance.Text = $"{dBalance:C}";

                txtAmount.Clear();
                txtAmount.Focus();
            }
        }
    }
}
