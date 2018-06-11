using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
  [TestClass]
  public class Test_Calculator
  {
    
    [TestMethod]
    public void Canary()
    {
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void Test_Unary_operation_factory_Default()
    {
      Logic.Unary_operation_factory factory = new Logic.Unary_operation_factory();
      Logic_Interfaces.IUnaryOperation pending_operation = factory.GetOperation("whatever");
      Assert.AreEqual(null, pending_operation);
    }

    [TestMethod]
    public void Test_Binary_operation_factory_Default()
    {
      Logic.Binary_operation_factory factory = new Logic.Binary_operation_factory();
      Logic_Interfaces.IBinaryOperation pending_operation = factory.GetOperation("whatever");
      Assert.AreEqual(null, pending_operation);
    }

    [TestMethod]
    public void Test_Digit_Constructor()
    {
      Logic.Digit lhs = new Logic.Digit();
      Assert.IsTrue(Double.IsNaN(lhs.Value));
    }

    [TestMethod]
    public void Test_Digit_Constructor_Param()
    {
      Logic.Digit lhs = new Logic.Digit(4.1);
      Assert.AreEqual(4.1, lhs.Value);
    }

    [TestMethod]
    public void Test_Digit_Reset()
    {
      Logic.Digit lhs = new Logic.Digit();
      lhs.Value = 4.1;
      lhs.Reset();
      Assert.IsTrue(Double.IsNaN(lhs.Value));
    }

    [TestMethod]
    public void Test_Digit_IsNotSet()
    {
      Logic.Digit lhs = new Logic.Digit();
      Assert.IsTrue(lhs.IsNotSet());
    }

    [TestMethod]
    public void Test_Digit_IsSet()
    {
      Logic.Digit lhs = new Logic.Digit(1.0);
      Assert.IsTrue(lhs.IsSet());
    }





    [TestMethod]
    public void Test_Equals()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(3);
      calculator.OperationEntered("+");
      calculator.NumberEntered(5);
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("8", result);
    }

    [TestMethod]
    public void Test_Equals_No_Operator()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(3);
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("3", result);
    }

    [TestMethod]
    public void Test_Equals_No_Rhs()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(3);
      calculator.OperationEntered("+");
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("6", result);
    }

    [TestMethod]
    public void Test_Repeat_Equals()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(1.0);
      calculator.OperationEntered("+");
      calculator.NumberEntered(4.0);
      calculator.OperationEntered("=");
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("9", result);
    }




    [TestMethod]
    public void Test_OperationEntered_binary()
    {
      string operation = "+";
      Logic.Calculator calculator = new Logic.Calculator();
      string result = calculator.OperationEntered(operation);
      Assert.AreEqual("+", result);
    }

    [TestMethod]
    public void Test_Addition()
    {
      Logic.Binary_operation_factory factory = new Logic.Binary_operation_factory();
      Logic_Interfaces.IBinaryOperation pending_operation = factory.GetOperation("+");
      double lhs = 1.0;
      double rhs = 2.0;
      double result = pending_operation.PerformBinaryCalculation(lhs, rhs);
      Assert.AreEqual(3.0, result);
    }

    [TestMethod]
    public void Test_Subtraction()
    {
      Logic.Binary_operation_factory factory = new Logic.Binary_operation_factory();
      Logic_Interfaces.IBinaryOperation pending_operation = factory.GetOperation("-");
      double lhs = 3.0;
      double rhs = 2.0;
      double result = pending_operation.PerformBinaryCalculation(lhs, rhs);
      Assert.AreEqual(1.0, result);
    }

    [TestMethod]
    public void Test_Multiplication()
    {
      Logic.Binary_operation_factory factory = new Logic.Binary_operation_factory();
      Logic_Interfaces.IBinaryOperation pending_operation = factory.GetOperation("*");
      double lhs = 2.0;
      double rhs = 3.0;
      double result = pending_operation.PerformBinaryCalculation(lhs, rhs);
      Assert.AreEqual(6.0, result);
    }

    [TestMethod]
    public void Test_Division()
    {
      Logic.Binary_operation_factory factory = new Logic.Binary_operation_factory();
      Logic_Interfaces.IBinaryOperation pending_operation = factory.GetOperation("/");
      double lhs = 6.0;
      double rhs = 2.0;
      double result = pending_operation.PerformBinaryCalculation(lhs, rhs);
      Assert.AreEqual(3.0, result);
    }

    [TestMethod]
    public void Test_Calculator_Addition()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(1.1);
      calculator.OperationEntered("+");
      calculator.NumberEntered(2.1);
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("3.2", result);
    }

    [TestMethod]
    public void Test_Calculator_Subtraction()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(3.3);
      calculator.OperationEntered("-");
      calculator.NumberEntered(2.2);
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("1.1", result);
    }

    [TestMethod]
    public void Test_Calculator_Multiplication()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(2.51);
      calculator.OperationEntered("*");
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("10.04", result);
    }

    [TestMethod]
    public void Test_Calculator_Division()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(10.04);
      calculator.OperationEntered("/");
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("2.51", result);
    }

    [TestMethod]
    public void Test_Calculator_Change_Operator()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(10.04);
      calculator.OperationEntered("/");
      calculator.OperationEntered("*");
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("40.16", result);
    }




    [TestMethod]
    public void Test_OperationEntered_unary()
    {
      string operation = "reciprocal";
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(4);
      string result = calculator.OperationEntered(operation);
      Assert.AreEqual("0.25", result);
    }

    [TestMethod]
    public void Test_Reciprocal()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("reciprocal");
      Assert.AreEqual("0.25", result);
    }

    [TestMethod]
    public void Test_Rhs_Reciprocal()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(10.04);
      calculator.OperationEntered("/");
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("reciprocal");
      Assert.AreEqual("0.25", result);
    }

    [TestMethod]
    public void Test_Add_Reciprocal()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(1.76);
      calculator.OperationEntered("+");
      calculator.NumberEntered(4.0);
      calculator.OperationEntered("reciprocal");
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("2.01", result);
    }
    
    [TestMethod]
    public void Test_Reciprocal_Sets_Rhs()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(4.0);
      calculator.OperationEntered("+");
      calculator.OperationEntered("reciprocal");
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("4.25", result);
    }

    [TestMethod]
    public void Test_Square_Root()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("square_root");
      Assert.AreEqual("2", result);
    }

    [TestMethod]
    public void Test_Rhs_Square_Root()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(10.04);
      calculator.OperationEntered("/");
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("squaRE_root");
      Assert.AreEqual("2", result);
    }

    [TestMethod]
    public void Test_Add_Square_Root()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(1.0);
      calculator.OperationEntered("+");
      calculator.NumberEntered(4.0);
      calculator.OperationEntered("square_root");
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("3", result);
    }

    [TestMethod]
    public void Test_Square_Root_Sets_Rhs()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(4.0);
      calculator.OperationEntered("+");
      calculator.OperationEntered("square_root");
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("6", result);
    }

    [TestMethod]
    public void Test_Plus_Minus()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("plus_minus");
      Assert.AreEqual("-4", result);
    }

    [TestMethod]
    public void Test_Rhs_Plus_Minus()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(10.04);
      calculator.OperationEntered("/");
      calculator.NumberEntered(4.0);
      string result = calculator.OperationEntered("plus_minus");
      Assert.AreEqual("-4", result);
    }

    [TestMethod]
    public void Test_Add_Plus_Minus()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(1.0);
      calculator.OperationEntered("+");
      calculator.NumberEntered(4.0);
      calculator.OperationEntered("plus_minus");
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("-3", result);
    }

    [TestMethod]
    public void Test_Plus_Minus_Sets_Rhs()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(4.0);
      calculator.OperationEntered("+");
      calculator.OperationEntered("plus_minus");
      string result = calculator.OperationEntered("=");
      Assert.AreEqual("0", result);
    }




    [TestMethod]
    public void Test_Reciprocal_After_Equals()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(1.0);
      calculator.OperationEntered("+");
      calculator.NumberEntered(3.0);
      calculator.OperationEntered("=");
      calculator.OperationEntered("=");
      calculator.OperationEntered("=");
      calculator.OperationEntered("=");
      calculator.OperationEntered("=");
      string result = calculator.OperationEntered("reciprocal");
      Assert.AreEqual("0.0625", result);
    }
    
    [TestMethod]
    public void Test_Square_Root_After_Equals()
    {
      Logic.Calculator calculator = new Logic.Calculator();
      calculator.NumberEntered(1.0);
      calculator.OperationEntered("+");
      calculator.NumberEntered(3.0);
      calculator.OperationEntered("=");
      calculator.OperationEntered("=");
      calculator.OperationEntered("=");
      calculator.OperationEntered("=");
      calculator.OperationEntered("=");
      string result = calculator.OperationEntered("square_root");
      Assert.AreEqual("4", result);
    }
    




  }
}
