using System;

namespace CriancaFlix
{
    public class Filme: EntidadeBase
    {        
        private string  Nome{ get; set; }        
        private int Idade  { get; set; }
        private int Ano { get; set; }
        private bool Excluir { get; set; }

        public Filme(int id, string nome, int idade, int ano)
        {
            this.Id = id;
            this.Nome = nome;           
            this.Idade = idade;
            this.Ano = ano;
            this.Excluir = false;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";            
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Idade: " + this.Idade + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluir;
            return retorno;
        }

        public string retornaNome()
        {
            return this.Nome;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluir;
        }

        public void ExcluirFilme()
        {
            this.Excluir = true;
        }






    }
}
