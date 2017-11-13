using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Rectangle
    {
        private int _width;
        private int _height;

        public int width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
    }
}
