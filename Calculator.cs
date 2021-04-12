using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsButtonCalculator.DataHolder;

namespace WinformsButtonCalculator
{
    public partial class Calculator 
        : Form
    {
        double varA = 0;
        double varB = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        string firstNum, secondNum;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            if ((textBoxResult.Text == "0") || (isOperationPerformed))
                textBoxResult.Clear();   

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button .Text == ".")
            {
                if(!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + button.Text;
            }
            else 
            textBoxResult.Text = textBoxResult.Text + button.Text ;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (varA != 0)
            {
                btnEquals.PerformClick();
                isOperationPerformed = true;
                operationPerformed = button.Text;
                labelCurrentOperation.Text = $"{varA} {operationPerformed} ";
            }
            else
            {
                operationPerformed = button.Text;
                varA = Double.Parse(textBoxResult.Text);
                isOperationPerformed = true;
                labelCurrentOperation.Text = $"{varA} {operationPerformed}";
            }
            firstNum = labelCurrentOperation.Text;
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            varA = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            ResultHolder result = new ResultHolder();

            secondNum = textBoxResult.Text;
            labelCurrentOperation.Text = "";
            varB = Double.Parse(textBoxResult.Text);

            switch (operationPerformed)
            {

                case "+":
                    ////result = OperationModul.Instance.Count(varA, varB); //Singleton call
                    //result = OperationModul.Instance.Count(varA, varB);
                    //textBoxResult.Text = result.ToString();
                    textBoxResult.Text = (varA + Double.Parse(textBoxResult.Text)).ToString();
                    //textBoxResult.Text = (Double.Parse(textBoxResult.Text)).ToString();

                    //textBoxResult = OperationModul.Instance.Count(varA, varB).ToString();
                    break;
                case "-":
                    //result = OperationModul.Instance.Substring(varA, varB = { Double.Parse(textBoxResult.Text).ToString()}; //Singleton call

                    textBoxResult.Text = (varA - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "X":
                    //result = OperationModul.Instance.Multiply(varA, varB = { Double.Parse(textBoxResult.Text).ToString()}; //Singleton call

                    textBoxResult.Text = (varA * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "÷":
                    //result = OperationModul.Instance.Divided(varA, varB = { Double.Parse(textBoxResult.Text).ToString()}; //Singleton call

                    textBoxResult.Text = (varA / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            varA = Double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = "";
            //_________________________
            buttonClearHistory.Visible = true;
            richTextBoxResult.AppendText($"{firstNum} {secondNum} =  {textBoxResult.Text} \n");
            //richTextBoxResult.AppendText("\\t"+textBoxResult.Text + "\n\n");

            labelHistory.Text = "";
        }



        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Clear();
            if (labelHistory.Text == "")
            {
                labelHistory.Text = "No history";
            }
            buttonClearHistory.Visible = false;
            richTextBoxResult.ScrollBars = 0;

        }

        private void viewCalculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 450;
        }

        private void showOnlyCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 260;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length > 0)
            {
                textBoxResult.Text.Remove(textBoxResult.Text.Length - 1, 1);
            }
            if (textBoxResult.Text == "")
            {
                textBoxResult.Text = "0";
            }
        }
    }
}
