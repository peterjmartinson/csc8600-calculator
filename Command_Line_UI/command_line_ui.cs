using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;
using Logic;

namespace Command_Line_UI
{
  public class Command_line_ui
  {

    public Calculator calculator;
    public History_tape tape;
    public Command_line_ui()
    {
      calculator = new Calculator();
      tape = new History_tape();
    }

    public void UI()
    {
      Console.WriteLine("System: 0");
      for (; ; )
      {
        Console.Write("User: ");
        string input = Console.ReadLine();
        string new_display = "oops";
        tape.AddEntry(input);
        Console.Write(tape.GetHistory() + "\n");

        if (double.TryParse(input, out double value))
        {
          new_display = calculator.NumberEntered(value);
        }
        else
        {
          new_display = calculator.OperationEntered(input);
        }
        Console.WriteLine($"System: {new_display}");
      }
    }
  }
}
