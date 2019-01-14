using System;
using NUnit.Framework;

namespace ConsoleApp1
{
    [TestFixture]
    class AngleSumTest
    {
        RegularTriangle RegTr = new RegularTriangle();
        RectangularTriangle RecTr = new RectangularTriangle();
        EqualSidesTriangle EqTr = new EqualSidesTriangle();

        public void AnglesSumTestRegularTriangle()
        {
            Assert.That(MathActions.AnglesSum(RegTr.AngleA, RegTr.AngleB, RegTr.AngleC), Is.EqualTo(180));
        }

        public void AnglesSumTestRectangularTriangle()
        {
            Assert.That(MathActions.AnglesSum(RecTr.AngleA, RecTr.AngleB, RecTr.AngleC), Is.EqualTo(180));
        }

        public void AnglesSumTestEqualSidesTriangle()
        {
            Assert.That(MathActions.AnglesSum(EqTr.AngleA, EqTr.AngleB, EqTr.AngleC), Is.EqualTo(180));
        }
    }

    class SidesSumeTest
    {
        RegularTriangle RegTr = new RegularTriangle();
        RectangularTriangle RecTr = new RectangularTriangle();
        EqualSidesTriangle EqTr = new EqualSidesTriangle();

        public void SidesSumTestRegularTriangle()
        {
            Assert.That(MathActions.SidesSum(RegTr.SideA, RegTr.SideB, RegTr.SideC), Is.EqualTo(RegTr.SideA + RegTr.SideB + RegTr.SideC));
        }

        public void SidesSumTestRectangularTriangle()
        {
            Assert.That(MathActions.SidesSum(RecTr.SideA, RecTr.SideB, RecTr.SideC), Is.EqualTo(RecTr.SideA + RecTr.SideB + RecTr.SideC));
        }

        public void SidesSumTestEqualSidesTriangle()
        {
            Assert.That(MathActions.SidesSum(EqTr.SideA, EqTr.SideB, EqTr.SideC), Is.EqualTo(EqTr.SideA + EqTr.SideB + EqTr.SideC));
        }
    }
   
}


