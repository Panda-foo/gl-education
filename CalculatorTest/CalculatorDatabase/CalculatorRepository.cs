using CalculatorDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDatabase
{
    public class CalculatorRepository : ICalculatorRepository
    {
        private readonly CalculatorContext _context;

        public CalculatorRepository(CalculatorContext context)
        {
            _context = context;
        }

        public void WriteResult<T>(T entity) where T : CalcEntityBase
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}
