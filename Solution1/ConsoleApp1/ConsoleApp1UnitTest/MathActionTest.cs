using NUnit.Framework;
using ConsoleApp1;
using System;

    class ConsoleAppTest
    {
        RegularTriangle  regularTriangletest = new RegularTriangle();
        RectangularTriangle rectangularTriangletest = new RectangularTriangle();
        EqualSidesTriangle equalSidesTriangletest = new EqualSidesTriangle();

        [Test]
        public void Angles_Sum_Test_RectangularTriangle()
        {
            Assert.That(MathActions.AnglesSum(rectangularTriangletest.AngleA,rectangularTriangletest.AngleB,rectangularTriangletest.AngleC),Is.LessThanOrEqualTo(180)); 
        }

        [Test]
        public void Angles_Sum_Test_EqualSidesTriangle()
        {
            Assert.That(MathActions.AnglesSum(equalSidesTriangletest.AngleA,equalSidesTriangletest.AngleB,equalSidesTriangletest.AngleC),Is.LessThanOrEqualTo(180));
        }

        [Test]
        public void Angles_Sum_Test_RegularTriangle()
        {
            Assert.That(MathActions.AnglesSum(regularTriangletest.AngleA,regularTriangletest.AngleB,regularTriangletest.AngleC),Is.LessThanOrEqualTo(180));
            
        }

        [Test]
        public void SidesSum_RectangularTriangle()
        {
            Assert.That(MathActions.SidesSum(rectangularTriangletest.SideA,rectangularTriangletest.SideB,rectangularTriangletest.SideC),Is.EqualTo(rectangularTriangletest.SideA+rectangularTriangletest.SideB+rectangularTriangletest.SideC));
        }

        [Test]
        public void SidesSum_RegularTriangle()
        {
            Assert.That(MathActions.SidesSum(regularTriangletest.SideA,regularTriangletest.SideB,regularTriangletest.SideC),Is.EqualTo(rectangularTriangletest.SideA+rectangularTriangletest.SideB+rectangularTriangletest.SideC));
        }
        [Test]
        public void SidesSum_EqualSidesTriangle()
        {
            Assert.That(MathActions.SidesSum(equalSidesTriangletest.SideA,equalSidesTriangletest.SideB,equalSidesTriangletest.SideC),Is.EqualTo(rectangularTriangletest.SideA+rectangularTriangletest.SideB+rectangularTriangletest.SideC));
        }

        [Test]
        public void MedianSizeCalculation_RegularTriangle()
        {
            Assert.That(()=>MathActions.MedianSizeCalculation(regularTriangletest.Type,regularTriangletest.SideC),Throws.TypeOf<System.Exception>().With.Message.EqualTo("The triangle is not EqualSide"));
        }
        [Test]
        public void MedianSizeCalculation_RectangularTriangle()
        {
            Assert.That(()=>MathActions.MedianSizeCalculation(rectangularTriangletest.Type,rectangularTriangletest.SideC),Throws.TypeOf<System.Exception>().With.Message.EqualTo("The triangle is not EqualSide"));
        }

        [Test]
        public void MedianSizeCalculation_EqualSidesTriangle()
        {
            Assert.That(MathActions.MedianSizeCalculation(equalSidesTriangletest.Type,equalSidesTriangletest.SideC),Is.EqualTo((equalSidesTriangletest.SideC * Math.Sqrt(3)) / 2));
        }
    }