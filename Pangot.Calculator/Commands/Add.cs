namespace Pangot.Calculator.Commands
{
    public class Add : Command
    {
        public Add(ArithmeticEngine arithmeticEngine, double operand)
        {
            _arithmeticEngine = arithmeticEngine;
            _operand = operand;
        }

        public override void Execute()
        {
            _arithmeticEngine.Run(CommandType.Add, _operand);
        }
    }
}
