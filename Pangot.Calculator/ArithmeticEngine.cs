using Pangot.Calculator.Commands;

namespace Pangot.Calculator
{
    public class ArithmeticEngine
    {
        public double Register { get; private set; }

        public void Run(CommandType commandType, double operand)
        {
            switch (commandType)
            {
                case CommandType.Add:
                    Register += operand;
                    break;
                case CommandType.Sub:
                    Register -= operand;
                    break;
                case CommandType.Mul:
                    Register *= operand;
                    break;
                case CommandType.Div:
                    Register /= operand;
                    break;
            }
        }

    }
}
