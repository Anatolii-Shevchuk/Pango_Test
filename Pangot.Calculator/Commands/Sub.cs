namespace Pangot.Calculator.Commands
{
    public class Sub : Command
    {
        public Sub(ArithmeticEngine arithmeticEngine, double operand)
        {
            _arithmeticEngine = arithmeticEngine;
            _operand = operand;
        }

        public override void Execute()
        {
            _arithmeticEngine.Run(CommandType.Sub, _operand);
        }
    }
}
