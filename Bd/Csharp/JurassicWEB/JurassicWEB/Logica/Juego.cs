using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurassicWEB
{
    [Table("Juego")]
    public abstract class Juego
    {
        [Key]
        [Column("juego")]
        public byte id { get; set; }
        [ForeignKey("Usuario")]
        [Required]
        public Usuario usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
       
    }
}
