using System;

namespace CalculatorDatabase.Entities
{
    public class CalcEntityBase
    {
        public int Id { get; set; }

        public CalculationType Type { get; set; } = CalculationType.NotSet;

        public string Message { get; set; }

        public DateTime CreatedAt { get; set; }


        public CalcEntityBase()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
