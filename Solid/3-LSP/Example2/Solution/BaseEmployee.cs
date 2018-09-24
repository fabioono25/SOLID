using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Solution
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        
        public virtual void CalcularePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
