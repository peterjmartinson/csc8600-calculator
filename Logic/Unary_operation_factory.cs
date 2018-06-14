using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Logic
{
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
