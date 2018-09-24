using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Solution
{
    class Ceo : BaseEmployee, IManager
    {
        public override void CalcularePerHourRate(int rank) //covariance: not change return type.  - contravariance: not change input type
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview() => Console.WriteLine("I'm reviewing a direct report's performance.");

        public void FireSomeone() => Console.WriteLine("You're fired!");
    }
}
