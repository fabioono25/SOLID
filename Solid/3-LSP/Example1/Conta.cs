using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example1
{
    class Conta
    {
        public virtual int Id { get; set; }
        public Conta(int contaId)
        {
            Id = contaId;
        }

        public virtual void Saque(decimal valor) => Console.WriteLine("saque na classe base");
    }

    class ContaPoupanca : Conta
    {
        public ContaPoupanca(int contaPoupancaId) : base(contaPoupancaId)
        {
        }

        public override void Saque(decimal valor) => Console.WriteLine("saque na classe derivada");
    }

    public static class Sample
    {
        public static void ExecuteSample()
        {
            var c1 = new Conta(1);
            c1.Saque(12);

            //usando Liskov
            var c2 = new ContaPoupanca(2);
            c2.Saque(20);
        }
    }
}
