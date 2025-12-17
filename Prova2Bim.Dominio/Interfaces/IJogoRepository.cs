using Prova2Bim.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2Bim.Dominio.Interfaces
{
    public interface IJogoRepository
    {
        void RegistrarJogo(Jogo jogo);
        IEnumerable<Jogo> ListarTodosJogos();

    }
}
