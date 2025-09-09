using Xunit;

namespace RectangleTestsForLab0102
{
    public class RectangleUnitTests
    {
        [Fact]
        public void AreaCommonTest()
        {
            var rec = new Rectangle(3, 5);

            var area = rec.Area;

            Assert.Equal(15, area);
        }

        [Fact]
        public void PerCommonTest()
        {
            var rec = new Rectangle(3, 5);

            var per = rec.Perimeter;

            Assert.Equal(16, per);
        }

        [Fact]
        public void AreaWithZeroTest()
        {
            var rec = new Rectangle(3, 0);

            var area = rec.Area;

            Assert.Equal(0, area);
        }

        [Fact]
        public void PerWithZeroTest()
        {
            var rec = new Rectangle(3, 0);

            var per = rec.Perimeter;

            Assert.Equal(6, per);
        }
    }
}
