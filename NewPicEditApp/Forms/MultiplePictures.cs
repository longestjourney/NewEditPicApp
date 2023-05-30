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
    public partial class MultiplePictures : Form
    {
        public MultiplePictures(List<PicForm> picsForms)
        {
            InitializeComponent();
            listBox1.Items.Clear();
            foreach (PicForm p in picsForms)
            {
                listBox1.Items.Add(p.ToString());
                ChoosePic1.Items.Add(p.ToString());
                ChoosePic2.Items.Add(p.ToString());
            }
            listBox1.SelectedIndex = 0;
            
        }
    }
}
