using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Solution
{
    static class ExecuteSample
    {
        public static void Execute()
        {
            //Manager accountingVP = new Manager();
            //IManaged accountingVP = new Manager();
            IManager accountingVP = new Ceo();
            accountingVP.FirstName = "John";
            accountingVP.LastName = "Nash";
            accountingVP.CalcularePerHourRate(4);

            //it should be able to use manager, instead of Manager
            //Employee emp = new Employee();
            //Employee emp = new Manager(); //ok
            //Employee emp = new Ceo(); //exception, because CEO has no manager


            //Employee emp = new Manager(); //ok
            //Employee emp = new Employee(); //ok

            //BaseEmployee emp = new Employee();
            //IManaged emp = new Employee();
            IManaged emp = new Manager();
            //BaseEmployee emp = new BaseEmployee(); //we can't instantiate base employee
            //BaseEmployee emp = new Ceo();
            emp.FirstName = "Mick";
            emp.LastName = "Jagger";
            emp.AssignManager(accountingVP); //can't do it for CEO
            emp.CalcularePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour.");
        }
    }
}
