using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Violation
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Manager { get; set; } = null;
        public decimal Salary { get; set; }

        public virtual void AssignManager(Employee manager)
        {
            //tasks
            Manager = manager;
        }

        public virtual void CalcularePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
