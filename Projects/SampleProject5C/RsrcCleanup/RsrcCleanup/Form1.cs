using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RsrcCleanup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnAdd(object sender, EventArgs e)
        {
            ResourceItem rsrcItem = new ResourceItem(++m_uiCount);
            m_lstResources.AddLast(rsrcItem);
        }

        private void OnRelease(object sender, EventArgs e)
        {
            m_lstResources.Clear();
        }

        private void OnDisposeAndRelease(object sender, EventArgs e)
        {
            foreach(ResourceItem resItem in m_lstResources)
            {
                resItem.Dispose();
            }
        }

        private void OnCollect(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private LinkedList<ResourceItem> m_lstResources = new LinkedList<ResourceItem>();
        private UInt32 m_uiCount = 0;
    }
}
