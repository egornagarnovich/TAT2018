using NUnit.Framework;
namespace DEV3
{
    [TestFixture()]
    public class NumberConverterTests
    {
        [Test()]
        public void Add_PossitiveEvenNumber_And_EvenNumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 156;
            const int numberNewSystemRadix = 2;

            //Act
            var actual = converter.ConvertToDifferentNumberSystems(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("10011100", actual);
        }

        [Test()]
        public void Add_NegativeEvenNumber_And_EvenNumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = -156;
            const int numberNewSystemRadix = 2;

            //Act
            var actual = converter.ConvertToDifferentNumberSystems(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("10011100", actual);
        }

        [Test()]
        public void Add_ZeroNumber_And_NumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 0;
            const int numberNewSystemRadix = 2;

            //Act
            var actual = converter.ConvertToDifferentNumberSystems(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("0", actual);
        }

        [Test()]
        public void Add_PossitiveOddNumber_And_EvenNumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 123;
            const int numberNewSystemRadix = 4;

            //Act
            var actual = converter.ConvertToDifferentNumberSystems(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("1323", actual);
        }

        [Test()]
        public void Add_PossitiveOddNumber_And_OddNumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 123;
            const int numberNewSystemRadix = 3;

            //Act
            var actual = converter.ConvertToDifferentNumberSystems(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("11120", actual);
        }

        private NumberConverter CreateObjectNumberConverter()
        {
            return new NumberConverter();
        }
    }
}
