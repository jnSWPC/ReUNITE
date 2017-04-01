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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 3000; // miliseconds
            timer1.Tick += Timer1_Tick;
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Stop();
            //MainForm mainForm = new MainForm();
            //mainForm.ShowDialog();

            MasterDetail form = new MasterDetail();
            form.ShowDialog();

        }
    }
}
