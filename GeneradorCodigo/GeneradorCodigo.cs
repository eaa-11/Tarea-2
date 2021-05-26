using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Single
{
    public class GeneradorCodigo
    {
        Random num = new Random();

        public string generarCodigo(string dep)
        {
            return dep.Substring(0, 3).ToString().ToUpper()+ "-" + Convert.ToString(num.Next(1000, 9999));
        }
    }
}
