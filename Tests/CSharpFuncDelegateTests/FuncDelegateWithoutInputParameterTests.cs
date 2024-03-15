using CSharp_Func_Delegate;

namespace CSharpFuncDelegateTests
{
    [TestClass]
    public class FuncDelegateWithoutInputParameterTests
    {
        [TestMethod]
        public void ProcessBmi_ReturnsCorrectBmi()
        {
            //// Arrange
            //FuncDelegateWithoutInputParameter funcDelegateWithoutInputParameter = new FuncDelegateWithoutInputParameter();
            //double expectedBmi = 24.49;

            //// Act
            //double actualBmi = funcDelegateWithoutInputParameter.ProcessBmi();

            //// Assert
            //Assert.AreEqual(expectedBmi, actualBmi, 0.01, "BMI values don't match");
            // Arrange
            var funcDelegateWithoutInputParameter = new FuncDelegateWithoutInputParameter();
            var processBmiFunc = funcDelegateWithoutInputParameter.ProcessBmi;
            var expectedBmi = 24.49d;

            // Act
            var actualBmi = processBmiFunc();

            // Assert
            Assert.AreEqual(expectedBmi, actualBmi, 0.01, "BMI values don't match");
        }
    }
}