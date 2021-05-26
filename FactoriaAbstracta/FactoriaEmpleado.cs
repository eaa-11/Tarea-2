using AbstractFactory_Single.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Single.Factorias
{
    abstract class FactoriaEmpleado : IFactoriaEmpleado
    {
        public GeneradorCodigo crearCodigo()
        {
            return new GeneradorCodigo();
        }

        public virtual Empleado CrearEmpleado()
        {
            return new Operativo(crearCodigo());
        }
    }
}
