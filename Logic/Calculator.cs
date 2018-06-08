using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Logic
{
  public class Calculator
  {
    private IBinaryOperation pending_operation = null;

    public void Equals()
    {
      double lhs = 0.0; // THIS IS A FAKE LINE, REPLACE IT WITH CORRECT LOGIC
      double rhs = 0.0; // THIS IS A FAKE LINE, REPLACE IT WITH CORRECT LOGIC
      if (pending_operation != null)
        pending_operation.Perform_binary_calculation(lhs, rhs);
    }

    public string Number_entered(double value)
    {
      throw new NotImplementedException();
    }

    public string Addition_entered()
    {
      throw new NotImplementedException();
    }

    public string Subtraction_entered()
    {
      throw new NotImplementedException();
    }

    public string Multiplication_entered()
    {
      throw new NotImplementedException();
    }

    public string Division_entered()
    {
      throw new NotImplementedException();
    }

    public string Reciprocal_entered()
    {
      throw new NotImplementedException();
    }

    public string Square_root_entered()
    {
      throw new NotImplementedException();
    }
  }

  public class Addition : IBinaryOperation
  {
    public double Perform_binary_calculation(double lhs, double rhs)
    {
      return lhs + rhs;
    }
  }

  public class Subtraction : IBinaryOperation
  {
    public double Perform_binary_calculation(double lhs, double rhs)
    {
      return lhs - rhs;
    }
  }

  public class Multiplication : IBinaryOperation
  {
    public double Perform_binary_calculation(double lhs, double rhs)
    {
      return lhs * rhs;
    }
  }

  public class Division : IBinaryOperation
  {
    public double Perform_binary_calculation(double lhs, double rhs)
    {
      return lhs / rhs;
    }
  }

  // Utility to set the correct operator
  public interface IBinaryOperationFactory
  {
    IBinaryOperation Get_operation(string current_operator);
  }

  public class BinaryOperationFactory : IBinaryOperationFactory
  {
    public IBinaryOperation Get_operation(string current_operator)
    {
      switch(current_operator)
      {
        case "+":
          return new Addition();
        case "-":
          return new Subtraction();
        case "*":
          return new Multiplication();
        case "/":
          return new Division();
        default:
          return new Addition();
      }
    }
  }

}
