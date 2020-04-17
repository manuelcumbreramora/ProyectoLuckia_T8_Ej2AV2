
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Repo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitLoop = false;
            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("1. Mostrar opciones de juego.");
                Console.WriteLine("2. Activar / Desactivar opciones de juego.");
                Console.WriteLine("");
                Console.WriteLine("x. Salir");

                string s = Console.ReadLine().Trim().ToLower();
                char c = s[0];
                switch (c)
                {
                    case '1':
                        MostrarOpciones();
                        break;
                    case '2':
                        ActivarDesactivarOpciones();
                        break;
                    case 'x':
                        exitLoop = true;
                        break;
                    default:
                        Console.WriteLine("Error, opción no válida ('" + s + "').");
                        break;
                }
            } while (!exitLoop);
        }

        static void MostrarOpciones()
        {
            IFachadaNegocio fachada = new FachadaNegocio();
            
            Console.WriteLine("Opciones de juego:\n");

            List<OpcionJuego> opciones = fachada.ListarOpcionesJuego();

            if (opciones.Count == 0)
            {
                Console.WriteLine("No se han encontrado opciones de juego.");
            }
            else
            {
                Console.WriteLine("activado ;; juego ;; opción 1 ;; opción 2");
                foreach (OpcionJuego item in opciones)
                {
                    bool _enabled = item.enabled.HasValue ? item.enabled.Value : false;
                    Console.WriteLine((_enabled ? "si" : "no") + " ;; " + item.Juego.ToString() + " ;; " + item.nombreOpcion1 + " ;; " + item.nombreOpcion1);
                }
            }
        }


        static void ActivarDesactivarOpciones()
        {
            // TO DO ...
        }
    }
}