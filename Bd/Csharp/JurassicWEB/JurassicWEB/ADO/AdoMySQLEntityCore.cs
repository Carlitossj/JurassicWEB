using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace JurassicWEB.ADO
{
    public class AdoMySQLEntityCore : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=localhost;database=JurassicWeB;user=root;password=root");
        }
        public void agregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
            SaveChanges();
        }
        public void actualizarUsuario(Usuario usuario)
        {
            this.Update<Usuario>(usuario);
            SaveChanges();
        }
        public List<Usuario> obtenerUsuario() => Usuarios.ToList();

    }
}
