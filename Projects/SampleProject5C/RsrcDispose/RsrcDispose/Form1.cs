using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsrcDispose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnAddResource(object sender, EventArgs e)
        {
            Console.WriteLine("OnAddResource");
            MessageBox.Show("You pressed 'Add Resource'", "Learning C#", MessageBoxButtons.OKCancel);
        }

        private void OnDisposeResource(object sender, EventArgs e)
        {
            Console.WriteLine("OnDisposeResource");
            MessageBox.Show("You pressed 'Dispose Resource'", "Learning C#", MessageBoxButtons.OKCancel);
        }

        private void OnCollect(object sender, EventArgs e)
        {
            Console.WriteLine("OnCollect");
            MessageBox.Show("You pressed 'Collect'", "Learning C#", MessageBoxButtons.OKCancel);
        }
    }
}
