using CalculatorDatabase.Entities;
using CalculatorLibrary.Interfaces;
using CalculatorWebsite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculatorWebsite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly ISimpleCalculator _calculator;

        public CalculatorController(ILogger<CalculatorController> logger, ISimpleCalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpPost]
        public double GetCalculation(CalculationRequest request)
        {
            _logger.LogInformation("Processing a calculation request.");

            return request.Type switch
            {
                CalculationType.Add => _calculator.Add(request.Start, request.Amount),
                CalculationType.Subtract => _calculator.Subtract(request.Start, request.Amount),
                CalculationType.Multiply => _calculator.Multiply(request.Start, request.By),
                CalculationType.Divide => _calculator.Divide(request.Start, request.By),
                CalculationType.Prime => _calculator.GetPrimeNumber(request.Index),
                _ => 0,
            };
        }
    }
}
