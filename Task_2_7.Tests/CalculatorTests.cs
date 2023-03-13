namespace Task_2_7.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void SubstractionMustReturns20Value()
        {
            int expectedValue = 10;

            Calculator calculator = new Calculator();
            int actualValue = calculator.Substraction(20, 10);

            Assert.Equal(expectedValue, actualValue);
        }
    }
}