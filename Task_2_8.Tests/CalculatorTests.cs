namespace Task_2_8.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void DivisionMustReturn10Value()
        {
            int expectedValue = 10;

            Calculator calculator = new Calculator();

            Assert.True(expectedValue == calculator.Division(100, 10));
        }
    }
}