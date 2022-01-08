using System.Collections.Generic;

namespace CriancaFlix.Interfaces
{
    public interface IRepositorio<F>
    {
        List<F> Lista();
        F RetornaPorId(int id);
        void Insere(F entidade);
        void ExcluiFilme(int id);
        void Atualiza(int id, F entidade);
        int ProximoId();
    }
}

