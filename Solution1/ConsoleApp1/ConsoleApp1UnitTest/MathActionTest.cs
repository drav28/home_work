using System;
using NUnit.Framework;
using ConsoleApp1;


    [TestFixture]
    class SideSumeTest
    {
        [TestCase(1,1,1,3)]
        [TestCase(2,2,-2,2)]
        [TestCase(2,2,0,4)]
        [TestCase(0.2,0.2,0.5,0.9)]
        public void Side_Sume_Test (double a, double b, double c, double d)
        {
            var result = MathActions.SidesSum (a,b,c);
            Assert.That (d, Is.EqualTo(result));
        }
    }

    class MedianaSizeCalculationTest_TypeRegular
    {
        [TestCase("equalSides",3,2.598076211353316d)]
        [TestCase("equalSides",-2,-1.7320508075688772d)]
        [TestCase("equalSides",0,0)]
        public void MedianaSizeCalculation_TypeEqualRegular(string type, double side, double d)
        {
            var result = MathActions.MedianSizeCalculation(type,side);
            Assert.That (d, Is.EqualTo(result));
        }
    }

    //[Ignore("TestIgnor")]
    class MedianaSizeCalculationTest_TypeNotRegular
    {
        [Test]
        public void MedianaSizeCalculation_TypeNotEqualRegular()
        {
              Assert.That(()=> MathActions.MedianSizeCalculation("tra",4), Throws.TypeOf<Exception>().With.Message.EqualTo("The triangle is not EqualSide"));   
        }
    }

    class AnglesSumTest
    {
        [TestCase(1,1,1,3)]
        [TestCase(-1,-1,-1,-3)]
        [TestCase(1,1,0.2,2.2)]
        [TestCase(1,1,0,2)]
        public void Angles_Sum_test(double a, double b, double c, double d)
        {
            var result = MathActions.AnglesSum(a,b,c);
            Assert.That (d,Is.EqualTo(result));
        }
    }