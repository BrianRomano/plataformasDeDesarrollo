using System;
using System.Collections.Generic;
using System.Text;

namespace Clase6
{
    class Usuario
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public bool esADM { get; set; }
        public bool bloqueado { get; set; }
        
        public Usuario( int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            dni = Dni;
            nombre = Nombre;
            mail = Mail;
            password = Password;
            esADM = EsADM;
            bloqueado = Bloqueado;
        }

    }
}
