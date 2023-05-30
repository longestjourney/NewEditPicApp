using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;


namespace NewPicEditApp
{
    public partial class PicForm : Form
    {
        Picture mypicture;
        Bitmap picboxCopyMap;
        static List<Picture> pictureList = new List<Picture>();
        static List<PicForm> formList = new List<PicForm>();
        static int picCount=0;
        HistogramForm histogram;

        /*  otwarcie pliku:
        -------------------------------------------------------------------------------------*/
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            try
            {//próba otwarcia pliku z obrazem
                dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.picboxCopyMap = new Bitmap(dialog.FileName);
                    this.picbox.Image = picboxCopyMap;
                    mypicture = new Picture(picboxCopyMap);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*  zapis pliku:
        -------------------------------------------------------------------------------------*/
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                picbox.Image.Save(sf.FileName);
                //ewentualnie
                //mypicture.toBitmap().Save(sf.FileName);
            }
        }

        /*    to są konstruktory okienka PicForm
        -------------------------------------------------------------------------------------*/
        public PicForm() 
        { 
            InitializeComponent();
            formList.Add(this);
            Text = String.Format("Pic{0}", picCount++);
            picboxCopyMap = (Bitmap)picbox.Image;
        }
        public PicForm(Bitmap bitmap) 
        { 
            InitializeComponent();
            picboxCopyMap = bitmap;
            mypicture = new Picture(bitmap);
            picbox.Image = picboxCopyMap;
        }

        /*    Image Binary util
       -------------------------------------------------------------------------------------*/
        public Image<Gray, byte> makeBinary(Image<Gray, byte> imgGrey)
        {
            CvInvoke.Threshold(imgGrey, imgGrey, 127, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            return imgGrey;
        }

        /*    ToString util
        -------------------------------------------------------------------------------------*/
        public override string ToString()
        {
            return this.Text;
        }


        /*    zadania związane z histogramem
        -------------------------------------------------------------------------------------*/
        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {
                mypicture = new Picture(picboxCopyMap);
                histogram = new HistogramForm(mypicture);
                histogram.Show();
        }


        //    operacje zmian obrazu
        private void rozciąToolStripMenuItem_Click(object sender, EventArgs e)
        {
                picboxCopyMap = PictureFactory.make("stretch", picboxCopyMap).toBitmap();
                picbox.Image = picboxCopyMap;
        }

        private void equalizacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.picboxCopyMap != null)
            {
                Bitmap EditMap = new Bitmap(this.picboxCopyMap);
                picboxCopyMap = PictureFactory.make("equlize", EditMap).toBitmap();
                picbox.Image = picboxCopyMap;
            }
            else { MessageBox.Show("Nie wybrano obrazu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            // string onePixelOpList = new List<string> {"invert", "progowanie", "costam" };
            // this.picboxCopyMap = PictureCreator.CreatePicture(EditMap, onePixelOpList[co_onepoint_operations.SelectedIndex]).toBitmap();
        }

        private void zwykłeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            PropQuestion propQuestion = new PropQuestion(EditMap, this, 1);
            propQuestion.Show();
        }

