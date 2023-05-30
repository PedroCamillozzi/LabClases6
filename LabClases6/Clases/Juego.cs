using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases6.Clases
{
    internal class Juego
    {
        private int _record;
        private JugadaConAyuda _jugadaConAyuda;

        public void ComenzarJuego()
        {
            while (this.Continuar())
            {
                _jugadaConAyuda = new JugadaConAyuda(this.PreguntarMaximo());
                Console.WriteLine("Iniciaste un nuevo juego");
                do
                {
                    _jugadaConAyuda.Comparar(this.PreguntarNumero());

                } while (this.Continuar());
                this.CompararRecord();
            }
            Console.WriteLine("Adios");
            Console.ReadKey();
        }

        public int PreguntarNumero()
        {
            Console.WriteLine("Elija un número");
            int i = Int32.Parse(Console.ReadLine());

            return i;
        }

        public void CompararRecord()
        {
            if (_jugadaConAyuda.Intento == _record)
            {
                Console.WriteLine("Igualaste el record");
            }
            if (_jugadaConAyuda.Intento < _record)
            {
                Console.WriteLine("Nuevo record de Intentos");
                _jugadaConAyuda.Intento = _record;
            }
            else
            {
                Console.WriteLine("No superaste el record de intentos");
            }
        }

        public int PreguntarMaximo()
        {
            Console.WriteLine("Ingrese un numero Máximo");
            int max = Int32.Parse(Console.ReadLine());
            return max;
        }

        public bool Continuar()
        {
            Console.WriteLine("¿Desea continuar jugando? Ingrese S o N");
            string rta = (Console.ReadLine().ToUpper());
            if (rta == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
