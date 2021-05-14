using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        private Business.Logic.UsuarioLogic usNegocio;

        public Usuarios()
        {
            
        }

        public Business.Logic.UsuarioLogic UsuarioNegocio
        {
            get
            {
                return usNegocio;
            }
            set
            {
                usNegocio = value;
            }
        }

        public void Menu()
        {
            ConsoleKeyInfo op;
            Console.WriteLine("MENU.");
            Console.WriteLine("1) Listado General");
            Console.WriteLine("2) Consulta");
            Console.WriteLine("3) Agregar");
            Console.WriteLine("4) Modificar");
            Console.WriteLine("5) Eliminar");
            Console.WriteLine("6) Salir");
            Console.WriteLine("Ingrese una opcion: ");
            
            op = Console.ReadKey();

            switch (op.KeyChar)
            {
                case '1':
                {
                        ListadoGeneral();
                        break;
                }
                case '2':
                    {
                        Consultar();
                        break;
                    }
                case '3':
                    {
                        Agregar();
                        break;
                    }
                case '4':
                    {
                        Modificar();
                        break;
                    }
                case '5':
                    {
                        Eliminar();
                        break;
                    }
                case '6':
                    {
                        MostrarDatos();
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            
        }

        private void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }
        private void Consultar()
        {

        }       
        private void Agregar()
        {

        }
        private void Modificar()
        {

        }
        private void Eliminar()
        {

        }

        private void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\t Nombre: {0} ", usr.Nombre);
            Console.WriteLine("\t\t Apellido: {0} ", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);                  
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            // \t dentro de un string representa un TAB
            Console.WriteLine();
        }
    }
}
