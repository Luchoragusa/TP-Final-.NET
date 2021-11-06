using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace UI.Consola
    {
        public class Especialidades
        {
            private EspecialidadLogic espNegocio;

            public Especialidades() { }
            public EspecialidadLogic EspecialidadNegocio
        {
                get
                {
                    return espNegocio;
                }
                set
                {
                    espNegocio = value;
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
                foreach (Especialidad esp in EspecialidadNegocio.GetAll())
                {
                    MostrarDatos(esp);
                }
            }
            private void Consultar()
            {
                try
                {
                    Console.Clear();
                    Console.Write("Ingrese el ID de la especialidad a consultar: ");
                    int ID = int.Parse(Console.ReadLine());
                    //this.MostrarDatos(EspecialidadNegocio.GetOne(ID));
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
                Especialidad especialidad = new Especialidad();
                Console.Clear();

              /*  Console.Write("Ingrese ID de la especialidad: ");
                especialidad.IDEspecialidad = int.Parse(Console.ReadLine()); */

                Console.Write("Ingrese la descripcion de la especialidad: ");
                //especialidad.DescEspecialidad = Console.ReadLine();

                //EspecialidadNegocio.Save(especialidad);
                Console.WriteLine();
               // Console.WriteLine("ID: {0}", especialidad.IDEspecialidad);
            }
            private void Modificar()
            {
                try
                {
                    Console.Clear();
                    Console.Write("Ingrese el ID de la especialidad a modificar: ");
                    int ID = int.Parse(Console.ReadLine());
                    //Plan plan = PlanNegocio.GetOne(ID);                                  
                    //Especialidad especialidad = EspecialidadNegocio.GetOne(ID);

                    Console.Write("Ingrese la nueva descripcion: ");
                    //especialidad.DescEspecialidad = Console.ReadLine();

                    //especialidad.State = BusinessEntity.States.Modified;

                    //EspecialidadNegocio.Save(especialidad);
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
                    Console.Write("Ingrese el ID de la especialidad a eliminar: ");
                    int ID = int.Parse(Console.ReadLine());
                    EspecialidadNegocio.Delete(ID);
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

            private void MostrarDatos(Especialidad esp)
            {
               /* Console.WriteLine("Especialidad: {0}", esp.IDEspecialidad);*/
                Console.WriteLine("\t\t Descripcion: {0} ", esp.DescEspecialidad);
                Console.WriteLine();
            }
        }
}

