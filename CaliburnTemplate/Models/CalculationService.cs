using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CaliburnTemplate.ViewModels;

namespace CaliburnTemplate.Models
{
    class CalculationService
    {
        private string firstInput;
        private string sign;

        public CalculationService()
        {

        }

        public string SetOperator( string output, string sign)
        {
            firstInput = output;
            this.sign = sign;
            return "";
        }

        public string Equal(string output)
        {
            double numOne = Convert.ToDouble(firstInput);
            double numTwo = Convert.ToDouble(output);
            switch (sign)
            {
                case "+":
                    output = (numOne + numTwo).ToString();
                    break;
                case "-":
                    output = (numOne - numTwo).ToString();
                    break;
                case "*":
                    output = (numOne * numTwo).ToString();
                    break;
                case "/":
                    output = (numOne / numTwo).ToString();
                    break;
            }
            return output;
        }
    }
}
