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
    public partial class MultiplePicturesMode : Form
    {
        Bitmap picboxMap1, picboxMap2;
        Image<Gray, byte> imgOld,imgOld2,imgResult;
        Image<Gray, byte> imgOldtemp, imgOld2temp;
        public MultiplePicturesMode()
        {
            InitializeComponent();
        }
        public static Image<Gray, byte> makeBinary(Image<Gray, byte> imgGrey)
        {
            CvInvoke.Threshold(imgGrey, imgGrey, 127, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            return imgGrey;
        }

        private void obraz11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgResult = imgOld;
            CvInvoke.Add(imgOld, imgOld, imgResult);
            imageBR.Image = imgResult;
        }

        private void obraz12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgResult = imgOld;
            CvInvoke.Add(imgOld, imgOld2, imgResult);
            imageBR.Image = imgResult;
        }

        private void obraz22ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgResult = imgOld;
            CvInvoke.Subtract(imgOld, imgOld, imgResult);
            imageBR.Image = imgResult;
        }

        private void obraz21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgResult = imgOld2;
            CvInvoke.Subtract(imgOld, imgOld2, imgResult);
            imageBR.Image = imgResult;
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgResult = imgOld;
            imgOld = makeBinary(imgOld);
            imgOld2 = makeBinary(imgOld2);
            CvInvoke.BitwiseAnd(imgOld, imgOld2, imgResult);
            imageBR.Image = imgResult;
        }

        private void oRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgResult = imgOld;
            imgOld = makeBinary(imgOld);
            imgOld2 = makeBinary(imgOld2);
            CvInvoke.BitwiseOr(imgOld, imgOld2, imgResult);
            imageBR.Image = imgResult;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                imgResult.ToBitmap().Save(sf.FileName);
                //ewentualnie
                //mypicture.toBitmap().Save(sf.FileName);
            }
        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgResult = imgOld;
            imgOld = makeBinary(imgOld);
            imgOld2 = makeBinary(imgOld2);
            CvInvoke.BitwiseXor(imgOld, imgOld2, imgResult);
            imageBR.Image = imgResult;
        }

        private void nOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgResult = imgOld;
            imgOldtemp=makeBinary(imgOld);
            CvInvoke.BitwiseNot(imgOld, imgResult);
            imageBR.Image = imgResult;
        }

        private void BtnOp1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            try
            {//próba otwarcia pliku z obrazem
                dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    picboxMap1 = new Bitmap(dialog.FileName);
                    this.imageBS1.Image = picboxMap1;
                    //mypicture = new Picture(picboxCopyMap);
                    imgOld = picboxMap1.ToImage<Gray, byte>();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            try
            {//próba otwarcia pliku z obrazem
                dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    picboxMap2 = new Bitmap(dialog.FileName);
                    this.imageBS2.Image = picboxMap2;
                    //mypicture = new Picture(picboxCopyMap);
                    imgOld2 = picboxMap2.ToImage<Gray, byte>();

                }
            }

            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
