namespace TestsForLab01Part03
{
    public class FigureTests
    {
        [Fact]
        public void LengthSideCommonTest()
        {
            var fig = new Figure(new Point(0, 0), new Point(4, 3), new Point(15, 8));

            double res = fig.LengthSide(new Point(0, 0), new Point(3, 4));

            Assert.True(Math.Abs(res - 5.0) < 0.000001);
        }

        [Fact]
        public void LengthSideCommonTest2()
        {
            var fig = new Figure(new Point(0, 0), new Point(4, 3), new Point(15, 8));

            double res = fig.LengthSide(new Point(5, 12), new Point(10, 15));

            Assert.True(Math.Abs(res - 5.8309518948) < 0.000001);
        }

        [Fact]
        public void PerimeterCalculatorCommonTest()
        {
            var fig = new Figure(new Point(0, 0), new Point(4, 3), new Point(15, 8));

            double res = fig.PerimeterCalculator();

            Assert.True(Math.Abs(res - 34.08304597359457) < 0.000001);
        }

        [Fact]
        public void PerimeterCalculatorCommonTest2()
        {
            var fig = new Figure(new Point(0, 0), new Point(4, 3), new Point(15, 8), new Point(23, -61), new Point(-100, -100));

            double res = fig.PerimeterCalculator();

            Assert.True(Math.Abs(res - 357.0015011637925) < 0.000001);
        }
    }
}
