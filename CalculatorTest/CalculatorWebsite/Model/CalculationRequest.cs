using CalculatorDatabase.Entities;

namespace CalculatorWebsite.Model
{
    public class CalculationRequest
    {
        public CalculationType Type { get; set; }

        public int Start { get; set; }

        public int Amount { get; set; }

        public int By { get; set; }

        public int Index { get; set; }
    }
}
