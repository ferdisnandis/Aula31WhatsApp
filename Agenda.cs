using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula31WhatsApp
{
    public class Agenda : IAgenda
    {
        private const string PATH = "Database/agenda.csv";



        /// <summary>
        /// Configurar o diretório CSV
        /// </summary>
        public Agenda(){
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
        }
        }
        

        /// <summary>
        /// Adiciona uma linha de dados ao CSV
        /// </summary>
        /// <param name="contato">Informações do contato</param>
        /// <returns></returns>
        public string PrepararLinha(Contato contato)
        {
            return $"Nome:{contato.Nome};Telefone:{contato.Telefone};";
        }

        /// <summary>
        /// Adicionar os contatos na agenda
        /// </summary>
        /// <param name="c">Contato</param>
        public void Cadastrar(Agenda c, Contato contato)
        {
            var linha = new string[] { c.PrepararLinha(contato) };
            File.AppendAllLines(PATH, linha);

        }

        /// <summary>
        /// Excluir contato da agenda
        /// </summary>
        public void Excluir()
        {
             List<string> linhas = new List<string>();

        using(StreamReader arquivo = new StreamReader(PATH))
        {
            string linha;
            while((linha = arquivo.ReadLine()) != null){
              linhas.Add(linha);  
            }
            linhas.RemoveAll(z => z.Contains(PATH));
        }
        //Reescrever o arquivo
        using(StreamWriter output = new StreamWriter(PATH))
        {
            output.Write(String.Join(Environment.NewLine, linhas.ToArray()));
        }
        }

        /// <summary>
        /// Separar o símbolo "=" de dados no csv
        /// </summary>
        /// <param name="dado">Coluna do csv separada</param>
        /// <returns>String com os dados que era do csv</returns>
        public string Separar(string dado)
        { 
            return dado.Split("=")[1];
        }
        public void Listar()
        { 
            //Criar lista para guardar retorno
            List<Contato> cont = new List<Contato>();

            //Lendo as linhas
            string[] linhas = File.ReadAllLines(PATH);

            //Varremos nossas linhas
            foreach(string linha in linhas){
                string[] dado = linha.Split(";");

                Contato c = new Contato();
                c.Nome = Separar( dado[0] );

                cont.Add(c);
            }
            //Ordernar a lista
            cont = cont.OrderBy(z => z.Nome).ToList();
            
        }

    }
    }
