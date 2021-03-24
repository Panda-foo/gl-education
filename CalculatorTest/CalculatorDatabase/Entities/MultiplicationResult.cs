
namespace CalculatorDatabase.Entities
{
    public class MultiplicationResult : CalcEntityBase
    {
        public MultiplicationResult()
        {
            Type = CalculationType.Multiply;
        }

        public int Start { get; set; }
        public int By { get; set; }
        public int Result { get; set; }
    }
}
