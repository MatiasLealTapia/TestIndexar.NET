using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestIndexar.NET.Functions
{
    internal class CalcNotacionPolacaInv
    {
        public static Stack<double> Calculate(string expression)
        {
            string[] items = expression.Split(' ');
            Stack<double> stack = new Stack<double>();

            foreach (string item in items)
            {
                double value;
                if (double.TryParse(item, out value))
                {
                    stack.Push(value);
                }
                else
                {
                    double secondOperand = stack.Pop();
                    double firstOperand = stack.Pop();
                    double result = RealizarOperacion(firstOperand, secondOperand, item);
                    stack.Push(result);
                }
            }
            return stack;
        }

        public static double RealizarOperacion(double firstOperand, double secondOperand, string itemOperator)
        {
            switch (itemOperator)
            {
                case "+":
                    return firstOperand + secondOperand;
                case "-":
                    return firstOperand - secondOperand;
                case "*":
                    return firstOperand * secondOperand;
                case "/":
                    return firstOperand / secondOperand;
                default:
                    throw new ArgumentException($"Operador no valido: {itemOperator}");
            }
        }
    }
}
