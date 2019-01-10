using NUnit.Framework;
using ConsoleApp1;

class Tests
{
    RegularTriangle regularTriangle = new RegularTriangle();
    EqualSidesTriangle equalSidesTriangle = new EqualSidesTriangle();
    RectangularTriangle rectangularTriangle = new RectangularTriangle();

    [Test]
    public void Angles_Sum_Test_RegularTriangle()
    {
        Assert.That(MathActions.AnglesSum(regularTriangle.AngleA, regularTriangle.AngleB, regularTriangle.AngleC), Is.EqualTo(180));
    }
    [Test]
    public void Angles_Sum_Test_EqualSidesTriangle()
    {
        Assert.That(MathActions.AnglesSum(equalSidesTriangle.AngleA, equalSidesTriangle.AngleB, equalSidesTriangle.AngleC), Is.EqualTo(180));
    }
    [Test]
    public void Angles_Sum_Test_RectangularTriangle()
    {
        Assert.That(MathActions.AnglesSum(rectangularTriangle.AngleA, rectangularTriangle.AngleB, rectangularTriangle.AngleC), Is.EqualTo(180));
    }
}