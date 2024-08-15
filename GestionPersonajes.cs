using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Personajes
{
    class Personaje
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Acciones { get; set; }

        private static List<Personaje> personajes = new List<Personaje>();

        public Personaje(string nombre, string descripcion, string tipo, string acciones)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Tipo = tipo;
            this.Acciones = acciones;
        }

        public static void CrearPersonaje(string nombre, string descripcion, string tipo, string acciones)
        {
            personajes.Add(new Personaje(nombre, descripcion, tipo, acciones));
            Console.WriteLine("Creado");
        }

        public static void ListarPersonajes()
        {
            if (personajes.Count == 0)
            {
                Console.WriteLine("No hay personajes");
                return;
            }

            Console.WriteLine("\nLista de personajes:");
            for (int i = 0; i < personajes.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {personajes[i].Nombre}");
            }
        }

        public static void ActualizarPersonaje(int indice, string nuevoNombre, string nuevaDescripcion, string nuevoTipo, string nuevasAcciones)
        {
            if (indice >= 0 && indice < personajes.Count)
            {
                var personaje = personajes[indice];
                personaje.Nombre = nuevoNombre;
                personaje.Descripcion = nuevaDescripcion;
                personaje.Tipo = nuevoTipo;
                personaje.Acciones = nuevasAcciones;
                Console.WriteLine("Actualizado.");
            }
            else
            {
                Console.WriteLine("No válido");
            }
        }

        public static void EliminarPersonaje(int indice)
        {
            if (indice >= 0 && indice < personajes.Count)
            {
                Console.WriteLine("Eliminado");
                personajes.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("No válido");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool uwu = true;

            while (uwu)
            {
                Console.Clear();
                Console.WriteLine("1. Crear Personaje");
                Console.WriteLine("2. Listar Personajes");
                Console.WriteLine("3. Actualizar Personaje");
                Console.WriteLine("4. Eliminar Personaje");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                var opcion = Console.ReadLine();

                int indice;
                string nombre, descripcion, tipo, acciones;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del personaje: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese la descripción del personaje: ");
                        descripcion = Console.ReadLine();
                        Console.Write("Ingrese el tipo del personaje: ");
                        tipo = Console.ReadLine();
                        Console.Write("Ingrese las acciones del personaje: ");
                        acciones = Console.ReadLine();
                        Personaje.CrearPersonaje(nombre, descripcion, tipo, acciones);
                        break;

                    case "2":
                        Personaje.ListarPersonajes();
                        break;

                    case "3":
                        Console.Write("Ingrese el índice del personaje a actualizar: ");
                        try
                        {
                            indice = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el nuevo nombre: ");
                            nombre = Console.ReadLine();
                            Console.Write("Ingrese la nueva descripción: ");
                            descripcion = Console.ReadLine();
                            Console.Write("Ingrese el nuevo tipo: ");
                            tipo = Console.ReadLine();
                            Console.Write("Ingrese las nuevas acciones: ");
                            acciones = Console.ReadLine();
                            Personaje.ActualizarPersonaje(indice, nombre, descripcion, tipo, acciones);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("No válido");
                        }
                        break;

                    case "4":
                        Console.Write("Ingrese el índice a eliminar: ");
                        try
                        {
                            int indiceEliminar = int.Parse(Console.ReadLine());
                            Personaje.EliminarPersonaje(indiceEliminar);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("No válido");
                        }
                        break;

                    case "5":
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
