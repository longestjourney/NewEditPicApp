using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPicEditApp
{
    public partial class Maski : Form
    {
        int a11, a12,a13,a21,a22,a23,a31,a32,a33;

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public Maski()
        {
            InitializeComponent();
        }

        public void Przypisanie(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
        {
            num11.Value = a11;
            num12.Value = a12;
            num13.Value = a13;
            num21.Value = a21;
            num22.Value = a22;
            num23.Value = a23;
            num31.Value = a31;
            num32.Value = a32;
            num33.Value = a33;
        }

        private void bMask1_Click(object sender, EventArgs e)
        {
            a11 = 0;
            a13 = 0;
            a31 = 0;
            a33 = 0;
            a12 = -1;
            a21 = -1;
            a23 = -1;
            a32 = -1;
            a22 = 5;

            Przypisanie(a11, a12, a13, a21, a22, a23, a31, a32, a33);
        }

        private void bMask2_Click(object sender, EventArgs e)
        {
            a11 = -1;
            a13 = -1;
            a31 = -1;
            a33 = -1;
            a12 = -1;
            a21 = -1;
            a23 = -1;
            a32 = -1;
            a22 = 9;

            Przypisanie(a11, a12, a13, a21, a22, a23, a31, a32, a33);
        }

        private void bMask3_Click(object sender, EventArgs e)
        {
            a11 = 1;
            a13 = 1;
            a31 = 1;
            a33 = 1;
            a12 = -2;
            a21 = -2;
            a23 = -2;
            a32 = -2;
            a22 = 5;

            Przypisanie(a11, a12, a13, a21, a22, a23, a31, a32, a33);
        }
    }
}
