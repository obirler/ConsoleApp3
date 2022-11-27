
namespace ConsoleApp3UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRectangleArea()
        {
            var rect = new ConsoleApp3.Rectangle(5, 10);

            var area = rect.GetArea();

            Assert.AreEqual(area, 50);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            var rect = new ConsoleApp3.Rectangle(5, 10);

            var per = rect.GetPerimeter();

            Assert.AreEqual(per, 30);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            var circ = new ConsoleApp3.Circle(10);

            var area = circ.GetArea();

            Assert.AreEqual(area, Math.PI*100);
        }

        [TestMethod]
        public void TestCirclePerimeter()
        {
            var circ = new ConsoleApp3.Circle(10);

            var per = circ.GetPerimeter();

            Assert.AreEqual(per, 2*Math.PI*10);
        }
    }
}