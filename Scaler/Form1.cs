using System;
using System.IO;
using System.Windows.Forms;

namespace Scaler
{
    public partial class Form1 : Form
    {
        private const string LayoutFileLocation = @"C:\users\cpresley\layout.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dockManager1.SaveLayoutToXml(LayoutFileLocation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(LayoutFileLocation))
            {
                dockManager1.RestoreLayoutFromXml(LayoutFileLocation);
            }
        }
    }
}
