using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
  public class Digit
  {
    private double _value;
    public double Value
    {
      get { return Double.IsNaN(_value) ? 0 : _value; }
      set { _value = value; }
    }

    public void Reset()
    {
      _value = Double.NaN;
    }

    public bool IsSet()
    {
      return !Double.IsNaN(_value);
    }

    public bool IsNotSet()
    {
      return Double.IsNaN(_value);
    }

    public Digit()
    {
      Reset();
    }

    public Digit(double val)
    {
      _value = val;
    }
  }

}
