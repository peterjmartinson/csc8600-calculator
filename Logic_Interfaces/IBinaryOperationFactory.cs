using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interfaces
{
  public interface IBinaryOperationFactory
  {
    IBinaryOperation GetOperation(string current_operator);
  }
}
