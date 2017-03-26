using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReUNITE
{
    public partial class WebViewer : Form
    {
        public WebViewer()
        {
            InitializeComponent();
        }


        public WebViewer(string posterURL)
        {
            InitializeComponent();
            label1.Text = posterURL;
        }
    }
}
