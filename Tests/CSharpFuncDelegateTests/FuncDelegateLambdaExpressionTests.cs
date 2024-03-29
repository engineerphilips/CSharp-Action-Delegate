﻿using CSharp_Func_Delegate;

namespace CSharpFuncDelegateTests
{
    [TestClass]
    public class FuncDelegateLambdaExpressionTests
    {
        [TestMethod]
        public void ProcessBmiWithNoInputParametersFunc_ReturnsCorrectBmi()
        {
            //// Arrange
            //FuncDelegateLambdaExpression funcDelegateLambdaExpression = new FuncDelegateLambdaExpression();
            //Func<double> processBmiFunc = funcDelegateLambdaExpression.ProcessBmiWithNoInputParametersFunc;
            //double expectedBmi = 24.49; 

            //// Act
            //double actualBmi = processBmiFunc();

            //// Assert
            //Assert.AreEqual(expectedBmi, actualBmi, 0.01, "BMI values don't match");
            // Arrange
            var funcDelegateLambdaExpression = new FuncDelegateLambdaExpression();
            var processBmiFunc = funcDelegateLambdaExpression.ProcessBmiWithNoInputParametersFunc;
            var expectedBmi = 24.49d;

            // Act
            var actualBmi = processBmiFunc();

            // Assert
            Assert.AreEqual(expectedBmi, actualBmi, 0.01, "BMI values don't match");
        }

        [TestMethod]
        public void ProcessBmiWithInputParametersFunc_ReturnsCorrectBmi()
        {
            //// Arrange
            //FuncDelegateLambdaExpression funcDelegateLambdaExpression = new FuncDelegateLambdaExpression();
            //Func<double, double, double> processBmiFunc = funcDelegateLambdaExpression.ProcessBmiWithInputParametersFunc;
            //double height = 175d;
            //double weight = 75d;
            //double expectedBmi = 24.49;

            //// Act
            //double actualBmi = processBmiFunc(height, weight);

            //// Assert
            //Assert.AreEqual(expectedBmi, actualBmi, 0.01, "BMI values don't match");
            // Arrange
            var funcDelegateLambdaExpression = new FuncDelegateLambdaExpression();
            var processBmiFunc = funcDelegateLambdaExpression.ProcessBmiWithInputParametersFunc;
            var height = 175d;
            var weight = 75d;
            var expectedBmi = 24.49d;

            // Act
            var actualBmi = processBmiFunc(height, weight);

            // Assert
            Assert.AreEqual(expectedBmi, actualBmi, 0.01, "BMI values don't match");
        }
    }
}
