namespace Aula31WhatsApp
{
    public interface IAgenda
    {
        void Cadastrar(Agenda c, Contato contato);
        void Excluir();
        void Listar();
    }
}