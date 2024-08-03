namespace TestTBC
{
    [TestFixture]
    public class TestTCB
    {
        public Dayso _calculator;
        [SetUp]
        public void SetUp()
        {
            _calculator = new Dayso();
        }
        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new double[] { 10, 20, 30, 40, 50 }, 30)]
        [TestCase(new double[] { -1, -2, -3, -4, -5 }, -3)]
        [TestCase(new double[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new double[] { 1.5, 2.5, 3.5, 4.5, 5.5 }, 3.5)]
        [TestCase(new double[] { 100, 200, 300, 400, 500 }, 300)]
        [TestCase(new double[] { 1 }, 1)]
        [TestCase(new double[] { 1, -1 }, 0)]
        [TestCase(new double[] { 1, 2, 3 }, 2)]
        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5.5)]
        public void CalculateAverage_ValidInput_ReturnsCorrectAverage(double[] numbers, double expectedAverage)
        {
            // Act
            var result = _calculator.CalculateAverage(new List<double>(numbers));

            // Assert
            Assert.AreEqual(expectedAverage, result);
        }

        [Test]
        public void CalculateAverage_EmptyList_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalculateAverage(new List<double>()));
        }

        [Test]
        public void CalculateAverage_NullList_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalculateAverage(null));
        }
    }
}
   

