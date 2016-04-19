using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeUnidade
{
    public class Calculadora
    {
        public static decimal Somar(decimal n1, decimal n2)
        { return n1 + n2; }
        public static decimal Subtrair(decimal n1, decimal n2) 
        { return n1 - n2; }
        public static decimal Multiplicar(decimal n1, decimal n2) 
        {  return n1 * n2; }
        public static decimal Dividir (decimal n1 , decimal n2)
        {
            if (n2 == 0)
                throw new ArgumentException(Exceptions.DIVISAO_POR_ZERO);

            return n1/ n2;
        }
    }
}
