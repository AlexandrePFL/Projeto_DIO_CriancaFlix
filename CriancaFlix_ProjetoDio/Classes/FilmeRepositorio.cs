using System;
using System.Collections.Generic;
using CriancaFlix.Interfaces;


namespace CriancaFlix
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {

        private List<Filme> ListaFilme = new List<Filme>();
        public void Atualiza(int id, Filme entidade)
        {
            ListaFilme[id] = entidade; 
        }

        public void ExcluiFilme(int id)
        {
            ListaFilme[id].ExcluirFilme();
        }

        public void Insere(Filme entidade)
        {
            ListaFilme.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return ListaFilme;
        }

        public int ProximoId()
        {
            return ListaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return ListaFilme[id];
        }
    }
}
