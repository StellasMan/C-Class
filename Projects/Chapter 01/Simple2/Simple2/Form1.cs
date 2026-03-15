using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple2
{
    public partial class frmSimple2 : Form
    {
        public frmSimple2()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World!";
        }
    }
}
