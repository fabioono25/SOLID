using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Solution
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public void AssignManager(IEmployee manager)
        {
            //tasks
            Manager = manager;
        }
    }
}
