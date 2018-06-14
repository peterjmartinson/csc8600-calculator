using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Logic
{
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
}
