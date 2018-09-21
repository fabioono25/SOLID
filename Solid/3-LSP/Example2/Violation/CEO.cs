using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Violation
{
    class Ceo : Employee
    {
        public override void CalcularePerHourRate(int rank) //covariance: not change return type.  - contravariance: not change input type
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager");
        }

        public void GeneratePerformanceReview() => Console.WriteLine("I'm reviewing a direct report's performance.");

        public void FindSomeone() => Console.WriteLine("You're fired!");
    }
}
