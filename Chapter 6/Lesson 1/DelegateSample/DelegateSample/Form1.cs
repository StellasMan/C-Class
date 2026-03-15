using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSample
{
    public delegate int MethodDelegate(int Value1, int Value2);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnTest(object sender, EventArgs e)
        {
            MathFuncs mfSample = new MathFuncs();
            MethodDelegate func = mfSample.Add;

            mfSample.PerformFunc(func, 5, 6);

            Action<int, int> actionDelegate = mfSample.MultNoReturn;
            actionDelegate += mfSample.ModNoReturn;
            mfSample.PerformAction(actionDelegate, 5, 6);

            actionDelegate = delegate (int x, int y)
                {
                    int result = x * y;
                    Console.WriteLine($"Anonymous delegate: Result = {result}");
                };

            mfSample.PerformAction(actionDelegate, 5, 6);
        }

        private void OnLambda(object sender, EventArgs e)
        {
            Action<string> note = (string msg) => MessageBox.Show(msg, "Lambda Testing", MessageBoxButtons.OK);
            note += (string msg) => MessageBox.Show(msg, "More Lambda Testing", MessageBoxButtons.OKCancel);

            note("This is pretty cool!");
        }

        private void OnAsync(object sender, EventArgs e)
        {
            Action<int> asyncAction = async (int count) =>
            {
                txtStatus.Text = "Starting test";
                await DoSomethingAsync(count);
                txtStatus.Text = "Test Complete";
            };

            asyncAction(5);
        }

        async Task DoSomethingAsync(int nCount)
        {
            // Thread.Sleep(1000 * nCount);
            await Task.Delay(1000 * nCount);
        }
    }
}
