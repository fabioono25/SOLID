using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example2.Solution
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
