namespace Aula31WhatsApp
{
    public class Mensagem : Contato
    {
        public string Texto;
        public string Contato;

        public string Enviar(){
            return "Sua mensagem foi enviada";
        }


        /// <summary>
        /// Incluir linha com a mensagem enviada
        /// </summary>
        /// <param name="texto">Mensagem enviada</param>
        /// <returns>Salvar a mensagem no CSV</returns>
        public string PrepararLinhaMSG(Mensagem texto)
        {
            return $"Sua mensagem: {texto.Texto}";
        }
    }
}