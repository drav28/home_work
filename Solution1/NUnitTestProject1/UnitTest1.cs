using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    [TestFixture]
    public class Tests
    {
        // ���� ��� �������� ����� ������, ��������� ����� SidesSum()
        [Test]
        public void SidesSumTest()
        {
            Assert.AreEqual(8, MathActions.SidesSum(2, 2, 4));
        }

        // ���� ��� �������� ����� �����, ��������� ����� AnglesSum()
        [Test]
        public void AnglesSumTest()
        {
            Assert.AreEqual(180, MathActions.AnglesSum(60, 60 , 60));
        }

        // ���� ��� �������� ����� �����, ��������� ����� AnglesSum().
        // ������ �� ���� �������������� ����������� (����� ����� 190 ��������). 
        // �������, ��� ���� ������.
        [Test]
        public void AnglesSumWrongTriangleTest()
        {
            Assert.AreEqual(180, MathActions.AnglesSum(70, 60, 60));
        }

        // ���� ��� �������� ������� ������� ��������������� ������������
        [Test]
        public void MedianSizeCalculationEqualTest()
        {
            Assert.AreEqual((60 * System.Math.Sqrt(3)) / 2, MathActions.MedianSizeCalculation("equalSides", 60));
        }

        // ���� ��� �������� ������� ������� �������������� ������������.
        // �������, ��� ���� ������,
        // � ������ MedianSizeCalculation() �� ������������ ��� ������������ "rectangular".
        [Test]
        public void MedianSizeCalculationRectangularTest()
        {
            Assert.AreEqual((30 * System.Math.Sqrt(3)) / 2, MathActions.MedianSizeCalculation("rectangular", 30));
        }
    }
}