using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Operaciones
    {
        //3) Implementar la clase operaciones. Se deben cargar dos valores enteros en el constructor, calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.

        private int valor1;
        private int valor2;

        public Operaciones(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public void Suma()
        {
            Console.WriteLine("- {0} + {1} = {2}", valor1, valor2, (valor1 + valor2));
        }

        public void Resta()
        {
            Console.WriteLine("- {0} - {1} = {2}", valor1, valor2, (valor1 - valor2));
        }

        public void Multiplicacion()
        {
            Console.WriteLine("- {0} x {1} = {2}", valor1, valor2, (valor1 * valor2));
        }

        public void Division()
        {
            Console.WriteLine("- {0} / {1} = {2}", valor1, valor2, ((float)valor1 / valor2));
        }

    }
}
