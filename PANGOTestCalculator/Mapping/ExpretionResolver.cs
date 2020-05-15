using AutoMapper;
using Pangot.Calculator.Request;
using PANGOTestCalculator.Models;
using System;
using System.Collections.Generic;

namespace PANGOTestCalculator.Mapping
{
    public class ExpretionResolver : IValueResolver<ExpresionCalcDto, ExpresionCalcRequest, IReadOnlyCollection<UnaryCalcRequest>>
    {
        public IReadOnlyCollection<UnaryCalcRequest> Resolve(ExpresionCalcDto source, ExpresionCalcRequest destination, IReadOnlyCollection<UnaryCalcRequest> destMember, ResolutionContext context)
        {
            //TOD need to be implemented
            throw new NotImplementedException();
        }
    }
}
