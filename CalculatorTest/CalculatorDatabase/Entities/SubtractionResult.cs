
namespace CalculatorDatabase.Entities
{
    public class SubtractionResult : CalcEntityBase
    {
        public SubtractionResult()
        {
            Type = CalculationType.Subtract;
        }

        public int Start { get; set; }
        public int Amount { get; set; }
        public int Result { get; set; }
    }
}
