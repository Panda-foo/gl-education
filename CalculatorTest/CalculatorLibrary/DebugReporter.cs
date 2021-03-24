using CalculatorDatabase;
using CalculatorDatabase.Entities;
using CalculatorLibrary.Interfaces;
using System.Diagnostics;

namespace CalculatorLibrary
{
    public class DebugReporter : IDebugReport
    {
        private ICalculatorRepository _repository { get; set; }

        public DebugReporter(ICalculatorRepository calculatorRepository)
        {
            _repository = calculatorRepository;
        }

        public void ReportResult(string message)
        {
            Debug.Write(message);
        }

        public void WriteToDatabase<T>(T entity) where T : CalcEntityBase
        {
            _repository.WriteResult<T>(entity);
        }
    }
}
