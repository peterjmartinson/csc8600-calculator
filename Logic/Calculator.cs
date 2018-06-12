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
    private IUnaryOperation unary_operation = null;
    private string bad_entry = "Illegal entry.  Must be a number or [+|-|*|/|reciprocal|square_root|plus_minus|clear]";
    private Digit Lhs = new Digit();
    private Digit Rhs = new Digit();

    /**
     * equals_flag & ClearAllButLhs()
     * Say user enters "1+3=====".
     * Calculator state will be:
     *   Lhs.Value = 16
     *   pending_operator = +
     *   Rhs.Value = 3
     * If user now enters "square_root", RunUnaryOperator will run sqrt(3).
     * equals_flag says whether "=" has been hit, and if so, RunUnaryOperator
     * will ClearAllButLhs(), and then run the calculation.
     * -> equals_flag sucks, and the issue should be resolved some other way.
    */
    private bool equals_flag = false;

    public void ClearAllButLhs()
    {
      Rhs.Reset();
      pending_operation = null;
      equals_flag = false;
    }

    public string NumberEntered(double value)
    {
      if (equals_flag)
      {
        Clear();
      }

      if (pending_operation == null)
      {
        Lhs.Value = value;
      }
      else
      {
        Rhs.Value = value;
      }
      return value.ToString();
    }

    public string OperationEntered(string operation)
    {
      operation = operation.ToLower();
      if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
      {
        return RunBinaryOperation(operation);
      }
      else if (operation == "reciprocal" || operation == "square_root" || operation == "plus_minus")
      {
        return RunUnaryOperation(operation);
      }
      else if (operation == "=")
      {
        return Equals().ToString();
      }
      else if (operation == "clear")
      {
        return Clear();
      }
      else
      {
        return bad_entry;
      }
    }

    public double Equals()
    {
      if (pending_operation == null)
      {
        return Lhs.Value;
      }
      double lhs = Lhs.Value;
      double rhs = Rhs.IsSet() ? Rhs.Value : Lhs.Value;
      Lhs.Value = pending_operation.PerformBinaryCalculation(lhs, rhs);
      equals_flag = true;
      return Lhs.Value;
    }

    public string RunBinaryOperation(string operation)
    {
      Binary_operation_factory factory = new Binary_operation_factory();
      pending_operation = factory.GetOperation(operation);
      return operation;
    }

    public string RunUnaryOperation(string operation)
    {
      Unary_operation_factory factory = new Unary_operation_factory();
      unary_operation = factory.GetOperation(operation);
      if (equals_flag)
      {
        ClearAllButLhs();
      }

      if (Lhs.IsNotSet())
      {
        Lhs.Value = 0;
        Lhs.Value = unary_operation.PerformUnaryCalculation(Lhs.Value);
        return Lhs.Value.ToString();
      }
      else if (pending_operation == null)
      {
        Lhs.Value = unary_operation.PerformUnaryCalculation(Lhs.Value);
        return Lhs.Value.ToString();
      }
      else if (Rhs.IsNotSet())
      {
        Rhs.Value = unary_operation.PerformUnaryCalculation(Lhs.Value);
        return Rhs.Value.ToString();
      }
      else // if (Rhs.IsSet())
      {
        Rhs.Value = unary_operation.PerformUnaryCalculation(Rhs.Value);
        return Rhs.Value.ToString();
      }
    }

    public string Clear()
    {
      Lhs.Reset();
      Rhs.Reset();
      pending_operation = null;
      equals_flag = false;
      return "Clear";
    }

  }

  public class Digit
  {
    public double Value { get; set; }

    public void Reset()
    {
      Value = Double.NaN;
    }

    public bool IsSet()
    {
      return !Double.IsNaN(Value);
    }

    public bool IsNotSet()
    {
      return Double.IsNaN(Value);
    }

    public Digit()
    { 
      Reset();
    }

    public Digit(double val)
    {
      Value = val;
    }
  }

  public class Addition : IBinaryOperation
  {
    public double PerformBinaryCalculation(double lhs, double rhs)
    {
      return lhs + rhs;
    }
  }

  public class Subtraction : IBinaryOperation
  {
    public double PerformBinaryCalculation(double lhs, double rhs)
    {
      return lhs - rhs;
    }
  }

  public class Multiplication : IBinaryOperation
  {
    public double PerformBinaryCalculation(double lhs, double rhs)
    {
      return lhs * rhs;
    }
  }

  public class Division : IBinaryOperation
  {
    public double PerformBinaryCalculation(double lhs, double rhs)
    {
      return lhs / rhs;
    }
  }

  public class Reciprocal : IUnaryOperation
  {
    public double PerformUnaryCalculation(double value)
    {
      return 1 / value;
    }
  }

  public class Square_root : IUnaryOperation
  {
    public double PerformUnaryCalculation(double value)
    {
      return Math.Sqrt(value);
    }
  }

  public class Plus_minus : IUnaryOperation
  {
    public double PerformUnaryCalculation(double value)
    {
      return -1 * value;
    }
  }

  public interface IBinaryOperationFactory
  {
    IBinaryOperation GetOperation(string current_operator);
  }

  public class Binary_operation_factory : IBinaryOperationFactory
  {
    public IBinaryOperation GetOperation(string current_operator)
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
          return null;
      }
    }
  }

  public interface IUnaryOperationFactory
  {
    IUnaryOperation GetOperation(string current_operator);
  }

  public class Unary_operation_factory : IUnaryOperationFactory
  {
    public IUnaryOperation GetOperation(string current_operator)
    {
      switch(current_operator)
      {
        case "reciprocal":
          return new Reciprocal();
        case "square_root":
          return new Square_root();
        case "plus_minus":
          return new Plus_minus();
        default:
          return null;
      }
    }
  }

}
