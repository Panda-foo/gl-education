

using CalculatorDatabase.Entities;

namespace CalculatorLibrary.Interfaces
{
    public interface IDebugReport
    {
        void ReportResult(string message);
        void WriteToDatabase<T>(T entity) where T : CalcEntityBase;
    }
}
