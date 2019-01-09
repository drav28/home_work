using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    [TestFixture]
    public class Tests
    {
        // Тест для проверки суммы сторон, тестируем метод SidesSum()
        [Test]
        public void SidesSumTest()
        {
            Assert.AreEqual(8, MathActions.SidesSum(2, 2, 4));
        }

        // Тест для проверки суммы углов, тестируем метод AnglesSum()
        [Test]
        public void AnglesSumTest()
        {
            Assert.AreEqual(180, MathActions.AnglesSum(60, 60 , 60));
        }

        // Тест для проверки суммы углов, тестируем метод AnglesSum().
        // Подаем на вход несуществующий треугольник (сумма углов 190 градусов). 
        // Ожидаем, что тест упадет.
        [Test]
        public void AnglesSumWrongTriangleTest()
        {
            Assert.AreEqual(180, MathActions.AnglesSum(70, 60, 60));
        }

        // Тест для проверки расчета медианы равностороннего треугольника
        [Test]
        public void MedianSizeCalculationEqualTest()
        {
            Assert.AreEqual((60 * System.Math.Sqrt(3)) / 2, MathActions.MedianSizeCalculation("equalSides", 60));
        }

        // Тест для проверки расчета медианы прямоугольного треугольника.
        // Ожидаем, что тест упадет,
        // в методе MedianSizeCalculation() не предусмотрен тип треугольника "rectangular".
        [Test]
        public void MedianSizeCalculationRectangularTest()
        {
            Assert.AreEqual((30 * System.Math.Sqrt(3)) / 2, MathActions.MedianSizeCalculation("rectangular", 30));
        }
    }
}