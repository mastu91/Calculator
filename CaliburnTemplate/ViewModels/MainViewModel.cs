using System;
using System.Threading.Tasks;
using Caliburn.Micro;
using CaliburnTemplate.Models;

namespace CaliburnTemplate.ViewModels
{
    internal class MainViewModel : PropertyChangedBase
    {
        private string output;
        private readonly CalculationService calculationService;

        public MainViewModel(CalculationService calculationService)
        {
            this.calculationService = calculationService;
        }

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
            calculationService.SetOperator(output, "+");
            this.Output = "";
        }

        public void Minus()
        {
            calculationService.SetOperator(output, "-");
            this.Output = "";
        }

        public void Multiply()
        {
            calculationService.SetOperator(output, "*");
            this.Output = "";
        }

        public void Divide()
        {
            calculationService.SetOperator(output, "/");
            this.Output = "";
        }

        public void Equal()
        {
            this.Output = calculationService.Equal(output);
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