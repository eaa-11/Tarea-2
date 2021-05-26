using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Single.Entidades
{
    class Gerencial:Empleado
    {
        private static Gerencial gerencial;

        private Gerencial(GeneradorCodigo codigo):base(codigo)
        {

        }
        public static Gerencial getGerencial(GeneradorCodigo cod)
        {
            if (gerencial == null)
            {
                gerencial = new Gerencial(cod);
            }
            else
            {
                throw new Exception("Ya ha sido creadao!");
            }
            return gerencial;
        }
        public override double SalarioNeto()
        {
            double salarioNeto = getSalario() + (getSalario() * 0.50);
            return salarioNeto;
        }
    }
}
