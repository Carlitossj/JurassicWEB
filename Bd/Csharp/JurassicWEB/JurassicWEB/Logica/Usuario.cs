using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JurassicWEB.Logica;

namespace JurassicWEB
{
    [Table("Usuario")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("idUsuaio")]
        public short id { get; set; }

        [Column("NombredeUsuaio")]
        [Required]
        [StringLength(45)]
        public string nombre_usuario { get; set; }

        [Column("Contraseña")]
        [Required]
        [StringLength(45)]
        public  string contrasenia { get; set; }

        public List<HistorialPuntos> Proyecciones { get; set; }
        public Usuario() { }

    }
}
