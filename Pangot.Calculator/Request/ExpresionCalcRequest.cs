using System.Collections.Generic;

namespace Pangot.Calculator.Request
{
    public class ExpresionCalcRequest
    {
        public IReadOnlyCollection<UnaryCalcRequest> Expresion { get; set; }
    }
}
