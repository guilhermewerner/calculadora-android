using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        int calcState = 1;

        double l_firstNumber = 0;
        double l_secondNumber = 0;
        double result = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnAddNumber(object sender, EventArgs args)
        {
            if (calcState <= 1)
            {
                Button iButton = (Button)sender;
                firstNumber.Text = firstNumber.Text + iButton.Text;
            } else
            {
                Button iButton = (Button)sender;
                secondNumber.Text = secondNumber.Text + iButton.Text;
            }
        }

        void OnSelectOperator(object sender, EventArgs args)
        {
            Button iButton = (Button)sender;
            mathOperator.Text = iButton.Text;
            calcState++;
        }

        void OnCalculate(object sender, EventArgs args)
        {
            l_firstNumber = double.Parse(firstNumber.Text);
            l_secondNumber = double.Parse(secondNumber.Text);

            switch (mathOperator.Text)
            {
                case "÷":
                    result = l_firstNumber / l_secondNumber;
                    break;
                case "×":
                    result = l_firstNumber * l_secondNumber;
                    break;
                case "-":
                    result = l_firstNumber - l_secondNumber;
                    break;
                case "+":
                    result = l_firstNumber + l_secondNumber;
                    break;
            }

            firstNumber.Text = Convert.ToString(result);

            mathOperator.Text = "";
            secondNumber.Text = "";
        }

        void OnClear(object sender, EventArgs args)
        {
            firstNumber.Text = "";
            mathOperator.Text = "";
            secondNumber.Text = "";
            calcState = 1;
        }
    }
}
