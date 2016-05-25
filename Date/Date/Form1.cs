using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            DateTime tmpDT = DateTime.Now;

            Text = tmpDT.ToString();
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            DateTime tmpDT = DateTime.Now;

            Text = tmpDT.ToLongTimeString();
        }
    }
}
