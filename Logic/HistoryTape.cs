using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
  public class HistoryTape
  {
    private string _history;
    private string History
    {
      get { return _history; }
      set { _history += value.ToString(); }
    }

    public void AddEntry(string entry)
    {
      History = entry;
    }

    public string GetHistory()
    {
      return History;
    }
  }
}
