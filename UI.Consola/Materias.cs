using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Materias
     {
        private MateriaLogic matNegocio;

        public Materias() { }
        public MateriaLogic MateriaNegocio
        {
            get
            {
                return matNegocio;
            }
            set
            {
                matNegocio = value;
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
            foreach (Materia mat in MateriaNegocio.GetAll())
            {
                MostrarDatos(mat);
            }
        }
        private void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID de la materia a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                //this.MostrarDatos(MateriaNegocio.GetOne(ID));
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
            Materia materia = new Materia();
            Console.Clear();

            Console.Write("Ingrese la descripcion de la materia: ");
            materia.Descripcion = Console.ReadLine();

            Console.Write("Ingrese el total de horas semanales de la materia: ");
            materia.HSSSemanales = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el total de horas de la materia: ");
            materia.HSTotales = int.Parse(Console.ReadLine());

            MateriaNegocio.Save(materia);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", materia.ID);
        }
        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID de la especialidad a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                //Plan plan = PlanNegocio.GetOne(ID);                                   mepa que esto esta mal, directamente tendriamos que pedir el id de la materia
                //Materia materia = MateriaNegocio.GetOne(ID);

                Console.Write("Ingrese la nueva descripcion: ");
                //materia.Descripcion = Console.ReadLine();

                Console.Write("Ingrese el nuevo total de horas semanales: ");
                //materia.HSSSemanales = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el nuevo total de horas: ");
                //materia.HSTotales = int.Parse(Console.ReadLine());

                //materia.State = BusinessEntity.States.Modified;

                //MateriaNegocio.Save(materia);
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
                Console.Write("Ingrese el ID de la materia a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                MateriaNegocio.Delete(ID);
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

        private void MostrarDatos(Materia mat)
        {
            Console.WriteLine("Materia: {0}", mat.ID);
            Console.WriteLine("\t\t Descripcion: {0} ", mat.Descripcion);
            Console.WriteLine("\t\t Horas semanales: {0} ", mat.HSSSemanales);
            Console.WriteLine("\t\t Horas totales: {0} ", mat.HSTotales);
            Console.WriteLine();
        }
    }
}
