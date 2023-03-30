using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    public partial class PicForm : Form
    {
        OpenFileDialog dialog = new OpenFileDialog();
        int[] RHistogram = new int[256];
        int[] GHistogram = new int[256];
        int[] BHistogram = new int[256];
        int[] AHistogram = new int[256];
        internal bool is_grayscale;
        int min;
        int max;
        double cumulativesum = 0;
        internal Bitmap picboxCopyMap;
        internal Bitmap picboxCopyMap2;
        internal Bitmap picboxCopyMapOut;
        public PicForm() { InitializeComponent(); }
        private void PicForm_Load(object sender, EventArgs e) { }
        private void bOpen_Click(object sender, EventArgs e)
        {
            try
            {//próba otwarcia pliku z obrazem
                dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.picbox.Image = new Bitmap(dialog.FileName);
                    //czyszczenie tablic histogramów żeby przy załadowaniu nowego obrazka były puste
                    TablesMethods.ZeroTables(RHistogram);
                    TablesMethods.ZeroTables(GHistogram);
                    TablesMethods.ZeroTables(BHistogram);
                    TablesMethods.ZeroTables(AHistogram);
                    cumulativesum = 0;

                    //histogram musi tu zaczac istniec
                    this.picboxCopyMap = new Bitmap(dialog.FileName);
                    for (int x = 0; x < this.picboxCopyMap.Width; ++x)
                    {
                        for (int y = 0; y < this.picboxCopyMap.Height; ++y)
                        {
                            Color pixelColor = this.picboxCopyMap.GetPixel(x, y);
                            RHistogram[Convert.ToInt32(pixelColor.R.ToString())] += 1;
                            GHistogram[Convert.ToInt32(pixelColor.G.ToString())] += 1;
                            BHistogram[Convert.ToInt32(pixelColor.B.ToString())] += 1;
                            AHistogram[Convert.ToInt32(pixelColor.A.ToString())] += 1;
                        }
                    }
                    cumulativesum = Width * Height;
                    is_grayscale = TablesMethods.IsGrayScale(RHistogram, GHistogram, BHistogram);
                    min = TablesMethods.MinTable(RHistogram);
                    max = TablesMethods.MaxTable(RHistogram);
                    this.picboxCopyMap = picboxCopyMap;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void co_histogram_operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.picboxCopyMap != null)
            {

                switch (co_histogram_operations.SelectedIndex)
                {
                    case 0: //pokaz histogram
                        //czyszczenie tablic histogramów żeby przy załadowaniu nowego obrazka były puste

                        TablesMethods.ZeroTables(RHistogram);
                        TablesMethods.ZeroTables(GHistogram);
                        TablesMethods.ZeroTables(BHistogram);
                        TablesMethods.ZeroTables(AHistogram);

                        //histogram musi tu zaczac istniec


                        for (int x = 0; x < picboxCopyMap.Width; ++x)
                        {
                            for (int y = 0; y < picboxCopyMap.Height; ++y)
                            {
                                Color pixelColor = picboxCopyMap.GetPixel(x, y);
                                RHistogram[Convert.ToInt32(pixelColor.R.ToString())] += 1;
                                GHistogram[Convert.ToInt32(pixelColor.G.ToString())] += 1;
                                BHistogram[Convert.ToInt32(pixelColor.B.ToString())] += 1;
                                AHistogram[Convert.ToInt32(pixelColor.A.ToString())] += 1;
                            }
                        }
                        HistogramForm histogram = new HistogramForm(RHistogram, GHistogram, BHistogram, AHistogram, is_grayscale);
                        histogram.Show();
                        break;
                    case 1: //rozciagnij histogram
                        Bitmap EditMap = new Bitmap(this.picboxCopyMap);
                        is_grayscale = TablesMethods.IsGrayScale(RHistogram, GHistogram, BHistogram);
                        if (is_grayscale)
                        {
                            for (int x = 0; x < EditMap.Width; ++x)
                            {
                                for (int y = 0; y < EditMap.Height; ++y)
                                {
                                    Color pixelColor = EditMap.GetPixel(x, y);
                                    if (pixelColor.R < min)
                                    {
                                        Color newColor = Color.FromArgb(0, 0, 0);
                                        EditMap.SetPixel(x, y, newColor);
                                    }
                                    else if (pixelColor.R > max)
                                    {

                                        Color newColor = Color.FromArgb(255, 255, 255);
                                        EditMap.SetPixel(x, y, newColor);
                                    }
                                    else
                                    {
                                        Color newColor = Color.FromArgb(
                                            Math.Abs((pixelColor.R) - min) * ((255) / (max - min)),
                                            Math.Abs((pixelColor.G) - min) * ((255) / (max - min)),
                                            Math.Abs((pixelColor.B) - min) * ((255) / (max - min)));

                                        EditMap.SetPixel(x, y, newColor);
                                    }

                                }
                                this.picboxCopyMap = EditMap;
                                picbox.Image = this.picboxCopyMap;
                            }
                        }
                        else MessageBox.Show("Obraz musi być szaroodcieniowy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2: //equalizacja

                        EditMap = new Bitmap(this.picboxCopyMap);
                        double[] normalhist = new double[256];

                        for (int i = 0; i < normalhist.Length; i++)
                        {
                            int numberofk = RHistogram[i];
                            normalhist[i] = (double)numberofk / (cumulativesum);
                        }
                        for (int x = 0; x < EditMap.Width; ++x)
                        {
                            for (int y = 0; y < EditMap.Height; ++y)
                            {
                                double suma = 0;
                                Color pixelColor = EditMap.GetPixel(x, y);
                                int k = pixelColor.R;
                                for (int n = 0; n <= k; ++n)
                                {
                                    suma += normalhist[n];
                                }
                                suma = suma * (max - min);
                                if (Math.Floor(suma) > 255)
                                {
                                    Color newColor = Color.FromArgb(255, 255, 255);
                                    EditMap.SetPixel(x, y, newColor);
                                }

                                else
                                {
                                    Color newColor = Color.FromArgb((int)Math.Floor(suma), (int)Math.Floor(suma), (int)Math.Floor(suma));
                                    EditMap.SetPixel(x, y, newColor);
                                }
                            }
                        }
                        this.picboxCopyMap = EditMap;
                        picbox.Image = this.picboxCopyMap;
                        break;

                    default: break;
                }
            }
            else { MessageBox.Show("Nie wybrano obrazu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void co_onepoint_operations_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (co_onepoint_operations.SelectedIndex)
            {
                case 0:
                    //to negatyw

                    Bitmap EditMap = new Bitmap(this.picboxCopyMap);
                    for (int x = 0; x < EditMap.Width; ++x)
                    {
                        for (int y = 0; y < EditMap.Height; ++y)
                        {
                            Color pixelColor = EditMap.GetPixel(x, y);
                            Color newColor = Color.FromArgb(0xff - pixelColor.R
                           , 0xff - pixelColor.G, 0xff - pixelColor.B);
                            EditMap.SetPixel(x, y, newColor);

                        }
                    }
                    this.picboxCopyMap = EditMap;
                    picbox.Image = this.picboxCopyMap;
                    break;
                case 1:
                    // z domyślnym progiem który jest połową dostępnych szarości
                    EditMap = new Bitmap(this.picboxCopyMap);
                    PropQuestion propQuestion = new PropQuestion(EditMap, this, 1);
                    propQuestion.Show();

                    break;
                case 2:
                    // z domyślnym progiem który jest połową dostępnych szarości
                    EditMap = new Bitmap(this.picboxCopyMap);
                    PropQuestion propQuestion2 = new PropQuestion(EditMap, this, 2);
                    propQuestion2.Show();

                    break;
                case 3:
                    EditMap = new Bitmap(this.picboxCopyMap);
                    PropQuestion propQuestion3 = new PropQuestion(EditMap, this, 3);
                    propQuestion3.Show();

                    break;
                case 4:
                    EditMap = new Bitmap(this.picboxCopyMap);
                    PropQuestion propQuestion4 = new PropQuestion(EditMap, this, 4);
                    propQuestion4.Show();
                    break;
                default:
                    break;
            }
        }

        private void comboBoxsz_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxsz.SelectedIndex)
            {
                case 0:
                    Bitmap EditMap = new Bitmap(this.picboxCopyMap);
                    Image<Gray, byte> imgOld = EditMap.ToImage<Gray, byte>();

                    Image<Gray, byte> img2 = (new Image<Gray, byte>(imgOld.Width, imgOld.Height, new Gray(255))).Sub(imgOld).Not();
                    Image<Gray, byte> eroded = new Image<Gray, byte>(img2.Size);
                    Image<Gray, byte> temp = new Image<Gray, byte>(img2.Size);
                    Image<Gray, byte> skel = new Image<Gray, byte>(img2.Size);

                    skel.SetValue(0);
                    CvInvoke.Threshold(img2, img2, 160, 255, 0);
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
                    break;
                case 1:
                    EditMap = new Bitmap(this.picboxCopyMap);
                    Image<Gray, byte> img = EditMap.ToImage<Gray, byte>();
                    var mask = img.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
                    Mat distance_transform = new Mat();
                    CvInvoke.DistanceTransform(mask, distance_transform, null, Emgu.CV.CvEnum.DistType.L2, 3);
                    CvInvoke.Normalize(distance_transform, distance_transform, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);
                    CvInvoke.Threshold(distance_transform, distance_transform, 0.7, 255, ThresholdType.Binary);


                    var markers = distance_transform.ToImage<Gray, byte>().ThresholdBinary(new Gray(50), new Gray(255));
                    CvInvoke.ConnectedComponents(markers, markers);
                    var final_markers = markers.Convert<Gray, Int32>();
                    CvInvoke.Watershed(img, final_markers);
                    Image<Gray, byte> boundaries = final_markers.Convert<byte>(delegate (Int32 x)
                    {
                        return (byte)(x == -1 ? 255 : 0);
                    });
                    boundaries._Dilate(1);
                    img.SetValue(0, boundaries);
                    this.picboxCopyMap = img.ToBitmap();
                    picbox.Image = this.picboxCopyMap;
                    picbox.Refresh();
                    break;
            }
        }

        private void bOpen2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodatkowe zdjęcie do operacji dla dwóch obrazów lub jako porównanie do oryginalnego, na tym obrazku nie będą działać pozostałe operacje.", "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {//próba otwarcia pliku z obrazem
                dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.picturebox2.Image = new Bitmap(dialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.picboxCopyMap2 = new Bitmap(dialog.FileName);
            //Bitmap EditMap = new Bitmap(this.picboxCopyMap2);



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Bitmap EditMap = new Bitmap(this.picboxCopyMap);
                Image<Gray, byte> EditTable1 = EditMap.ToImage<Gray, byte>();
                Bitmap EditMap2 = new Bitmap(this.picboxCopyMap2);
                Image<Gray, byte> EditTable2 = EditMap2.ToImage<Gray, byte>();
                Bitmap EditMap3 = new Bitmap(this.picboxCopyMap);
                Image<Gray, byte> EditTableOut = EditMap.ToImage<Gray, byte>();

                switch (comboBox2.SelectedIndex)
                {
                    case 0: //dodawanie
                        CvInvoke.Add(EditTable1, EditTable2, EditTableOut);
                        Form2 form0 = new Form2(EditTableOut);
                        form0.Show();
                        break;
                    case 1: //odejmowanie
                        CvInvoke.Subtract(EditTable1, EditTable2, EditTableOut);

                        Form2 form1 = new Form2(EditTableOut);
                        form1.Show();
                        break;
                    //case 2: //blend
                    //        //CvArray arrat = new Emgu.CV.CvArray();
                    //        //CvInvoke.Subtract(EditTable1, EditTable2, EditTableOut);
                    //        //CvInvoke.BlendLinear(EditTable1, EditTable2,list, EditTableOut);
                    //        //Form2 form2 = new Form2(EditTableOut);
                    //        //form2.Show();
                    //        //break;


                    case 2: //NOT
                            //tu jest progowanie obydwu obrazków
                        PropQuestion2 okquestion = new PropQuestion2(EditMap, EditMap2, this, 3);
                        okquestion = new PropQuestion2(EditMap, EditMap2, this, 3);
                        okquestion.Show();

                        break;
                    case 3: //AND
                            //tu jest progowanie obydwu obrazków
                        okquestion = new PropQuestion2(EditMap, EditMap2, this, 4);
                        okquestion.Show();

                        break;
                    case 4: //OR
                            //tu jest progowanie obydwu obrazków
                        okquestion = new PropQuestion2(EditMap, EditMap2, this, 5);
                        okquestion.Show();

                        break;
                    case 5: //XOR
                            //tu jest progowanie obydwu obrazków
                        okquestion = new PropQuestion2(EditMap, EditMap2, this, 6);
                        okquestion.Show();

                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wczytano poprawnie obydwu obrazków!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            //    Image<Gray, byte> EditTable1 = EditMap.ToImage<Gray, byte>();
                
            //    Bitmap EditMap3 = new Bitmap(this.picboxCopyMap);
            //    Image<Gray, byte> EditTableOut = EditMap.ToImage<Gray, byte>();
            //    Point startPoint = new Point(0,0);
            //    switch (comboBox1.SelectedIndex)
            //    {
            //        case 0:
            //            CvInvoke.Blur(EditTable1, EditTableOut, 5, startPoint);
            //            break;
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Nie wczytano poprawnie obydwu obrazków!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                picboxCopyMap.Save(sf.FileName);
            }

        }
    }
}

