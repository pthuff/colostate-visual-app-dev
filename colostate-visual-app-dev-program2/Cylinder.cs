using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cylinder class
// Class for calculating the area and volume of a cylinder
// Paul Huff
// Sept 4, 2018
// Modified Sept 4, 2018

namespace PHuffProgram2
{
    class Cylinder
        // Calculate the area and/or volume and return value
    {
        public double CalcArea(int radiusOfCylinder, int heightOfCylinder)
        {
            return (2 * Math.PI * Math.Pow(radiusOfCylinder, 2)) + (2 * Math.PI * radiusOfCylinder * heightOfCylinder);
        }
        public double CalcVolume(int radiusOfCylinder, int heightOfCylinder)
        {
            return Math.PI * Math.Pow(radiusOfCylinder, 2) * heightOfCylinder;
        }
    }
    
}
