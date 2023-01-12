using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class Picture
    {
        private Bitmap mypicture;
        public int width { get; private set; }
        public int height { get; private set; }
        public Histogram histogram { get; private set; }
        private bool grayscale;

        public Picture(Bitmap mypicture)
        {
            this.mypicture = mypicture;
            width = mypicture.Width; //jest to chyba dość wtórne ale skraca zapis wewnątrz tej klasy
            height = mypicture.Height;
            makeHistogram();
        }

        //moze to byc void i po prostu przypisanie do powyższej zmiennej, bo wtedy ten histogram bylby przypisany do obiektu
        public void makeHistogram()
        {
            histogram = new Histogram(mypicture);
        }


        public bool isGrayScale()
        {
            bool is_gray_scale = true;
            int[,] trueHistogram = histogram.FHistogram;
            for (int i = 0; i < 256; ++i)
            {
                if ((trueHistogram[i,0] == trueHistogram[i, 1]) && (trueHistogram[i, 0] == trueHistogram[i, 2]))
                {
                    is_gray_scale &= true;
                }
                else
                {
                    is_gray_scale &= false;
                }
            }
            return is_gray_scale;
        }

        public Bitmap toBitmap()
        {
            return mypicture;
        }
    }
}
