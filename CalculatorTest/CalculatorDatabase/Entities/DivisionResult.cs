
namespace CalculatorDatabase.Entities
{
    public class DivisionResult : CalcEntityBase
    {
        public DivisionResult()
        {
            Type = CalculationType.Divide;
        }

        public int Start { get; set; }
        public int By { get; set; }
        public float Result { get; set; }
    }
}
