using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Empleado
    {
        //2) Confeccionar una clase que represente un empleado.
        //- Definir como atributos su nombre y su sueldo.
        //- En el constructor cargar los atributos.
        //- En otro método imprimir sus datos.
        //- Otro método que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000).
        private string nombre;
        private int sueldo;

        public Empleado(string nombre, int sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Se llama {nombre} y cobra {sueldo} euros.");
        }

        public void DebePagarImpuestos()
        {
            sueldo = 200;

            if ( sueldo >= 3000 )
            {
                Console.WriteLine("Debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("Debe pagar impuestos.");
            }
        }
    }
}
