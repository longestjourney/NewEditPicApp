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
    public partial class Form2 : Form
    {
        Image<Gray, byte> image;
        Bitmap aaa;
        public Form2(Image<Gray,byte> image)
        {
            this.image = image;
            aaa=image.ToBitmap();
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureok.Image = aaa;
        }
    }
}
