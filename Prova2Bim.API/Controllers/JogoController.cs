using Microsoft.AspNetCore.Mvc;
using Prova2Bim.Application.Services;
using Prova2Bim.Dominio.Entidades;
using Prova2Bim.Dominio.Interfaces;

namespace Prova2Bim.API.Controllers
{
    public class JogoController : Controller
    {
        private readonly IJogoService _service;

        public JogoController(IJogoService service)
        {
            _service = service;
        }

        [HttpPost("RegistrarJogo")]
        public IActionResult RegistrarJogo([FromBody] Jogo jogo)
        {
            _service.RegistrarJogo(jogo);
            return Ok("Jogo registrado com sucesso");
        }

        [HttpGet("ListarTodosJogos")]
        public IActionResult ListarTodosJogos()
        {
            var jogos = _service.ListarTodosJogos();
            return Ok(jogos);
        }
    }
}
