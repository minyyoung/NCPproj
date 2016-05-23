using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ChangePictureWithState
{
    class CState
    {
        private PictureBox img;
        private int state;

        public CState(ref PictureBox image)
        {
            img = image;
        }
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                // if state is change!?
                // change image.
                state = value;
                img.Load("C:\\Users\\Student\\Desktop\\b.jpg");
            }
        }
    }
}
