using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class MainApp
    {
        public static void Main(string[] args)
        {

            //Ejercicio 1
            Console.WriteLine("EJERCICIO 1");
            Alumno alumno1 = new Alumno("Santi", 15);
            alumno1.ImprimirDatos();
            alumno1.EsMayorDeEdad();


            //Ejercicio 2
            Console.WriteLine("\nEJERCICIO 2");
            Empleado empleado1 = new Empleado("Paco", 3948);
            empleado1.MostrarDatos();
            empleado1.DebePagarImpuestos();

            //Ejercicio 3
            Console.WriteLine("\nEJERCICIO 3");
            Operaciones operaciones = new Operaciones(20, 66);
            operaciones.Suma();
            operaciones.Resta();
            operaciones.Multiplicacion();
            operaciones.Division();

            //Ejercicio 4
            Console.WriteLine("\nEJERCICIO 4");
            PruebaPersona.Main();

            //Ejercicio 5
            Console.WriteLine("\nEJERCICIO 5");
            Libro.Main();

            //Ejercicio 6
            Console.WriteLine("\nEJERCICIO 6");
            Coche.Main();

            //Ejercicio 7
            Console.WriteLine("\nEJERCICIO 7");
            Console.WriteLine("La clase se llama 'Persona2.cs'");

            //Ejercicio 8
            Console.WriteLine("\nEJERCICIO 8");
            Console.WriteLine("La clase se llama 'Password.cs'");

            //Ejercicio 9
            Console.WriteLine("\nEJERCICIO 9");
            Console.WriteLine("La clase se llama 'Electrodomestico.cs'");

            //Ejercicio 10
            Console.WriteLine("\nEJERCICIO 10");
            Console.WriteLine("La clase se llama 'Serie.cs'");
        }
    }
}
