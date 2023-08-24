using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Serie
    {
        //10) Crearemos una clase llamada Serie con las siguientes características:
        //  • Sus atributos son titulo, numero de temporadas, entregado, genero y creador.
        //  • Por defecto, el numero de temporadas es de 3 temporadas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.
        //  • Los constructores que se implementaran serán:
        //      o Un constructor por defecto.
        //      o Un constructor con el titulo y creador. El resto por defecto.
        //      o Un constructor con todos los atributos, excepto de entregado.

        protected string titulo;
        protected int numTemporadas;
        protected bool entregado;
        protected string genero;
        protected string creador;

        private const int DEF_NUM_TEMPORADAS = 3;
        private const bool DEF_ENTREGADO = false;

        public Serie()
        {
            titulo = "";
            numTemporadas = DEF_NUM_TEMPORADAS;
            entregado = DEF_ENTREGADO;
            genero = "";
            creador = "";
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            numTemporadas = DEF_NUM_TEMPORADAS;
            entregado = DEF_ENTREGADO;
            genero = "";
            this.creador = creador;
        }
        public Serie(string titulo, int numTemporadas, bool entregado, string genero, string creador)
        {
            this.titulo = titulo;
            this.numTemporadas = numTemporadas;
            this.entregado = entregado;
            this.genero = genero;
            this.creador = creador;
        }
    }
}
