using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibraryTests
{
    public class FigureCalculatorTests
    {
        private FigureCalculator calculator = new FigureCalculator();

        [Test]
        public void CircleArea_ValidRadius_CorrectCalculation()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            Assert.That(calculator.CalculateArea(circle), Is.EqualTo(Math.PI * radius * radius));
        }

        [Test]
        public void TriangleArea_ValidSides_CorrectCalculation()
        {
            double[] sides = { 3, 4, 5 };
            Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
            Assert.That(calculator.CalculateArea(triangle), Is.EqualTo(6).Within(0.001));
        }

        [Test]
        public void IsRightTriangle_PythagoreanTriplet_ReturnsTrue()
        {
            Assert.That(calculator.IsRightTriangle(new Triangle(3, 4, 5)), Is.True);
        }

        [Test]
        public void IsRightTriangle_NotRight_ReturnsFalse()
        {
            Assert.That(calculator.IsRightTriangle(new Triangle(2, 3, 4)), Is.False);
        }
    }
}
