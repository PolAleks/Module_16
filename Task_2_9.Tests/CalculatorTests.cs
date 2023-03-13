namespace Task_2_9.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void DivisionMustReturnDivideByZeroExceptoin()
        {
            Calculator calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}