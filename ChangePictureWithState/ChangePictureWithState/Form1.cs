using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangePictureWithState
{
    public partial class Form1 : Form
    {
        CState cs;
        public Form1()
        {
            InitializeComponent();

            pictureBox.Load("C:\\Users\\Student\\Desktop\\a.jpg");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            cs = new CState(ref pictureBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cs.State = cs.State + 10;
            labelState.Text = cs.State.ToString();
        }
    }
}
