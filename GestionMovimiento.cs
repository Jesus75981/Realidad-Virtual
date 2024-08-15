using System;

namespace Gestion_Movimientos_Juego
{
    class Personaje
    {
        public string Nombre { get; set; }

        public Personaje(string nombre)
        {
            this.Nombre = nombre;
        }

        public void Moverse()
        {
            Console.WriteLine($"{Nombre} se ha movido.");
        }

        public void Disparar()
        {
            Console.WriteLine($"{Nombre} ha disparado.");
        }

        public void Saltar()
        {
            Console.WriteLine($"{Nombre} ha saltado.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje = new Personaje("Yo");

            bool uwu = true;
            while (uwu)
            {
                Console.Clear();
                Console.WriteLine("1. Mover Personaje");
                Console.WriteLine("2. Disparar");
                Console.WriteLine("3. Saltar");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        personaje.Moverse();
                        break;

                    case "2":
                        personaje.Disparar();
                        break;

                    case "3":
                        personaje.Saltar();
                        break;

                    case "4":
                        uwu = false;
                        break;

                    default:
                        Console.WriteLine("No válido");
                        break;
                }

                if (uwu)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
