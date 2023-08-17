using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Persona
    {
        //4) Crea una clase llamada Persona, en el fichero "persona.cs". Esta clase deberá tener un atributo "nombre", de tipo string.
        //También deberá tener un método "SetNombre", de tipo void y con un parámetro string, que permita cambiar el valor del nombre. Finalmente, también tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido de su nombre.
        

        private string nombre;
        public Persona() { }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}");
        }
    }

    //Crea también una clase llamada PruebaPersona. Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Persona, les asignará un nombre a cada uno y les pedirá que saluden.
    class PruebaPersona
    {
        public static void Main()
        {
            Persona persona1 = new Persona();
            persona1.SetNombre("Laura");
            persona1.Saludar();

            Persona persona2 = new Persona();
            persona2.SetNombre("Roberto");
            persona2.Saludar();
        }
    }
}
