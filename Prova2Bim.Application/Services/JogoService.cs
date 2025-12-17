using Prova2Bim.Dominio.Entidades;
using Prova2Bim.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2Bim.Application.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _repository;

        public JogoService(IJogoRepository repository)
        {
            _repository = repository;
        }

        public void RegistrarJogo(Jogo jogo)
        {
            _repository.RegistrarJogo(jogo);
        }

        public IEnumerable<Jogo> ListarTodosJogos()
        {
            return _repository.ListarTodosJogos();
        }
    }

}
