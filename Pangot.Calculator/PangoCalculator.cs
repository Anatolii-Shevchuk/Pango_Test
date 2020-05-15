using Pangot.Calculator.Commands;
using Pangot.Calculator.Request;
using Pangot.Calculator.Response;
using System;
using System.Linq;

namespace Pangot.Calculator
{
    internal class PangoCalculator : IPangoCalculator
    {
        private readonly ArithmeticEngine _arithmeticEngine;
        private readonly CalcEngine _calcEngine;

        public PangoCalculator()
        {
            _arithmeticEngine = new ArithmeticEngine();
            _calcEngine = new CalcEngine();
        }

        private double Run(Command[] commands)
        {
            _calcEngine.StoreCommands(commands);
            _calcEngine.ExecuteCommands();

            return _arithmeticEngine.Register;
        }

        private Command CreateCommand(CommandType type, double operand)
        {
            switch (type)
            {
                case CommandType.Add:
                    return new Add(_arithmeticEngine, operand);
                case CommandType.Sub:
                    return new Sub(_arithmeticEngine, operand);
                case CommandType.Mul:
                    return new Mul(_arithmeticEngine, operand);
                case CommandType.Div:
                    return new Div(_arithmeticEngine, operand);
                default:
                    throw new Exception();
            }
        }

        public CalcResponse ExecuteUnaryOperation(UnaryCalcRequest request)
        {
            var command = CreateCommand(request.CommandType, request.Operand);

            return new CalcResponse()
            {
                Result = Run(new Command[] { command })
            };
        }

        public CalcResponse ExecuteBinaryOperation(BinaryCalcRequest request)
        {
            var command1 = CreateCommand(CommandType.Add, request.Operand1);
            var command2 = CreateCommand(request.CommandType, request.Operand2);

            return new CalcResponse()
            {
                Result = Run(new Command[] { command1, command2 })
            };
        }

        public CalcResponse ExecuteExpresion(ExpresionCalcRequest request)
        {
            var commands = request.Expresion.Select(arg => CreateCommand(arg.CommandType, arg.Operand));

            return new CalcResponse()
            {
                Result = Run(commands.ToArray())
            };
        }
    }
}
