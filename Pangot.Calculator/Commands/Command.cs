namespace Pangot.Calculator.Commands
{
    public abstract class Command
    {
        protected ArithmeticEngine _arithmeticEngine;
        protected double _operand;

        public abstract void Execute();
    }
}
