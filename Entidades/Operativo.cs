using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Single.Entidades
{
    class Operativo : Empleado
    {
        public Operativo(GeneradorCodigo codigo) :base(codigo)
        {

        }

        public override double SalarioNeto()
        {
            double salarioNeto = getSalario() + (getSalario() * 0.10);
            return salarioNeto;
        }
    }
}
