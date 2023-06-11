namespace My_Project_Academia.Model
{
    public class Conexao
    {
        public string Usuario { get; private set; }
        public string Senha { get; private set; }

        public Conexao()
        {

        }

        //Gerando metodo de conecçao login
        public Conexao(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

    }
}
