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

        private void OnStart(object sender, EventArgs e)
        {
            //for (int nIx=0; nIx<5000; nIx++)
            //{
            //    int[] aInts = new int[1000000];
            //}

            Resource rsrcItem = new Resource();
            // rsrcItem.Dispose();

            Console.WriteLine("Done!");
        }

        private void OnCollect(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
