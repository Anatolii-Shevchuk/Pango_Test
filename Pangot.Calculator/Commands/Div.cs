namespace Pangot.Calculator.Commands
{
    public class Div : Command
    {
        public Div(ArithmeticEngine arithmeticEngine, double operand)
        {
            _arithmeticEngine = arithmeticEngine;
            _operand = operand;
        }

        public override void Execute()
        {
            _arithmeticEngine.Run(CommandType.Div, _operand);
        }
    }
}
