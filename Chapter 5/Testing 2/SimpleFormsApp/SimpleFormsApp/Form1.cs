using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnStartClick(object sender, EventArgs e)
        {
            Console.WriteLine("Button has been clicked!!");

            MessageBox.Show("Button has been clicked!!", "This is a caption", MessageBoxButtons.YesNoCancel);
        }
    }
}
