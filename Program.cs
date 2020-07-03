using System;

namespace Aula31WhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            Contato contato = new Contato();
            Mensagem msg = new Mensagem();


            //Incluir nome e número do contato
            System.Console.WriteLine("Digite o nome do contato que deseja enviar mensagem:");
            contato.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite o número de telefone do contato:");
            contato.Telefone = Console.ReadLine();

            agenda.Cadastrar(agenda, contato);
        }
    }
}
