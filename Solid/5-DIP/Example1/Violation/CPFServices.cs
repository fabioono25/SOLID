using System;

namespace Solid.DIP.Example1.Violation
{
    internal class CPFServices
    {
        public static bool IsValid(string cpf) => cpf.Length == 11;
    }
}