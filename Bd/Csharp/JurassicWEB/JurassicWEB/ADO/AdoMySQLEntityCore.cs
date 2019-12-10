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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Usuario>().
                HasIndex(u => u.nombre_usuario).
                IsUnique();

            base.OnModelCreating(mb);
        }
        public Usuario buscarUsuario(string nombreusuario, string pass)
        {
            return Usuarios.FirstOrDefault(u=>u.nombre_usuario== nombreusuario && u.contrasenia == pass);
        }

    }
}
