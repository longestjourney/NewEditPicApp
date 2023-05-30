using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class ProgQuest2 : Form
    {
        PicForm picForm;
        Bitmap bmp;
        int threshold;
        Image<Gray, byte> imgGrey=null;
        public ProgQuest2(PicForm picform, Bitmap bitmap)
        {
            this.picForm = picform;
            bmp = bitmap;
            threshold=0;
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            NRLabel.Text = trackBar1.Value.ToString();
            threshold = trackBar1.Value;

            imgGrey = bmp.ToImage<Gray, byte>();
            CvInvoke.Threshold(imgGrey, imgGrey, threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

            picForm.picbox.Image = imgGrey.ToBitmap();

        }
    }
}
