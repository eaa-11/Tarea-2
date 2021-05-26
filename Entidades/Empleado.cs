using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Single.Entidades
{
    public abstract class Empleado
    {
        private GeneradorCodigo _codigo = null;
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Dep { get; set; }
        public string Cargo { get; set; }
        public double HorasTrabajadas { get; set; }
        public double PrecioxHora { get; set; }
        private double salario;
     
        public Empleado(GeneradorCodigo codigo)
        {
            _codigo = codigo;
        }

        protected double getSalario()
        {
            if ((PrecioxHora > 0) && (HorasTrabajadas > 0))
            {
                salario = PrecioxHora * HorasTrabajadas;
            }
            return salario;
        }

        public override string ToString()
        {
            return 
                $"Codigo:{_codigo.generarCodigo(Dep)}, Nombre:{Nombre}\n"
                + $"Cargo:{Cargo}\n"
                + $"Horas trabajadas:{HorasTrabajadas}\n"
                + $"Precio por hora:{PrecioxHora}\n"
                + $"Salario neto:{SalarioNeto()}";
        }
        public abstract double SalarioNeto();
    }
}
