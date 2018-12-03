using System;

namespace Solid.DIP.Example1.Solution
{
    internal class CPFServices
    {
        public static bool IsValid(string cpf) => cpf.Length == 11;
    }
}