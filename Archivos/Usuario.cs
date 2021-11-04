using System;
using System.Collections.Generic;
using System.Text;

namespace Clase5
{
    class Usuario
    {
        public int id { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public bool esADM { get; set; }
        public bool bloqueado { get; set; }
        
        public Usuario( int Id, int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            id = Id;
            dni = Dni;
            nombre = Nombre;
            mail = Mail;
            password = Password;
            esADM = EsADM;
            bloqueado = Bloqueado;
        }
        public override string ToString()
        {
            return id +"," + dni + "," + nombre + "," + mail + "," + password + "," + esADM + "," + bloqueado;
        }

    }
}
