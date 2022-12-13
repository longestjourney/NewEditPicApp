using System;
using System.Buffers;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPicEditApp
{
    abstract internal class PictureCreator
    {
        Dictionary<string, PictureMake> pictures = new Dictionary<string, PictureMake>();
        

        private static interface PictureMake
        {
             Picture Make(Bitmap bitmap);
        }
        public static Picture Make(Dictionary<string, PictureMake> pictures, Bitmap bitmap)
        {
            return pictures.V.Make(bitmap);
        }
    }
}
}
