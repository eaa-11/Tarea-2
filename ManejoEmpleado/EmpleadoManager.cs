
using AbstractFactory_Single.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractFactory_Single.ManejoEmpleado
{
    public class EmpleadoManager
    {
        private Empleado emp = null;

        public void CreandoEmpleado()
        {
            Console.Clear();
            Console.WriteLine("\tEmpleado a registrar\n");
            Console.WriteLine("1.Gerencial");
            Console.WriteLine("2.Operativo");
            Console.WriteLine("3.Administrativo");
            Console.Write("Opcion: ");
            string opc = Console.ReadLine();
            emp = FactoriaProveedor.crearEmpleado(opc);
            RegistrandoEmpleado(); 
        }

        private Empleado RegistrandoEmpleado()
        {
            Console.Clear();
            Console.WriteLine("REGISTRANDO EMPLEADO");
            Console.Write("\nCedula: ");
            emp.Cedula = Console.ReadLine();
            Console.Write("Nombre: ");
            emp.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            emp.Apellido = Console.ReadLine();
            Console.Write("Email: ");
            emp.Email = Console.ReadLine();
            Console.Write("Telefono: ");
            emp.Telefono = Console.ReadLine();
            Console.Write("Departamento: ");
            emp.Dep = Console.ReadLine();
            Console.Write("Cargo: ");
            emp.Cargo = Console.ReadLine();
            Console.Write("Horas trabajadas: ");
            emp.HorasTrabajadas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Precio por hora: ");
            emp.PrecioxHora = Convert.ToDouble(Console.ReadLine());
            Menu.empleados.Add(emp);

            Console.WriteLine("Empleado creado!");
            Thread.Sleep(2000);

            Salir();
            return emp;
        }

        public void VerEmpleado()
        {
            Console.Clear();
            Console.WriteLine("MOSTRANDO EMPLEADOS...");
            for (int i = 0; i < Menu.empleados.Count; i++)
            {
                Console.WriteLine($"\n{i}. Empleado: {Menu.empleados[i].Nombre} Cargo: {Menu.empleados[i].Cargo}");
            }
            Salir();
        }

        public void Cobrar()
        {
            Console.Clear();
            Console.WriteLine("-Empleado a cobrar...");
            for (int i = 0; i < Menu.empleados.Count; i++)
            {
                Console.WriteLine($"\n{i}.{Menu.empleados[i].Nombre}");
            }
            Console.Write("\n-Indice del empleado para cobrar: ");
            int e = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"\nSalario neto: {Menu.empleados[e].SalarioNeto()}"); 
            Salir(); 
        }

        public void getRecibo()
        {
            Console.Clear();
            Console.WriteLine("-Recibo del empleado...");
            for (int i = 0; i < Menu.empleados.Count; i++)
            {
                Console.WriteLine($"\n{i} --> {Menu.empleados[i].Nombre}");
            }
            Console.Write("\n-Indice del empleado: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\tRECIBO");
            Console.WriteLine(Menu.empleados[e].ToString());
            Salir();
        }

        public void Salir()
        {
            Console.WriteLine("\nPresione \"Enter\" para salir");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Saliendo...");
                Thread.Sleep(1000);
            }
        }
    }
}