using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Coche
    {
        //6) Crea una clase "Coche", con atributos "marca" (texto), "modelo" (texto), "cilindrada" (número entero), potencia (número real). No hace falta que crees un Main de prueba.
        //Prepara también un Main (en la misma clase), que cree un objeto de la clase coche, dé valores a sus tres atributos y luego los muestre.

        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        public static void Main()
        {
            Coche coche = new Coche();
            coche.SetMarca("BMW");
            coche.SetModelo("M4");
            coche.SetPotencia(510);
            coche.SetCilindrada(6);
            coche.ToString();
        }

        //Setters
        private void SetMarca(string marca)
        {
            this.marca = marca;
        }

        private void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        private void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }

        private void SetPotencia(double potencia)
        {
            this.potencia = potencia;
        }

        private void ToString()
        {
            Console.WriteLine("Marca: {0}, modelo: {1}, potencia: {2} cv, {3} cilindros", marca, modelo, potencia, cilindrada);
        }
    }
}
