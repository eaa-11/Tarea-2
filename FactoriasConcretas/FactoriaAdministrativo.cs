using AbstractFactory_Single.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Single.Factorias
{
    class FactoriaAdministrativo : FactoriaEmpleado
    {
        public override Empleado CrearEmpleado()
        {
            return new Administrativo(crearCodigo());
        }
    }
}
