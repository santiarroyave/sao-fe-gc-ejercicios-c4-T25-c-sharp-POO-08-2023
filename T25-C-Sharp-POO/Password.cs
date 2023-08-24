using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T25_C_Sharp_POO
{
    internal class Password
    {
        //8) Haz una clase llamada Password que siga las siguientes condiciones:
        //  • Que tenga los atributos longitud y contraseña.Por defecto, la longitud sera de 8.
        private int longitud;
        private string password;

        private int defLongitud = 8;

        //  • Los constructores serán los siguiente:
        //      o Un constructor por defecto.
        //      o Un constructor con la longitud que nosotros le pasemos. Generara una contraseña aleatoria con esa longitud.
        public Password()
        {
            longitud = defLongitud;
            password = GenerarPassword(longitud);
        }

        public Password(int longitud)
        {
            password = GenerarPassword(longitud);
        }

        // • generarPassword(): genera la contraseña del objeto con la longitud que tenga.
        public string GenerarPassword(int longitud)
        {
            string password = "";

            Random random = new Random();
            for (int i = 0; i < longitud; i++)
            {
                // Numero random para elegir que tipo de caracter incluir a la contraseña
                int randomTemp = random.Next(0, 3);

                if (randomTemp == 2)
                {
                    // Mayusculas
                    password += (char)random.Next(65, 91);
                }
                else if (randomTemp == 1)
                {
                    // Minusculas
                    password += (char)random.Next(97, 123);
                }
                else
                {
                    // Números
                    password += random.Next(0, 9);
                }
            }

            return password;
        }
    }
}
