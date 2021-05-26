using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Single.Entidades
{
    class Administrativo:Empleado
    {
        public Administrativo(GeneradorCodigo codigo):base(codigo)
        {

        }

        public override double SalarioNeto()
        {
            double salarioNeto = getSalario() + (getSalario() * 0.25);
            return salarioNeto;
        }
    }
}
