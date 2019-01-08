using System;
using ConsoleApp1;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {     
        private ITriangle _equalSides;
        private ITriangle _rectangular;
        private ITriangle _regular;
        
        [SetUp]
        public void Setup()
        {
            _equalSides = new EqualSidesTriangle();
            _rectangular = new RectangularTriangle();
            _regular = new RegularTriangle();
        }

        [TestCase(40, 70, 70, 180)]
        [TestCase(60, 60, 100, 220)]
        [TestCase(0, -60, 100, 40)]
        public void AnglesSum_ReturnsSum(double a, double b, double c, double sum)
        {
            Assert.AreEqual(sum, MathActions.AnglesSum(a, b, c));
        }
        
        [Test]
        public void TrianglesDefaultAnglesSum_IsCorrect()
        {
            Assert.AreEqual(180, MathActions.AnglesSum(_equalSides.AngleA, _equalSides.AngleB, _equalSides.AngleC));
            Assert.AreEqual(180, MathActions.AnglesSum(_rectangular.AngleA, _rectangular.AngleB, _rectangular.AngleC));
            // у regular-треугольника сумма углов не равна 180 - тест упадет.
            Assert.AreEqual(180, MathActions.AnglesSum(_regular.AngleA, _regular.AngleB, _regular.AngleC));
        }
        
        [TestCase(5, 10, 15, 30)]
        [TestCase(5.5, 20, 10, 35.5)]
        [TestCase(0.2, 2, 10, 12.2)]
        public void SidesSum_ReturnsSum(double a, double b, double c, double sum)
        {
            Assert.AreEqual(sum, MathActions.SidesSum(a, b, c));
        }
             
        [Test]
        public void DefaultEqualAngles_AllAnglesEqual() 
        {
            var t = _equalSides;
            Assert.IsTrue(t.AngleA == t.AngleB && t.AngleA == t.AngleC && t.AngleB == t.AngleC);
        }
        

        [Test]
        public void DefaultEqualSides_AllSidesEqual() 
        {
            var t = _equalSides;
            Assert.IsTrue(t.SideA == t.SideB && t.SideA == t.SideC && t.SideB == t.SideC);
        }
        
        [Test]
        public void DefaultRectangular_Has90Angle()
        {
            var t = _rectangular;
            Assert.IsTrue(t.AngleA == 90 || t.AngleB == 90 || t.AngleC == 90);
      
        }
        
        [Test]
        public void MedianSizeCalculation_NotEqualSides_Throws()
        {
            Assert.Throws<Exception>(() => MathActions.MedianSizeCalculation(_rectangular.Type, _rectangular.SideA));
            Assert.Throws<Exception>(() => MathActions.MedianSizeCalculation(_regular.Type, _regular.SideA));
            Assert.DoesNotThrow(() => MathActions.MedianSizeCalculation(_equalSides.Type, _equalSides.SideA));
        }
        
        [TestCase(4, 3.464)]
        [TestCase(2.6, 2.252)]
        [TestCase(7.1, 6.149)]
        public void MedianSizeCalculation_ReturnsMedian(double side, double median)
        {
            Assert.AreEqual(median, MathActions.MedianSizeCalculation(_equalSides.Type, side), 0.001);
        }
    }
}