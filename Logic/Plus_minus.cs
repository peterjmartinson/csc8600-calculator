using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Logic
{
  public class Plus_minus : IUnaryOperation
  {
    public double PerformUnaryCalculation(double value)
    {
      return -1 * value;
    }
  }
}
