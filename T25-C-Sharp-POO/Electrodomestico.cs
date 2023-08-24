using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    enum color
    {

    }
    internal class Electrodomestico
    {
        //9) Crearemos una clase llamada Electrodomestico con las siguientes características:
        //  • Sus atributos son precio base, color, consumo energético (letras entre A y F) y peso. Indica que se podrán heredar.
        //  • Por defecto, el color sera blanco, el consumo energético sera F, el precioBase es de 100 € y el peso de 5 kg. Usa constantes para ello.
        //  • Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre esta en mayúsculas o en minúsculas.
        //  • Los constructores que se implementaran serán
        //      o Un constructor por defecto.
        //      o Un constructor con el precio y peso. El resto por defecto.
        //      o Un constructor con todos los atributos.
        protected int precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected int peso;

        private const int DEF_PRECIO_BASE = 100;
        private const string DEF_COLOR = "blanco";
        private const char DEF_CONSUMO_ENERGETICO = 'F';
        private const int DEF_PESO = 5;

        protected char[] consumosDisponibles = { 'A', 'B', 'C', 'D', 'E', 'F' };
        protected string[] coloresDisponibles = { "blanco", "negro", "rojo", "azul", "gris" };

        public Electrodomestico()
        {
            precioBase = DEF_PRECIO_BASE;
            color = DEF_COLOR;
            consumoEnergetico = DEF_CONSUMO_ENERGETICO;
            peso = DEF_PESO;
        }
        public Electrodomestico(int precioBase, int peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            color = DEF_COLOR;
            consumoEnergetico = DEF_CONSUMO_ENERGETICO;
        }

        public Electrodomestico(int precioBase, string color, char consumoEnergetico, int peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }
    }
}
