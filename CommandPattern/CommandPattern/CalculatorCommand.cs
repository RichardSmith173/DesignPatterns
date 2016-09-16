using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CalculatorCommand : ICommand
    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char operation, int operand)
        {
            this._calculator = calculator;
            this._operator = operation;
            this._operand = operand;

        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void RollBack()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new ArgumentException("@operator");
            }
        }
    }
}
