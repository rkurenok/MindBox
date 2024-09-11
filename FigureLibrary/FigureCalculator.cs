using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class FigureCalculator
    {
        public double CalculateArea(Figure figure)
        {
            return figure.CalculateArea();
        }

        public bool IsRightTriangle(Triangle triangle)
        {
            double sideA = triangle.SideA, sideB = triangle.SideB, sideC = triangle.SideC;
            return Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2);
        }
    }
}
