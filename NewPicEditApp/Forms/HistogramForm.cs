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
    internal partial class HistogramForm : Form
    {
        Histogram h;
        Picture picture;
        Bitmap bitmap;

        bool is_greyscale;
        int[] R = new int[256];
        int[] G = new int[256];
        int[] B = new int[256];

        public HistogramForm(Picture picture)
        {
            InitializeComponent();
            this.picture = picture;
            h = picture.histogram;
            is_greyscale = picture.Grayscale;

            R = h.R;
            G = h.G;
            B = h.B;
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            if (is_greyscale)//jest czarno-bialy
            {
                chRED.Visible = false;
                chGREEN.Visible = false;
                chBLUE.Visible = false;
                GridViewBLUE.Visible = false;
                GridViewGREEN.Visible = false;
                GridViewRED.Visible = false;

                cValue.Series[0].Points.DataBindY(R);

                for (int i = 0; i < R.Length; i++)
                {
                    GridViewValues.Rows.Add(i, R[i]);
                }

            }
            else //jest kolorowy
            {
                //chRED.Visible = true;
                //chGREEN.Visible = true;
                //chBLUE.Visible = true;
                for (int i = 0; i < R.Length; i++)
                {
                    GridViewRED.Rows.Add(i, R[i]);
                    GridViewGREEN.Rows.Add(i, G[i]);
                    GridViewBLUE.Rows.Add(i, B[i]);
                }

                chRED.Series[0].Points.DataBindY(R);
                chGREEN.Series[0].Points.DataBindY(G);
                chBLUE.Series[0].Points.DataBindY(B);
                //chA.Series[0].Points.DataBindY(AhistogramArray);
            }

        }
    }
}
