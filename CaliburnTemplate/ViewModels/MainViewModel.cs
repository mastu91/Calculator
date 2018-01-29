using System;
using System.Threading.Tasks;
using Caliburn.Micro;
using CaliburnTemplate.Models;

namespace CaliburnTemplate.ViewModels
{
    internal class MainViewModel : PropertyChangedBase
    {
        public MainViewModel(IPaddingService paddingService)
        {
            this.PaddingService = paddingService;
        }
        
        public IPaddingService PaddingService { get; }

        public string output;
        public string firstInput;
        public string sign;

        public string Output
        {
            get => this.output;
            set
            {
                output = value;
                NotifyOfPropertyChange(nameof(Output));
            }
        }

        public void Plus()
        {
            SetOperator("+");
        }

        public void Minus()
        {
            SetOperator("-");
        }

        public void Multiply()
        {
            SetOperator("*");
        }

        public void Divide()
        {
            SetOperator("/");
        }

        public void Equal()
        {
            double numOne = Convert.ToDouble(firstInput);
            double numTwo = Convert.ToDouble(Output);
            switch (sign)
            {
                case "+":
                    Output = (numOne + numTwo).ToString();
                    break;
                case "-":
                    Output = (numOne - numTwo).ToString();
                    break;
                case "*":
                    Output = (numOne * numTwo).ToString();
                    break;
                case "/":
                    Output = (numOne / numTwo).ToString();
                    break;
            }
        }

        public void SetOperator(string sign)
        {
            firstInput = Output;
            this.sign = sign;
            Output = "";
        }

        public void PrintZero()
        {
            Output += 0.ToString();
        }

        public void PrintOne()
        {
            Output += 1.ToString();
        }

        public void PrintTwo()
        {
            Output += 2.ToString();
        }

        public void PrintThree()
        {
            Output += 3.ToString();
        }

        public void PrintFour()
        {
            Output += 4.ToString();
        }

        public void PrintFive()
        {
            Output += 5.ToString();
        }

        public void PrintSix()
        {
            Output += 6.ToString();
        }

        public void PrintSeven()
        {
            Output += 7.ToString();
        }

        public void PrintEight()
        {
            Output += 8.ToString();
        }

        public void PrintNine()
        {
            Output += 9.ToString();
        }
    }
}