namespace Pangot.Calculator.Commands
{
    public class Mul : Command
    {
        public Mul(ArithmeticEngine arithmeticEngine, double operand)
        {
            _arithmeticEngine = arithmeticEngine;
            _operand = operand;
        }

        public override void Execute()
        {
            _arithmeticEngine.Run(CommandType.Mul, _operand);
        }
    }
}
