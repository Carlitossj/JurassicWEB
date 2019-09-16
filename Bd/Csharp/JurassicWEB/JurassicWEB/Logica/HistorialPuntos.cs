using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace JurassicWEB.Logica
{
    [Table("HistorialPuntos")]
    public class HistorialPuntos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("idHistorialPuntos")]
        public short id { get; set; }
        [ForeignKey("Usuario")]
        [Required]
        Usuario usuario { get; set; }
        [Column("FechaHora")]
        [Required]
        public DateTime fecha_hora { get; set; }
        [Column("Puntos")]
        [Required]
        public short puntos { get; set; }
        public HistorialPuntos() { }
        public bool Entre(DateTime Inicio, DateTime fin)
        {
            return Inicio <= fecha_hora && fecha_hora <= fin;
        }
    }
}
