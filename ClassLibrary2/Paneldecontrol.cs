using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class Paneldecontrol
    {
        public void Panel()
        {
            int opción;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║ PANEL DE CONTROL DE PISOS                ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el piso a analizar o 0 para salir:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string entrada = Console.ReadLine();
                bool esNumero = int.TryParse(entrada, out opción);
                if (!esNumero)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Opción inválida. Ingrese un número válido.");
                    Console.ResetColor(); Thread.Sleep(1000);
                    continue;
                }
                Console.ResetColor();
                Menu(opción);
            } while (opción != 0);
        }
        static void Menu(int opción)
        {
            switch (opción)
            {
                case 1: MenuPiso(1, new Imagenes().ImagenPiso1); break;
                case 2: MenuPiso(2, new Imagenes().ImagenPiso2); break;
                case 3: MenuPiso(3, new Imagenes().ImagenPiso3); break;
                case 4: MenuPiso(4, new Imagenes().ImagenPiso4); break;
                case 0:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║ Saliendo del sistema...                  ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("╔═════════════════════════════════════════╗");
                    Console.WriteLine("║ Opción no válida...                     ║");
                    Console.WriteLine("╚═════════════════════════════════════════╝");
                    Console.ResetColor();
                    break;
            }
        }
        static void AnalizarTemperatura(int piso)
        {
            Console.Clear();
            Imagenes img = new Imagenes();
            switch (piso)
            {
                case 1: img.ImagenPiso1(); break;
                case 2: img.ImagenPiso2(); break;
                case 3: img.ImagenPiso3(); break;
                case 4: img.ImagenPiso4(); break;
            }
            Console.WriteLine("Analizando Temperatura...");
            Console.WriteLine("Presiona '0' para detener y regresar al menú.");
            int temperatura = 550;
            while (true)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Piso {piso} - Temperatura actual: {temperatura} °C ");

                temperatura++;
                if (Console.KeyAvailable && Console.ReadKey(true).KeyChar == '0')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nDetenido. Regresando al menú...");
                    Console.ResetColor();
                    break;
                }
                Thread.Sleep(300);
            }
        }
        static void VerificarNivelHumo(int piso)
        {
            Console.Clear();
            Imagenes img = new Imagenes();
            switch (piso)
            {
                case 1: img.ImagenPiso1(); break;
                case 2: img.ImagenPiso2(); break;
                case 3: img.ImagenPiso3(); break;
                case 4: img.ImagenPiso4(); break;
            }
            Console.WriteLine("Verificando Nivel de Humo...");
            Console.WriteLine("Presiona '0' para detener y regresar al menú.");
            int humo = 60;
            while (true)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"Piso {piso} - Nivel de humo actual: {humo}% ");
                humo += 2;
                if (Console.KeyAvailable && Console.ReadKey(true).KeyChar == '0')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nDetenido. Regresando al menú...");
                    Console.ResetColor();
                    break;
                }
                Thread.Sleep(300);
            }
        }
        static void MenuPiso(int piso, Action mostrarImagen)
        {
            Console.Clear();
            mostrarImagen();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║ SELECCIONE UNA OPCIÓN:                   ║");
            Console.WriteLine("║ 1. Analizar Temperatura                  ║");
            Console.WriteLine("║ 2. Verificar Nivel de Humo               ║");
            Console.WriteLine("║ 3. Estado Rociadores Automáticos         ║");
            Console.WriteLine("║ 0. Volver al menú principal              ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.Write("\nIngrese su opción: ");
            Console.ResetColor();
            string entrada = Console.ReadLine();
            bool esNumero = int.TryParse(entrada, out int opcion);
            if (!esNumero)
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }
            switch (opcion)
            {
                case 1: AnalizarTemperatura(piso); break;
                case 2: VerificarNivelHumo(piso); break;
                case 3:
                    Console.WriteLine("Todos los rociadores automáticos funcionan correctamente"); break;
                case 0: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción no válida"); break;
            }
            Console.ReadLine();
            Imagenes A = new Imagenes();
            A.AparatosQueCombateFuego();
        }
    }
}
