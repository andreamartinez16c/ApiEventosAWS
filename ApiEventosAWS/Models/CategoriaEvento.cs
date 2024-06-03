using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiEventosAWS.Models
{
    [Table("categoriaevento")]
    public class CategoriaEvento
    {
        [Key]
        [Column("idcategoria")]
        public int Idcategoria { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
