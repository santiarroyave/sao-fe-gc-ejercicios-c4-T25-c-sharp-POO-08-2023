using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Persona2
    {
        //7) Haz una clase llamada Persona que siga las siguientes condiciones:
        //  • Sus atributos son: nombre, edad, DNI, sexo(H hombre, M mujer), peso y altura. No queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el más adecuado, también su tipo. Si quieres añadir algún atributo puedes hacerlo.
        //  • Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una constante para ello.

        private string nombre;
        private int edad;
        private string dni;
        private char sexo; // H hombre, M mujer
        private double peso;
        private double altura;

        private string defNombre = "";
        private int defEdad = 0;
        private const char DEF_SEXO = 'H';
        private double defPeso = 0;
        private double defAltura = 0;


        //Se implantaran varios constructores:
        //• Un constructor por defecto.
        //• Un constructor con el nombre, edad y sexo, el resto por defecto.
        //• Un constructor con todos los atributos como parámetro.
        public Persona2()
        {
            nombre = defNombre;
            edad = defEdad;
            sexo = DEF_SEXO;
            peso = defPeso;
            altura = defAltura;
        }

        public Persona2(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = Char.ToUpper(sexo);
            peso = defPeso;
            altura = defAltura;
        }

        public Persona2(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = Char.ToUpper(sexo);
            this.peso = peso;
            this.altura = altura;
        }
    }
}
