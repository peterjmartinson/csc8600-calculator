using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Logic
{
  public class HistoryTape
  {
    private string History { get; set; }

    public string GetHistory()
    {
      return History;
    }

    public void AddEntry(string entry)
    {
      Regex number = new Regex(@"[0-9\.=\+-/*]+");
      if (number.IsMatch(entry.ToLower()))
      {
        History += entry.ToLower().ToString();
      }
      else if (entry.ToLower() == "reciprocal")
      {
        History += "1/x";
      }
      else if (entry.ToLower() == "plus_minus")
      {
        History += "+/-";
      }
      else if (entry.ToLower() == "square_root")
      {
        History += "root";
      }
      else if (entry.ToLower() == "clear")
      {
        History = "";
      }
      History += " ";
    }

  }
}
