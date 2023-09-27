using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorypattern
{
    class shapefactory
    {
        public static Ishape createshape(string shapetype)
        {
            switch (shapetype.ToLower())
            {
                case "circle":
                    return new circle();
                case "square":
                    return new square();
                case "rectangle":
                    return new rectangle();
                default:
                    throw new ArgumentException("invalid shape type");

            }

        }

    }
}