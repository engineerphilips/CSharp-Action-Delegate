using CSharp_Func_Delegate;

namespace CSharpFuncDelegateTests
{
    [TestClass]
    public class FuncDelegateWithInputParameterTests
    {
        [TestMethod]
        public void ProcessBmi_ReturnsCorrectBmi()
        {
            //// Arrange
            //FuncDelegateWithInputParameter funcDelegateWithoutInputParameter = new FuncDelegateWithInputParameter();
            //double height = 175d;
            //double weight = 75d;
            //double expectedBmi = 24.49;

            //// Act
            //double actualBmi = funcDelegateWithoutInputParameter.ProcessBmi(height, weight);

            //// Assert
            //Assert.AreEqual(expectedBmi, actualBmi, 0.01, "BMI values don't match");

            // Arrange
            var funcDelegateWithoutInputParameter = new FuncDelegateWithInputParameter();
            var processBmiFunc = funcDelegateWithoutInputParameter.ProcessBmi;
            var height = 175d;
            var weight = 75d;
            var expectedBmi = 24.49;

            // Act
            var actualBmi = processBmiFunc(height, weight);

            // Assert
            Assert.AreEqual(expectedBmi, actualBmi, 0.01, "BMI values don't match");
        }
    }
}
