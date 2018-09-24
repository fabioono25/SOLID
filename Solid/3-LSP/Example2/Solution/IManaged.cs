using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Solution
{
    public interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}
