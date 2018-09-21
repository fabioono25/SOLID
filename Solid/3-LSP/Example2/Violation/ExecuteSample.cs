using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Violation
{
    static class ExecuteSample
    {
        public static void Execute()
        {
            Manager accountingVP = new Manager();
            accountingVP.FirstName = "John";
            accountingVP.LastName = "Nash";
            accountingVP.CalcularePerHourRate(4);

            //it should be able to use manager, instead of Manager
            //Employee emp = new Employee();
            //Employee emp = new Manager(); //ok
            Employee emp = new Ceo(); //exception, because CEO has no manager
            emp.FirstName = "Mick";
            emp.LastName = "Jagger";
            emp.AssignManager(accountingVP); //can't do it for CEO
            emp.CalcularePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour.");
        }
    }
}
