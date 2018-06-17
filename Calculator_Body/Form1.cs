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
    // public string[] x = new string[] { "", "", "", "", "", "", "", "", "", "" };
    public int index = 0;
    public string display;
    public int MAX_DISPLAY_LENGTH = 20;
    public string last_entry;
    public string DEFAULT_DISPLAY = "0";

    public Form1()
    {
      InitializeComponent();
      calculator = new Calculator();
      tape = new History_tape();
    }

    private void Digit_Click(object sender, EventArgs e)
    {
      x = Calculator_Display.Text;
      if (x.Length > MAX_DISPLAY_LENGTH)
      {
        return;
      }

      Button digit_button = (Button)sender;
      string digit = digit_button.Tag.ToString();
      if (x == "0")
      {
        x = digit;
      }
      else
      {
        x += digit;
      }

      last_entry = digit;
      Calculator_Display.Text = x;
    }

    private void Binary_operator_Click(object sender, EventArgs e)
    {
      Button operation_button = (Button)sender;
      string operation = operation_button.Tag.ToString();
      Regex number = new Regex(@"[0-9");
      if (number.IsMatch(last_entry.ToLower()))
      {
        calculator.NumberEntered(Convert.ToDouble(Calculator_Display.Text));
      }
      last_entry = operation;
      calculator.OperationEntered(operation);
    }

    private void Unary_operator_Click(object sender, EventArgs e)
    {
      Button operation_button = (Button)sender;
      string operation = operation_button.Tag.ToString();
      Regex number = new Regex(@"[0-9]");
      if (number.IsMatch(last_entry.ToLower()))
      {
        calculator.NumberEntered(Convert.ToDouble(Calculator_Display.Text));
      }
      last_entry = operation;
      Calculator_Display.Text = calculator.OperationEntered(operation);
    }

    private void Clear_Click(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      Calculator_Display.Text = DEFAULT_DISPLAY;
      calculator.OperationEntered(button.Tag.ToString());
    }


    private void Decimal_Click(object sender, EventArgs e)
    {
      x = Calculator_Display.Text;
      if (x.Length > MAX_DISPLAY_LENGTH)
      {
        return;
      }
      x += ".";
      last_entry = x;
      Calculator_Display.Text = x;
    }


    private void Plus_minus_Click(object sender, EventArgs e)
    {

    }

    private void Equals_Click(object sender, EventArgs e)
    {

    }

  }
}
