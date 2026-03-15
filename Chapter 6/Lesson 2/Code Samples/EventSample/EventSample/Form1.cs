using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSample
{
    public partial class EventSampleForm : Form
    {
        public BankAccount bankAccount;

        public EventSampleForm()
        {
            InitializeComponent();
        }

        private void EventSampleForm_Load(object sender, EventArgs e)
        {
            bankAccount = new BankAccount(1000);
            bankAccount.OverdrawnEvent += OnOverdrawn; 
        }

        private void OnOverdrawn(BankAccount bank, decimal Amount)
		{
            MessageBox.Show($"Account is overdrawn by {Amount:C}", "Warning");
		}

        private void OnCredit(object sender, EventArgs e)
        {
            bankAccount.Credit(100);
        }

        private void OnDebit(object sender, EventArgs e)
        {
            bankAccount.Debit(100);
        }

        private void OnOverdrawn(decimal amount)
        {
            MessageBox.Show($"Account is overdrawn by {amount:C}", "Overdrawn Warning", MessageBoxButtons.OK);
        }
    }
}
