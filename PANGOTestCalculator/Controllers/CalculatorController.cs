using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pangot.Calculator;
using Pangot.Calculator.Request;
using PANGOTestCalculator.Models;

namespace PANGOTestCalculator.Controllers
{
    [ApiController]
    [Route("pangot/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly IPangoCalculator _pangoCalculator;
        private readonly IMapper _mapper;

        public CalculatorController(IPangoCalculator pangoCalculator, IMapper mapper)
        {
            _pangoCalculator = pangoCalculator;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(12);
        }

        [HttpGet("Unary")]
        public IActionResult UnariOperation([FromQuery]UnaryCalcRequest request)
        {
            return Ok(_pangoCalculator.ExecuteUnaryOperation(request));
        }

        [HttpGet("Binary")]
        public IActionResult BinaryOperation([FromQuery]BinaryCalcRequest request)
        {
            return Ok(_pangoCalculator.ExecuteBinaryOperation(request));
        }

        //TODO Implemen comma query string separator
        [HttpGet("Expretion{expresion}")]
        public IActionResult Expresion ([FromQuery]ExpresionCalcDto expresion)
        {
            var expretionRequest = _mapper.Map<ExpresionCalcRequest>(expresion);
            return Ok(_pangoCalculator.ExecuteExpresion(expretionRequest));
        }
    }
}