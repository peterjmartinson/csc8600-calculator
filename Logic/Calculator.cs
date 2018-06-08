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

  public class Addition : Logic_Interfaces.IBinaryOperation
  {
    public double Perform_binary_calculation(double lhs, double rhs)
    {
      return lhs + rhs;
    }
  }
  public class Subtraction : Logic_Interfaces.IBinaryOperation
  {
    public double Perform_binary_calculation(double lhs, double rhs)
    {
      return lhs - rhs;
    }
  }
}
