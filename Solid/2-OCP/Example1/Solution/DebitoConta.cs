using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._2_OCP.Solution
{
    //classe fechada, atendendo SRP e OCP
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        //obrigado implementar e herdar
        public abstract string Debitar(decimal valor, string conta);
    }

    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return NumeroTransacao;
        }
    }

    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //debita conta invstimentos
            //isenta taxas
            return NumeroTransacao;
        }
    }

    public class DebitoPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //valida aniversario da conta
            //debita conta poupanca
            return NumeroTransacao;
        }
    }
}
