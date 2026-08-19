using ModernUI_NET472.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITester_NET472
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void highlightImageButton1_Click(object sender, EventArgs e)
        {
            highlightImageButton1.ButtonMode = AppAssets.ButtonMode.LOCKED;
        }

        private void highlightImageButton2_Click(object sender, EventArgs e)
        {
            highlightImageButton1.ButtonMode = AppAssets.ButtonMode.STANDARD;
        }

        private void highlightImageButton3_Click(object sender, EventArgs e)
        {
            highlightImageButton1.ButtonMode = AppAssets.ButtonMode.LOADING;
        }

        private void highlightImageButton4_Click(object sender, EventArgs e)
        {
            highlightImageButton1.ButtonMode = AppAssets.ButtonMode.DISABLED;
        }
    }
}
