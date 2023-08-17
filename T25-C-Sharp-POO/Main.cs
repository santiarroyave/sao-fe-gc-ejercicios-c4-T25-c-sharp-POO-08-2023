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
            Alumno alumno1 = new Alumno("Santi", 15);
            alumno1.ImprimirDatos();
            alumno1.EsMayorDeEdad();
            
        }
    }
}
