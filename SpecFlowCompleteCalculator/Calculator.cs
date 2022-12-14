using System;

namespace SpecFlowCompleteCalculator
{
    public class Calculator
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }

        public int Add()
        {
            return firstNumber + secondNumber;
        }

        public int Subtract()
        {
            return firstNumber - secondNumber;
        }

        public int Multiply()
        {
            return firstNumber * secondNumber;
        }

        public int Divide()
        {
            return firstNumber / secondNumber;
        }

    }
}