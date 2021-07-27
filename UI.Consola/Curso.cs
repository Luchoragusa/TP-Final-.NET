using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic.EntidadesLogic;

namespace UI.Consola
{
    public class Curso
    {
        private Business.Logic.EntidadesLogic.CursoLogic curNegocio;

        public Curso()
        {

        }
        public Business.Logic.EntidadesLogic.CursoLogic CursoNegocio
        {
            get
            {
                return curNegocio;
            }
            set
            {
                curNegocio = value;
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
            foreach (Business.Entities.Curso cur in CursoNegocio.GetAll())
            {
                MostrarDatos(cur);
            }
        }
        private void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del curso a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(CursoNegocio.GetOne(ID));
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
            Business.Entities.Curso curso = new Business.Entities.Curso();
            Console.Clear();
            Console.Write("Ingrese ID de la materia: ");
            curso.IDMateria = int.Parse(Console.ReadLine());

            Console.Write("Ingrese ID de la comision: ");
            curso.IDComision = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año calendario: ");
            curso.AnioCalendario = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cupo: ");
            curso.Cupo = int.Parse(Console.ReadLine());          

            CursoNegocio.Save(curso);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", curso.ID);
        }
        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());

                Business.Entities.Curso curso = CursoNegocio.GetOne(ID);

                Console.Write("Ingrese ID de la materia: ");
                curso.IDMateria = int.Parse(Console.ReadLine());

                Console.Write("Ingrese ID de la comision: ");
                curso.IDComision = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el año calendario: ");
                curso.AnioCalendario = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el cupo: ");
                curso.Cupo = int.Parse(Console.ReadLine());

                CursoNegocio.Save(curso);
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
                Console.Write("Ingrese el ID del curso a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                CursoNegocio.Delete(ID);
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

        private void MostrarDatos(Business.Entities.Curso cur)
        {
            Console.WriteLine("Curso: {0}", cur.ID);
            Console.WriteLine("\t\tID Materia: {0} ", cur.IDMateria);
            Console.WriteLine("\t\tID Comision: {0} ", cur.IDComision);
            Console.WriteLine("\t\tAño calendario: {0}", cur.AnioCalendario);
            Console.WriteLine("\t\tCupo: {0}", cur.Cupo);

            Console.WriteLine();
        }


    }
}
