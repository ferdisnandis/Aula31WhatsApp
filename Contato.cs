namespace Aula31WhatsApp
{
    public class Contato
    {
        public string Nome;
        public string Telefone;
        public string Contatos(Contato contato)
        {
            return $"Nome: {contato.Nome} \nTelefone {contato.Telefone}";
        }
    }
}