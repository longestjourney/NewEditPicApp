using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class Histogram
    {

            int[] RHistogram = new int[256];
            int[] GHistogram = new int[256];
            int[] BHistogram = new int[256];
            int[] AHistogram = new int[256];
            Bitmap lol;
            public Histogram(Bitmap lol)
            {
                this.lol = lol;
                for (int x = 0; x < this.lol.Width; ++x)
                {
                    for (int y = 0; y < this.lol.Height; ++y)
                    {
                        Color pixelColor = this.lol.GetPixel(x, y);
                        RHistogram[Convert.ToInt32(pixelColor.R.ToString())] += 1;
                        GHistogram[Convert.ToInt32(pixelColor.G.ToString())] += 1;
                        BHistogram[Convert.ToInt32(pixelColor.B.ToString())] += 1;
                        AHistogram[Convert.ToInt32(pixelColor.A.ToString())] += 1;
                    }
                }
            //to ma być jakby tworzenie histogramu - co zgadza się z ideą konstruktora
            }

    }
}
