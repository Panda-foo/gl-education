
namespace CalculatorDatabase.Entities
{
    public class AdditionResult : CalcEntityBase
    {
        public AdditionResult()
        {
            Type = CalculationType.Add;
        }

        public int Start { get; set; }
        public int Amount { get; set; }
        public int Result { get; set; }
    }
}
