namespace Solid.ISP.Example1.Violation
{
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            //validar CPF, Email
            throw new System.NotImplementedException();
        }

        public void SalvarBanco()
        {
            //insert tabela cliente
            throw new System.NotImplementedException();
        }

        public void ValidarDados()
        {
            //enviar e-mail para cliente
            throw new System.NotImplementedException();
        }
    }
}