using ApiEventosAWS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEventosAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryEventos repo;
        public EventosController(RepositoryEventos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetEventos()
        {
            return Ok(await this.repo.Eventos());
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetCategoriasEventos()
        {
            return Ok(await this.repo.CategoriasEventos());
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetEventosPorCategoria(int id)
        {
            return Ok(await this.repo.EventosCategoria(id));
        }
    }
}
