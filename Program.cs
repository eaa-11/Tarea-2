using AbstractFactory_Single.Entidades;
using AbstractFactory_Single.Factorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AbstractFactory_Single.ManejoEmpleado;

namespace AbstractFactory_Single
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu controller = new Menu();
            controller.menu();
        }
    }
}
