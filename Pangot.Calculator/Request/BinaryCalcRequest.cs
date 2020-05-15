using Pangot.Calculator.Commands;

namespace Pangot.Calculator.Request
{
    public class BinaryCalcRequest
    {
        public double Operand1 { get; set; }
        
        public double Operand2 { get; set; }

        public CommandType CommandType { get; set; }
    }
}
