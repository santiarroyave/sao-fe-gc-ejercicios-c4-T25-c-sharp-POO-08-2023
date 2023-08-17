using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Libro
    {
        //5) Para guardar información sobre libros, vamos a comenzar por crear una clase "Libro", que contendrá atributos "autor", "titulo", "ubicacion" (todos ellos strings) y métodos Get y Set adecuados para leer su valor y cambiarlo.
        //Prepara también un Main (en la misma clase), que cree un objeto de la clase Libro, dé valores a sus tres atributos y luego los muestre.

        //ATRIBUTOS
        private string autor;
        private string titulo;
        private string ubicacion;

        //MAIN
        public static void Main()
        {
            Libro libro1 = new Libro();
            libro1.SetTitulo("Steve Jobs");
            libro1.SetAutor("Walter Isaacson");
            libro1.SetUbicacion("Estados Unidos");

            Libro libro2 = new Libro();
            libro2.SetTitulo("Metas");
            libro2.SetAutor("Brian Tracy");
            libro2.SetUbicacion("Estados Unidos");

            Libro libro3 = new Libro();
            libro3.SetTitulo("Amplitud (Range)");
            libro3.SetAutor("David Epstein");
            libro3.SetUbicacion("Estados Unidos");

            libro1.GetInfo();
            libro2.GetInfo();
            libro3.GetInfo();
        }

        //MÉTODOS
        // Getters
        public void GetAutor()
        {
            Console.WriteLine($"- El autor es {autor}");
        }

        public void GetTitulo()
        {
            Console.WriteLine($"- El título es {titulo}");
        }

        public void GetUbicacion()
        {
            Console.WriteLine($"- La ubicación es {ubicacion}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"- El libro {titulo} fue escrito por {autor} y publicado en {ubicacion}.");
        }

        // Setters
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
    }
}
