using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Logic
{
  public class Division : IBinaryOperation
  {
    public double PerformBinaryCalculation(double lhs, double rhs)
    {
      return lhs / rhs;
    }
  }
}
