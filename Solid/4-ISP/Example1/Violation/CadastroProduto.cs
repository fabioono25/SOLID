namespace Solid.ISP.Example1.Violation
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            //validar valor
            throw new System.NotImplementedException();
        }

        public void SalvarBanco()
        {
            //insert tabela produto
            throw new System.NotImplementedException();
        }

        public void ValidarDados()
        {
            //produto nao tem e-mail, o que faço agora?!?
            throw new System.NotImplementedException();
        }
    }
}