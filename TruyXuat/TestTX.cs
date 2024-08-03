namespace TruyXuat
{
    [TestFixture]
    public class ArrayHelperTests
    {
        private ArrayHelper _arrayHelper;

        [SetUp]
        public void SetUp()
        {
            _arrayHelper = new ArrayHelper();
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 5)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 2, 30)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 3, -4)]
        [TestCase(new int[] { 100, 200, 300 }, 1, 200)]
        public void GetElementAtIndex_ValidIndex_ReturnsCorrectElement(int[] array, int index, int expected)
        {
            // Act
            var result = _arrayHelper.GetElementAtIndex(array, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, -1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 10)]
        public void GetElementAtIndex_InvalidIndex_ThrowsArgumentOutOfRangeException(int[] array, int index)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _arrayHelper.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_NullArray_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _arrayHelper.GetElementAtIndex(null, 0));
        }

        [Test]
        public void GetElementAtIndex_EmptyArray_ThrowsArgumentOutOfRangeException()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _arrayHelper.GetElementAtIndex(new int[] { }, 0));
        }
    }
}