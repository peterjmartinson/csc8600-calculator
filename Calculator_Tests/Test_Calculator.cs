using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
  [TestClass]
  public class Test_Calculator
  {
    
    [TestMethod]
    public void Test_test()
    {
      double a = 1.0;
      Assert.Fail();
    }

    [TestMethod]
    public void Test_Addition()
    {
      double lhs = 3.1;
      double rhs = 2.9;
      Logic_Interfaces.IBinaryOperation addition = new Logic.Addition();
      double result = addition.Perform_binary_calculation(lhs, rhs);
      Assert.AreEqual(6.0, result);
    }

    [TestMethod]
    public void Test_Multiplication()
    {
        double lhs = 3.0;
        double rhs = 5.0;
        Logic_Interfaces.IBinaryOperation multiply = new Logic.Multiplication();
        double result = multiply.Perform_binary_calculation(lhs, rhs);
        Assert.AreEqual(15.0, result);
    }

    [TestMethod]
    public void Test_Subtraction()
    {
        double lhs = 7.0;
        double rhs = 22.0;
        Logic_Interfaces.IBinaryOperation subtract = new Logic.Subtraction();
        double result = subtract.Perform_binary_calculation(lhs, rhs);
        Assert.AreEqual(-15.0, result);
    }

    [TestMethod]
    public void Test_Division()
    {
        double lhs = 56.0;
        double rhs = 7.0;
        Logic_Interfaces.IBinaryOperation divide = new Logic.Division();
        double result = divide.Perform_binary_calculation(lhs, rhs);
        Assert.AreEqual(8.0, result);
    }

    [TestMethod]
    public void Test_Addition_Decimals()
    {
        double lhs = .12;
        double rhs = 1.0;
        Logic_Interfaces.IBinaryOperation add = new Logic.Addition();
        double result = add.Perform_binary_calculation(lhs, rhs);
        Assert.AreEqual(1.12, result);
    }

    [TestMethod]
    public void Test_Subtraction_Decimals()
    {
        double lhs = 1.1;
        double rhs = 0.1;
        Logic_Interfaces.IBinaryOperation subtract = new Logic.Subtraction();
        double result = subtract.Perform_binary_calculation(lhs, rhs);
        Assert.AreEqual(1.0, result);
    }

    // Triple operations

    [TestMethod]
    public void Test_Add_Multiply()
    {
        double a = 1.0;
        double b = 2.0;
        Logic_Interfaces.IBinaryOperation add = new Logic.Addition();
        double intermediate_result = add.Perform_binary_calculation(a, b);
        double c = 3.0;
        Logic_Interfaces.IBinaryOperation multiply = new Logic.Multiplication();
        double result = multiply.Perform_binary_calculation(intermediate_result, c);
        Assert.AreEqual(7.0, result);
    }

    [TestMethod]
    public void Test_Add_Divide()
    {
        double a = 7;
        double b = 15;
        Logic_Interfaces.IBinaryOperation add = new Logic.Addition();
        double intermediate_result = add.Perform_binary_calculation(a, b);
        double c = 3;
        Logic_Interfaces.IBinaryOperation divide = new Logic.Division();
        double result = divide.Perform_binary_calculation(intermediate_result, c);
        Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void Test_Subtract_Multiply()
    {
        double a = 1;
        double b = 2;
        Logic_Interfaces.IBinaryOperation minus = new Logic.Subtraction();
        double intermediate_result = minus.Perform_binary_calculation(a, b);
        double c = 3;
        Logic_Interfaces.IBinaryOperation multiply = new Logic.Multiplication();
        double result = multiply.Perform_binary_calculation(intermediate_result, c);
        Assert.AreEqual(-5, result);
    }

    [TestMethod]
    public void Test_Subtract_Divide()
    {
        double a = 7;
        double b = 15;
        Logic_Interfaces.IBinaryOperation minus = new Logic.Subtraction();
        double intermediate_result = minus.Perform_binary_calculation(a, b);
        double c = 3;
        Logic_Interfaces.IBinaryOperation divide = new Logic.Division();
        double result = divide.Perform_binary_calculation(intermediate_result, c);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void Test_Add_Multiply_Decimals()
    {
        double a = 1;
        double b = 4;
        Logic_Interfaces.IBinaryOperation add = new Logic.Addition();
        double intermediate_result = add.Perform_binary_calculation(a, b);
        double c = 0.25;
        Logic_Interfaces.IBinaryOperation multiply = new Logic.Multiplication();
        double result = multiply.Perform_binary_calculation(intermediate_result, c);
        Assert.AreEqual(2, result);
    }

    }
}
