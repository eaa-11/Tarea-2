using AbstractFactory_Single.Entidades;
using AbstractFactory_Single.ManejoEmpleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractFactory_Single
{
    class Menu
    {
        public static List<Empleado> empleados = new List<Empleado>();

        public void menu()
        {
            EmpleadoManager Manager = new EmpleadoManager();

            int opc = 0;
            while (opc != 5)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\t\tMENU\n\t"
                            + "1.Registro Empleado.\n\t"
                            + "2.Ver Empleado.\n\t"
                            + "3.Cobrar.\n\t"
                            + "4.Recibo de pago.\n\t"
                            + "5.Salir.\n");
                    Console.Write("\n\tDigite la opcion: ");
                    opc = Convert.ToInt32(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Manager.CreandoEmpleado();
                            break;
                        case 2:
                            Manager.VerEmpleado();
                            break;
                        case 3:
                            Manager.Cobrar();
                            break;
                        case 4:
                            Manager.getRecibo();
                            break;
                        case 5:
                            Manager.Salir();
                            break;
                        default:
                            Console.WriteLine("N/A!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nError : " + e.Message);
                }
                Console.Clear();
            }
        }
    }
}
