using ApiEventosAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEventosAWS.Data
{
    public class EventosContext: DbContext
    {
        public EventosContext(DbContextOptions<EventosContext> options): base(options) { }  
        public DbSet<CategoriaEvento> CategoriasEventos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
    }
}
