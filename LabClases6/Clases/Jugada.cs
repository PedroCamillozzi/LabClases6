using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases6.Clases
{
    internal class Jugada
    {
            private int _numero;
            private int _intento = 0;
            private string _adivino = "No Adivinado";
            public Jugada(int maxNumero)
            {
                Random rnd = new Random();
                this.Numero = rnd.Next(maxNumero);

            }

            public int Numero { get; set; }

            public int Intento { get; set; }

            public string Adivino { get; set; }

            public virtual void Comparar(int num)
            {
                if (this.Numero == num)
                {
                    Console.WriteLine("¡Adivinaste!");
                    this.Adivino = "Adivinado";
                }
                else
                {
                    this.Intento++;
                    Console.WriteLine($"No es ese número, ya hiciste {this.Intento} intento/s");


                }
            }

    }
}
