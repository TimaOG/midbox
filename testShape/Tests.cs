using NUnit.Framework;
using NUnit.Framework.Internal;
using Shape;

namespace ShapeTest
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleArea_CorrectCalculation()
        {
            var circle = new Circle(5);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(78.53981633974483, circle.CalculateArea(), 1e-10);
        }

        [Test]
        public void TriangleArea_CorrectCalculation()
        {
            var triangle = new Triangle(3, 4, 5);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(6, triangle.CalculateArea(), 1e-10);
        }

        [Test]
        public void TriangleIsRightAngled_CorrectCheck()
        {
            var triangle = new Triangle(3, 4, 5);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(triangle.IsRightAngled());

            var nonRightTriangle = new Triangle(5, 5, 8);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(nonRightTriangle.IsRightAngled());
        }

        [Test]
        public void InvalidTriangleSides_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));
        }
    }
}

