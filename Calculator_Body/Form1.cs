using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_Interfaces;
using Logic;
using System.Text.RegularExpressions;

namespace Calculator_Body
{
  public partial class Form1 : Form
  {
    public Calculator calculator;
    public History_tape tape;
    public string x;
    public int index = 0;
    public string display;
    public int MAX_DISPLAY_LENGTH = 20;
    public enum LAST_ENTRY { CLEARED, NUMBER, BINARY_OPERATOR, UNARY_OPERATOR, SQUARE_ROOT, RECIPROCAL, PLUS_MINUS, EQUALS};
    public LAST_ENTRY last_entry = LAST_ENTRY.CLEARED;
    public string DEFAULT_DISPLAY = "0";
    public bool operator_is_set = false;

    public Form1()
    {
      InitializeComponent();
      calculator = new Calculator();
      tape = new History_tape();
    }

    private void UpdateHistory(string entry)
    {
      tape.AddEntry(entry);
      History_Tape.Text = tape.GetHistory();
    }

    private void Digit_Click(object sender, EventArgs e)
    {
      x = Calculator_Display.Text;
      if (x.Length > MAX_DISPLAY_LENGTH)
      {
        return;
      }

      Button digit_button = (Button)sender;
      string entered_digit = digit_button.Tag.ToString();
      if (x == "0" || last_entry == LAST_ENTRY.BINARY_OPERATOR || last_entry == LAST_ENTRY.EQUALS || last_entry == LAST_ENTRY.UNARY_OPERATOR)
      {
        x = entered_digit;
      }
      else
      {
        x += entered_digit;
      }

      Calculator_Display.Text = x;
      last_entry = LAST_ENTRY.NUMBER;
    }

    private void Binary_operator_Click(object sender, EventArgs e)
    {
      Button operation_button = (Button)sender;
      string operation;
      switch (operation_button.Tag.ToString())
      {
        case "Addition":
          operation = "+";
          break;
        case "Subtraction":
          operation = "-";
          break;
        case "Multiplication":
          operation = "*";
          break;
        case "Division":
          operation = "/";
          break;
        default:
          return;
      }
      
      if (last_entry == LAST_ENTRY.NUMBER)
      {
        calculator.NumberEntered(Convert.ToDouble(Calculator_Display.Text));
        UpdateHistory(Calculator_Display.Text);
      }
      calculator.OperationEntered(operation);
      operator_is_set = true;
      UpdateHistory(operation);
      last_entry = LAST_ENTRY.BINARY_OPERATOR;
    }

    private void Unary_operator_Click(object sender, EventArgs e)
    {
      Button operation_button = (Button)sender;
      string operation = operation_button.Tag.ToString();
      if (last_entry == LAST_ENTRY.NUMBER)
      {
        calculator.NumberEntered(Convert.ToDouble(Calculator_Display.Text));
        UpdateHistory(Calculator_Display.Text);
      }
      Calculator_Display.Text = calculator.OperationEntered(operation);
      UpdateHistory(operation);
      last_entry = LAST_ENTRY.UNARY_OPERATOR;
    }

    private void Clear_Click(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      Calculator_Display.Text = DEFAULT_DISPLAY;
      calculator.OperationEntered(button.Tag.ToString());
      UpdateHistory("clear");
      last_entry = LAST_ENTRY.CLEARED;
    }


    private void Decimal_Click(object sender, EventArgs e)
    {
      x = Calculator_Display.Text;
      if (x.Length > MAX_DISPLAY_LENGTH || x.Contains("."))
      {
        return;
      }
      last_entry = LAST_ENTRY.NUMBER;
      Convert.ToDouble(Calculator_Display.Text).ToString();
      Calculator_Display.Text = ".";
    }


    private void Plus_minus_Click(object sender, EventArgs e)
    {
      x = Calculator_Display.Text;
      Calculator_Display.Text = x.Contains("-") ? x.Substring(1) : "-" + x;
    }

    private void Equals_Click(object sender, EventArgs e)
    {
      if (last_entry != LAST_ENTRY.EQUALS)
      {
        calculator.NumberEntered(Convert.ToDouble(Calculator_Display.Text));
        UpdateHistory(Calculator_Display.Text);
      }
      Calculator_Display.Text = calculator.Equals().ToString();
      UpdateHistory("= " + calculator.Equals().ToString());
      last_entry = LAST_ENTRY.EQUALS;
    }

  }
}
