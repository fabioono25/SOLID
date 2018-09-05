using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._2_OCP.Violation
{
    //in the case of add a new type of account, it'll generate problems
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                //debita conta corrente
                
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                //valida aniversario
                //debita poupança
            }

            //caso precise adicionar mais um tipo de conta, quebro tudo!
        }
    }

    public enum TipoConta
    {
        Corrente,
        Poupanca
    }
}
