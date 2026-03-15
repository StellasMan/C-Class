using System;
using System.Windows.Forms;

namespace EventSample
{
    public partial class Form1 : Form
    {
        public BankAccount bankAccount;
        public Func<decimal, decimal> funcCredit;
        public Func<decimal, decimal> funcDebit;

        public Form1()
        {
            InitializeComponent();
            bankAccount = new BankAccount(1000.00m);

            funcCredit = bankAccount.Credit;
            funcDebit = bankAccount.Debit;

            // Display the starting balance in the 'txtBalance' textbox 
            txtBalance.Text = $"{bankAccount.Balance:C}";

            // Set the focus to the txtAmount textbox
            txtAmount.Focus();
        }

        private void OnCredit(
            object sender,
            EventArgs e)
        {
            decimal dAmount;

            string sAmount = txtAmount.Text;
            if (decimal.TryParse(sAmount, System.Globalization.NumberStyles.Currency, null, out dAmount))
            {
                decimal dBalance = bankAccount.Credit(dAmount);
                txtBalance.Text = $"{dBalance:C}";

                txtAmount.Clear();
                txtAmount.Focus();
            }
        }

        private void OnDebit(
            object sender,
            EventArgs e)
        {
            decimal dAmount;

            string sAmount = txtAmount.Text;
            if (decimal.TryParse(sAmount, System.Globalization.NumberStyles.Currency, null, out dAmount))
            {
                decimal dBalance = bankAccount.Debit(dAmount);
                txtBalance.Text = $"{dBalance:C}";

                txtAmount.Clear();
                txtAmount.Focus();
            }
        }

        // This Event Handler gets invoked when an attempt is made to overdraw the account
        private void OverdrawnEventHandler(
			Object bankAcct,
			OverdrawnEventArgs eventArgs)
        {
            MessageBox.Show($"Attempt to overdraft account by {eventArgs.m_amtOverdrawn:C}", "Overdrawn Warning", MessageBoxButtons.OK);
        }

        // Subscribe to the OverdrawnEvent
        private void OnSubscribe(
			object sender,
			EventArgs e)
        {
            bankAccount.Subscribe(OverdrawnEventHandler);
        }

        // Unsubscribe from the OverdrawnEvent
        private void OnUnsubscribe(
			object sender,
			EventArgs e)
        {
            bankAccount.Unsubscribe(OverdrawnEventHandler);
        }
    }
}
