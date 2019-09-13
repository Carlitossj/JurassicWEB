using JurassicWEB;
using JurassicWEB.ADO;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestJurassicWeb
{
    [TestClass]
    public class UnitTest1
    {
        
        
        Usuario usuario { get; set; }
        public void SETUP()
        {
            usuario = new Usuario();
            usuario.nombre_usuario = "anakin";
                usuario.contrasenia = "gigigigigi";
        }
       
        [TestMethod]
        public void CrearBD()
        {
            AdoMySQLEntityCore ado = new AdoMySQLEntityCore();
            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();
            ado.agregarUsuario(usuario);
        }
    }

}
