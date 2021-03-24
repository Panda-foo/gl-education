
namespace CalculatorDatabase.Entities
{
    public class PrimeResult : CalcEntityBase
    {
        public PrimeResult()
        {
            Type = CalculationType.Prime;
        }

        public int Index { get; set; }
        public int Result { get; set; }
    }
}
