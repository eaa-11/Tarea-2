using AbstractFactory_Single.Entidades;
using AbstractFactory_Single.Factorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Unity;

namespace AbstractFactory_Single
{
    public static class FactoriaProveedor
    {
        static UnityContainer factoriaEmpleados = new UnityContainer();

        static FactoriaProveedor()
        {
            factoriaEmpleados.RegisterType<IFactoriaEmpleado, FactoriaGerencial>("1");
            factoriaEmpleados.RegisterType<IFactoriaEmpleado, FactoriaOperativo>("2");
            factoriaEmpleados.RegisterType<IFactoriaEmpleado, FactoriaAdministrativo>("3");
        }
        public static Empleado crearEmpleado(string tipo)
        {
            return factoriaEmpleados.Resolve<IFactoriaEmpleado>(tipo).CrearEmpleado();
        }
    }
}
