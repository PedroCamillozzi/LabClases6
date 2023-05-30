namespace ClasesLab6
{
    public class Jugada
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

    public class Juego
    {
        private int _record;
        private Jugada _jugada;

        public void ComenzarJuego()
        {
            while (this.Continuar())
            {
                _jugada = new Jugada(this.PreguntarMaximo());
                Console.WriteLine("Iniciaste un nuevo juego");
                do
                {
                    _jugada.Comparar(this.PreguntarNumero());

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
            if (_jugada.Intento == _record)
            {
                Console.WriteLine("Igualaste el record");
            }
            if (_jugada.Intento < _record)
            {
                Console.WriteLine("Nuevo record de Intentos");
                _jugada.Intento = _record;
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
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNum) : base(int maxNumero);
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
                if ((base.Numero - num) > 100)
                {
                    Console.WriteLine("El numero dista de más de 100 o más números del número a adivinar");
                }
                else
                {
                    if ((base.Numero - num) < 5)
                    {
                        Console.WriteLine("El número dista de 5 o menos números");
                    }
                }
                
               


            }

        }
    }
}