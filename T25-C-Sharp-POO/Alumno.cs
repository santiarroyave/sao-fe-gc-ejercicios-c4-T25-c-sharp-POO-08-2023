using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Alumno
    {
        //1) Plantear una clase llamada Alumno y definir como atributos su nombre y su edad. En el constructor realizar la carga de datos. Definir otros dos métodos para imprimir los datos ingresados y un mensaje si es mayor o no de edad (edad >= 18)

        //ATRIBUTOS
        private string nombre;
        private int edad;

        //CONSTRUCTORES
        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        //MÉTODOS
        public void ImprimirDatos()
        {
            Console.WriteLine($"Se llama {nombre} y tiene {edad} años.");
        }

        public void EsMayorDeEdad()
        {
            if (this.edad >= 18)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("No es mayor de edad.");
            }
        }

    }
}
