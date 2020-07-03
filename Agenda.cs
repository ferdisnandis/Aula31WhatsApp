using System.Collections.Generic;
using System.IO;

namespace Aula31WhatsApp
{
    public class Agenda : IAgenda
    {
        List<Contato> Contatos;
        private const string PATH = "Database/agenda.csv";

        private string PrepararLinha(Agenda contato)
        {
            return $"N";
        }
        public void Cadastrar(Agenda c)
        {
            var linha = new string[] { c.PrepararLinha(c) };
            File.AppendAllLines(PATH, linha);
        }

        public void Excluir()
        {
            throw new System.NotImplementedException();
        }

        public void Listar()
        {
            throw new System.NotImplementedException();
        }


        public void Cadastrar()
        {
            throw new System.NotImplementedException();
        }
    }
}