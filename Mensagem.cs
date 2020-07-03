namespace Aula31WhatsApp
{
    public class Mensagem : Contato
    {
        public string Texto;
        public string Contato;

        public string Enviar(Contato Contato){
            return $"Sua mensagem foi enviada para {Contato.Nome}";
        }
    }
}