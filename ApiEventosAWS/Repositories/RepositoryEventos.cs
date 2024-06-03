using ApiEventosAWS.Data;
using ApiEventosAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEventosAWS.Repositories
{
    public class RepositoryEventos
    {
        private EventosContext context;
        public RepositoryEventos(EventosContext context)
        {
            this.context = context;
        }

        public async Task<List<Evento>> Eventos()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<Evento>> EventosCategoria(int id)
        {
            var response = from datos in this.context.Eventos
                           where datos.IdCategoria == id
                           select datos;
            return await response.ToListAsync();
        }

        public async Task<List<CategoriaEvento>> CategoriasEventos()
        {
            return await this.context.CategoriasEventos.ToListAsync();
        }

    }
}
