﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorypattern
{
    class rectangle : Ishape
    {
        public double length = 5;
        public double width = 4;
        public double area()
        {
            return length * width;
        }
        public double perimeter()
        {
            return 2 * (length + width);
        }
    }
}

