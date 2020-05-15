using Pangot.Calculator.Commands;
using System.Collections.Generic;

namespace Pangot.Calculator
{
    public class CalcEngine
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;

        public void StoreCommands(params Command[] command)
        {
            commands.AddRange(command);
        }

        public void ExecuteCommands()
        {
            commands[current].Execute();
            current++;
        }

    }
}
