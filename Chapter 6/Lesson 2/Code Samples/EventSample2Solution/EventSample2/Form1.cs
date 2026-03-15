using System;
using System.Windows.Forms;

namespace EventSample
{
    public partial class Form1 : Form
    {
        public BankAccount bankAccount;
        protected delegate decimal CreditOrDebitDelegate(decimal dAmountOfTransaction);
        protected CreditOrDebitDelegate funcCredit;
        protected CreditOrDebitDelegate funcDebit;

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
            CreditOrDebit(funcCredit);
        }

        private void OnDebit(
            object sender,
            EventArgs e)
        {
            CreditOrDebit(funcDebit);
        }

        private void CreditOrDebit(CreditOrDebitDelegate creditOrDebit)
        {
            decimal dAmount;

            string sAmount = txtAmount.Text;
            if (decimal.TryParse(sAmount, System.Globalization.NumberStyles.Currency, null, out dAmount))
            {
                decimal dBalance = creditOrDebit(dAmount);
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

        // This Event Handler gets invoked when a deposit of $1000 or more is made
        private void LargeDepositEventHandler(
            Object bankAcct,
            LargeDepositEventArgs eventArgs)
        {
            MessageBox.Show($"Deposit of {eventArgs.m_amtOfDeposit:C} credited to account. Current balance is {eventArgs.m_acctBalance:C}. ", "Large Deposit Notification", MessageBoxButtons.OK);
        }

        // Subscribe to OverdrawnEvent and LargeDepositEvent events
        private void OnSubscribe(
			object sender,
			EventArgs e)
        {
            bankAccount.SubscribeToOverdrawnEvent(OverdrawnEventHandler);
            bankAccount.SubscribeToLargeDepositEvent(LargeDepositEventHandler);
        }

        // Unsubscribe from OverdrawnEvent and LargeDepositEvent events
        private void OnUnsubscribe(
			object sender,
			EventArgs e)
        {
            bankAccount.UnsubscribeFromOverdrawnEvent(OverdrawnEventHandler);
            bankAccount.UnsubscribeFromLargeDepositEvent(LargeDepositEventHandler);
        }
    }
}
