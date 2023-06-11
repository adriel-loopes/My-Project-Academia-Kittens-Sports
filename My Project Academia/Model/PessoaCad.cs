namespace My_Project_Academia.Model
{
    public class PessoaCad
    {
        public string NomeCompleto { get; private set; }
        public string Email { get; private set; }
        public string Usuario { get; private set; }
        public string Senha { get; private set; }

        public PessoaCad()
        {

        }

        public PessoaCad(string nomeCompleto, string email, string usuario, string senha)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            Usuario = usuario;
            Senha = senha;
        }
    }

    
}
