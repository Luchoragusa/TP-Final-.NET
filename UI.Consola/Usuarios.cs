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
            Console.WriteLine("2) Consultar");
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
                        break;
                    }
            }
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
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException)
            {
                Console.WriteLine("La ID ingresada debe ser un número entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }

        }       
        private void Agregar()
        {
            Usuario usuario = new Usuario();
            Console.Clear();
            Console.Write("Ingrese Nombre: ");

            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");

            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre de Usuario: ");

            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese Clave: ");

            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese Email: ");

            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese Habilitación de Usuario (1-Si/otro-No): ");

            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;

            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usuario.ID);
        }
        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());

                Usuario usuario = UsuarioNegocio.GetOne(ID);

                Console.Write("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();

                Console.Write("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();

                Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();

                Console.Write("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();

                Console.Write("Ingrese Email: ");
                usuario.Email = Console.ReadLine();

                Console.Write("Ingrese Habilitación de Usuario (1-Si/otro-No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;

                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException)
            {
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException)
            {
                Console.WriteLine("La ID ingresada debe ser un número entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }
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
