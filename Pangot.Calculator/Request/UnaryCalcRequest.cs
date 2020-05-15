using Pangot.Calculator.Commands;

namespace Pangot.Calculator.Request
{
    public class UnaryCalcRequest
    {
        public double Operand { get; set; }

        public CommandType CommandType { get; set; }
    }
}
