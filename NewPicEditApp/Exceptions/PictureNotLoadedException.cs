using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class PictureNotLoadedException : Exception
    {
        public PictureNotLoadedException() { }

        public PictureNotLoadedException(string message) : base(message) { }
    }
}
