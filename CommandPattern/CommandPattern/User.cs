using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class User
    {
        private Calculator _calculator = new Calculator();
        private List<ICommand> _commands = new List<ICommand>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    ICommand command = _commands[_current++];

                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    ICommand command = _commands[--_current] as ICommand;

                    command.RollBack();
                }
            }
        }

        public void Compute(char operation, int operand)
        {
            ICommand command = new CalculatorCommand(_calculator, operation, operand);

            command.Execute();
            
            _commands.Add(command);

            _current++;
        }
    }
}
