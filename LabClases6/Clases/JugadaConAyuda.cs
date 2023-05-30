using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases6.Clases
{
    internal class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {

        }
        public override void Comparar(int num)
        {
            if (this.Numero == num)
            {
                Console.WriteLine("¡Adivinaste!");
                base.Adivino = "Adivinado";
            }
            else
            {
                Console.WriteLine($"No es ese número, ya hiciste {base.Intento} intento/s");
                base.Intento++;
                if ((base.Numero - num) >= 100)
                {
                    Console.WriteLine("El numero dista de más de 100 o más números del número a adivinar");
                }
                else
                {
                    if ((base.Numero - num) <= 5)
                    {
                        Console.WriteLine("El número dista de 5 o menos números");
                    }
                }




            }

        }
    }
}
