using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Planes 
    {
        private Business.Logic.PlanLogic plNegocio;

        public Planes() { }
        public Business.Logic.PlanLogic PlanNegocio
        {
            get
            {
                return plNegocio;
            }
            set
            {
                plNegocio = value;
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
            foreach (Plan pl in PlanNegocio.GetAll())
            {
                MostrarDatos(pl);
            }
        }
        private void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del plan a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(PlanNegocio.GetOne(ID));
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
            Plan plan = new Plan();
            Console.Clear();
            //Console.Write("Ingrese ID del plan: ");   se tiene que autogenerar
            //plan.ID = int.Parse(Console.ReadLine());

            Console.Write("Ingrese ID de la especialidad del plan: ");
            plan.IDEspecialidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la descripcion del plan: ");
            plan.Descripcion = Console.ReadLine();

            PlanNegocio.Save(plan);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", plan.ID);
        }
        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID de la especialidad del plan a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Plan plan = PlanNegocio.GetOne(ID);

                Console.Write("Ingrese la descripcion del plan a modificar: ");
                plan.Descripcion = Console.ReadLine();

                plan.State = BusinessEntity.States.Modified;

                PlanNegocio.Save(plan);
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
                Console.Write("Ingrese el ID del plan a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                PlanNegocio.Delete(ID);
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

        private void MostrarDatos(Plan plan)
        {
            Console.WriteLine("Plan: {0}", plan.ID);
            Console.WriteLine("\t\t ID Especialidad: {0} ", plan.IDEspecialidad);
            Console.WriteLine("\t\t Descripcion: {0} ", plan.Descripcion);
            Console.WriteLine();
        }
    }

}