        private void zPoziomamiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rozciąganieSelektywneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            PropQuestion propQuestion4 = new PropQuestion(EditMap, this, 4);
            propQuestion4.Show();
        }

        private void rozciąganieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picboxCopyMap = PictureFactory.make("stretch", picboxCopyMap).toBitmap();
            picbox.Image = picboxCopyMap;
        }

        private void equalizacjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            picboxCopyMap = PictureFactory.make("equlize", EditMap).toBitmap();
            picbox.Image = picboxCopyMap;
        }

        //Negatyw click
        private void miInvert_Click(object sender, EventArgs e)
        {
            picboxCopyMap = PictureFactory.make("invert", picboxCopyMap).toBitmap();
            picbox.Image = picboxCopyMap;
        }


        private void posteryzacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            PropQuestion propQuestion3 = new PropQuestion(EditMap, this, 3);
            propQuestion3.Show();
        }

        /*    do szaroodcieniowych
        -------------------------------------------------------------------------------------*/
        private void byRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picboxCopyMap = mypicture.toGrayScaleR();
            picbox.Image = picboxCopyMap;
        }

        private void byGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picboxCopyMap = mypicture.toGrayScaleG();
            picbox.Image = picboxCopyMap;
        }

        private void byBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picboxCopyMap = mypicture.toGrayScaleB();
            picbox.Image = picboxCopyMap;
        }

        private void średniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picboxCopyMap = mypicture.toGrayScaleMid();
            picbox.Image = picboxCopyMap;
        }


        /*    linia profilu
        -------------------------------------------------------------------------------------*/
        private void liniaProfiluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileLine profileLine = new ProfileLine(picboxCopyMap);
            profileLine.Show();
        }

        /*    nowe okienka
        -------------------------------------------------------------------------------------*/
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            try
            {//próba otwarcia pliku z obrazem
                dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.picboxCopyMap = new Bitmap(dialog.FileName);
                    this.picbox.Image = picboxCopyMap;
                    mypicture = new Picture(picboxCopyMap);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicForm pic = new PicForm();
            pic.Show();
            pic.replaceToolStripMenuItem_Click(sender, e);
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicForm pic = new PicForm(picboxCopyMap);
            pic.Show();
        }



        private void listaWszystkichOkienekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiplePictures mulpic = new MultiplePictures(formList);
            mulpic.Show();
        }

        private void twoPicturesModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiplePicturesMode mulpic = new MultiplePicturesMode();
            mulpic.Show();
        }

        private void maskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maski maski = new Maski();
            maski.Show();
        }


        /*    zadania morfologii
              -------------------------------------------------------------------------------------*/

        //    progowanie
        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> imgOld = picboxCopyMap.ToImage<Gray, byte>();
            imgOld = makeBinary(imgOld);
            picboxCopyMap = imgOld.ToBitmap();
            picbox.Image = imgOld.ToBitmap();
        }

        private void stałeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> imgOld = picboxCopyMap.ToImage<Gray, byte>();
            imgOld = makeBinary(imgOld);
            picboxCopyMap = imgOld.ToBitmap();
            picbox.Image = imgOld.ToBitmap();
        }

        private void wybierzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgQuest2 pg = new ProgQuest2(this, this.picboxCopyMap);
            pg.Show();
        }

        private void adaptacyjneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> imgOld = picboxCopyMap.ToImage<Gray, byte>();
            CvInvoke.AdaptiveThreshold(imgOld, imgOld, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC,ThresholdType.Binary,11,5 );
            picboxCopyMap = imgOld.ToBitmap();
            picbox.Image = imgOld.ToBitmap();
        }

        private void otsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> imgOld = picboxCopyMap.ToImage<Gray, byte>();
            CvInvoke.Threshold(imgOld, imgOld, 0, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
            picboxCopyMap = imgOld.ToBitmap();
            picbox.Image = imgOld.ToBitmap();
        }

        private void zPoziomamiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropQuestion propQuestion2 = new PropQuestion(picboxCopyMap, this, 2);
            propQuestion2.Show();
        }

        //    morfologia cd
        private void dylacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picboxCopyMap = mypicture.toGrayScaleB();
            var element = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(-1, -1));

            Image<Gray, byte> imgOld = picboxCopyMap.ToImage<Gray, byte>();
            imgOld = makeBinary(imgOld);
            Image<Gray, byte> imgNew = imgOld;
            CvInvoke.Dilate(imgOld, imgNew, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
            picboxCopyMap = imgNew.ToBitmap();
            picbox.Image = imgNew.ToBitmap();
        }

        private void erozjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var element = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(-1, -1));

            Image<Gray, byte> imgOld = picboxCopyMap.ToImage<Gray, byte>();
            imgOld = makeBinary(imgOld);
            Image<Gray, byte> imgNew = imgOld;
            CvInvoke.Erode(imgOld, imgNew, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
            picboxCopyMap = imgNew.ToBitmap();
            picbox.Image = imgNew.ToBitmap();
        }

        private void szkieletyzacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            Image<Gray, byte> imgOld = EditMap.ToImage<Gray, byte>();
            //imgOld=makeBinary(imgOld);
            Image<Gray, byte> img2 = (new Image<Gray, byte>(imgOld.Width, imgOld.Height, new Gray(255))).Sub(imgOld).Not();
            Image<Gray, byte> eroded = new Image<Gray, byte>(img2.Size);
            Image<Gray, byte> temp = new Image<Gray, byte>(img2.Size);
            Image<Gray, byte> skel = new Image<Gray, byte>(img2.Size);

            skel.SetValue(0);
            CvInvoke.Threshold(img2, img2, 127, 256, 0);
            var element = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
            bool done = false;

            while (!done)
            {
                CvInvoke.Erode(img2, eroded, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
                CvInvoke.Dilate(eroded, temp, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
                CvInvoke.Subtract(img2, temp, temp);
                CvInvoke.BitwiseOr(skel, temp, skel);
                eroded.CopyTo(img2);
                if (CvInvoke.CountNonZero(img2) == 0) done = true;
            }

            this.picboxCopyMap = skel.ToBitmap();
            picbox.Image = this.picboxCopyMap;
            picbox.Refresh();
        }


    }

}

