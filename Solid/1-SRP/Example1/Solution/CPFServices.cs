using System;

namespace Solid._1_SRP.Example1.Solution
{
    internal class CPFServices
    {
        public static bool IsValid(string cpf) => cpf.Length == 11;
    }
}