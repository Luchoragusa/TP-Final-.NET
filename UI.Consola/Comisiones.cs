using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Comisiones
    {
        private Business.Logic.ComisionLogic comNegocio;

        public Comisiones() { }
        public Business.Logic.ComisionLogic ComisionNegocio
        {
            get
            {
                return comNegocio;
            }
            set
            {
                comNegocio = value;
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
            foreach (Comision pl in ComisionNegocio.GetAll())
            {
                MostrarDatos(pl);
            }
        }
        private void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del Comision a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(ComisionNegocio.GetOne(ID));
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
            Comision Comision = new Comision();
            Console.Clear();
            //Console.Write("Ingrese ID del Comision: ");   se tiene que autogenerar
            //Comision.ID = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año de la especialidad: ");
            Comision.AnioEspecialidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la descripcion de la comision: ");
            Comision.DescComision = Console.ReadLine();

            Console.Write("Ingrese el ID del plan para la comision: ");
            Comision.IDPlan = int.Parse(Console.ReadLine());

            ComisionNegocio.Save(Comision);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", Comision.ID);
        }
        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID de la Comision a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Comision Comision = ComisionNegocio.GetOne(ID);

                Console.Write("Ingrese la descripcion de la Comision a modificar: ");
                Comision.DescComision = Console.ReadLine();

                Comision.State = BusinessEntity.States.Modified;

                ComisionNegocio.Save(Comision);
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
                Console.Write("Ingrese el ID de la Comision a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                ComisionNegocio.Delete(ID);
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

        private void MostrarDatos(Comision Comision)
        {
            Console.WriteLine("Comision: {0}", Comision.ID);
            Console.WriteLine("\t\t Año especialidad: {0} ", Comision.AnioEspecialidad);
            Console.WriteLine("\t\t Descripcion de la comision: {0} ", Comision.DescComision);
            Console.WriteLine("\t\t ID del plan de la comision: {0}", Comision.IDPlan);
            Console.WriteLine();
        }
    }
}

