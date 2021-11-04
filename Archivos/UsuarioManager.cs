using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Clase5
{
    class UsuarioManager
    {
        private List<Usuario> misUsuarios;
        private List<string> misUsuariosArchivo;
        private string pathArchivos;
        private const string archivoUsuarios="Usuarios.txt";
        private int cantidadUsuarios;

        public UsuarioManager(string Path)
        {
            misUsuarios = new List<Usuario>();
            misUsuariosArchivo = new List<string>();
            pathArchivos = Path;
            cantidadUsuarios = 0;
            inicializarAtributos();
        }

        private void inicializarAtributos()
        {
            try
            {
                if (File.Exists(Path.Combine(pathArchivos, archivoUsuarios)))
                {
                    string[] usuarios = File.ReadAllLines(Path.Combine(pathArchivos, archivoUsuarios));
                    foreach (string unUsuario in usuarios)
                    {
                        if (!unUsuario.Equals(""))
                        {
                            string[] componentes = unUsuario.Split(',');
                            Usuario user = new Usuario(int.Parse(componentes[0]), int.Parse(componentes[1]), componentes[2], componentes[3], componentes[4], bool.Parse(componentes[5]), bool.Parse(componentes[6]));
                            misUsuarios.Add(user);
                            misUsuariosArchivo.Add(unUsuario);
                        }
                        else
                        {
                            misUsuarios.Add(null);
                            misUsuariosArchivo.Add("");
                        }
                        cantidadUsuarios++;
                    }
                    
                }
                else
                {
                    File.Create(Path.Combine(pathArchivos, archivoUsuarios)).Close();
                    
                }
            }
            catch (Exception)
            {

            }
        }

        public List<List<string>> obtenerUsuarios()
        {
            List<List<string>> salida = new List<List<string>>();
            foreach (Usuario u in misUsuarios)
                if(u!=null)
                    salida.Add(new List<string>() {u.id.ToString(), u.dni.ToString(), u.nombre, u.mail, u.password, u.esADM.ToString(), u.bloqueado.ToString() });
            return salida;
        }

        public bool agregarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            try
            {
                //Ahora sí lo agrego en la lista
                Usuario nuevo = new Usuario(cantidadUsuarios, Dni, Nombre, Mail, Password, EsADM, Bloqueado);
                File.AppendAllText(Path.Combine(pathArchivos, archivoUsuarios), nuevo.ToString() + "\n");
                misUsuarios.Add(nuevo);
                misUsuariosArchivo.Add(nuevo.ToString());
                cantidadUsuarios++;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool eliminarUsuario(int ID)
        {
            Usuario aEliminar = misUsuarios[ID];
            try
            {
                misUsuariosArchivo[ID] = "";
                File.WriteAllLines(Path.Combine(pathArchivos, archivoUsuarios),misUsuariosArchivo.ToArray());
                misUsuarios[ID] = null;
                return true;
            }
            catch(Exception)
            {
                misUsuariosArchivo[ID] = aEliminar.ToString();
                misUsuarios[ID] = aEliminar;
                return false;
            }
        }

        public bool modificarUsuario(int ID, int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            Usuario aModificar = misUsuarios[ID];
            try
            {
                Usuario nuevo = new Usuario(ID, Dni, Nombre, Mail, Password, EsADM, Bloqueado);
                misUsuariosArchivo[ID] = nuevo.ToString();
                File.WriteAllLines(Path.Combine(pathArchivos, archivoUsuarios), misUsuariosArchivo.ToArray());
                misUsuarios[ID] = nuevo;
                return true;
            }
            catch (Exception)
            {
                misUsuariosArchivo[ID] = aModificar.ToString();
                misUsuarios[ID] = aModificar;
                return false;
            }
        }
    }
}
