using CalculatorDatabase.Entities;

namespace CalculatorDatabase
{
    public interface ICalculatorRepository
    {
        void WriteResult<T>(T entity) where T : CalcEntityBase;
    }
}