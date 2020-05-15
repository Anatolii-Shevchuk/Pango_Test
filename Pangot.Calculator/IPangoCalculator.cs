using Pangot.Calculator.Request;
using Pangot.Calculator.Response;

namespace Pangot.Calculator
{
    public interface IPangoCalculator
    {
        CalcResponse ExecuteUnaryOperation(UnaryCalcRequest request);

        CalcResponse ExecuteBinaryOperation(BinaryCalcRequest request);

        CalcResponse ExecuteExpresion(ExpresionCalcRequest request);
    }
}
