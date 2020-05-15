using AutoMapper;
using Pangot.Calculator.Request;
using PANGOTestCalculator.Models;

namespace PANGOTestCalculator.Mapping
{
    public class CalculatorMappingProfile : Profile
    {
        public CalculatorMappingProfile()
        {
            CreateMap<ExpresionCalcDto, ExpresionCalcRequest>()
                .ForMember(x => x.Expresion, opt => opt.MapFrom<ExpretionResolver>());
        }
    }
}
