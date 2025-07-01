using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;
using Mensaje_de_alerta;

namespace ClassLibrary2
{
    public class Paneldecontrol
    {
        private string historial = "";
        private Imagenes imagenes = new Imagenes();
        private MensajesDeAlerta alertas = new MensajesDeAlerta();

        public void MenuPrincipal()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║        PANEL DE CONTROL DE PISOS         ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.ResetColor();
                Console.WriteLine("╔═══════════════════════════════════════════╗");
                Console.WriteLine("║    ║    1. Monitorear Piso           ║    ║");
                Console.WriteLine("║    ║    2. Ver historial de datos    ║    ║");
                Console.WriteLine("║    ║    3. Simulacro de emergencia   ║    ║");
                Console.WriteLine("║    ║    0. Salir                     ║    ║");
                Console.WriteLine("╚═══════════════════════════════════════════╝");
                Console.Write("\nElige una opción: ");

                string entrada = Console.ReadLine();
                bool valido = int.TryParse(entrada, out opcion);

                if (!valido) opcion = -1;

                switch (opcion)
                {
                    case 1: SeleccionarPiso(); break;
                    case 2: VerHistorial(); break;
                    case 3: Simulacro(); break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Thread.Sleep(1000);
                        break;
                }
            } while (opcion != 0);
        }

        private void SeleccionarPiso()
        {
            Console.Clear();
            Console.Write("Ingresa el número de piso (1-4): ");
            string entrada = Console.ReadLine();
            bool valido = int.TryParse(entrada, out int piso);

            if (valido && piso >= 1 && piso <= 4)
                MonitorearPiso(piso);
            else
            {
                Console.WriteLine("Piso inválido.");
                Thread.Sleep(1000);
            }
        }

        private void MonitorearPiso(int piso)
        {
            Random rnd = new Random();

            Console.Clear();
            Console.WriteLine($"Monitoreando Piso {piso}... Presiona '0' para detener.");

            while (true)
            {
                int temp = rnd.Next(50, 251);
                int humo = rnd.Next(0, 101);
                string estado;

                if (temp < 100)
                    estado = "Normal";
                else if (temp < 170)
                    estado = "Emergencia";
                else
                    estado = "Crítico";

                Console.Clear();

                // Color según estado
                switch (estado)
                {
                    case "Normal": Console.ForegroundColor = ConsoleColor.Green; break;
                    case "Emergencia": Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case "Crítico": Console.ForegroundColor = ConsoleColor.Red; break;
                }

                // Mostrar piso con datos
                imagenes.MostrarPiso(piso, temp, humo, estado);
                Console.ResetColor();

                // Mensaje de alerta
                if (estado == "Crítico") alertas.Mensaje_Alerta2();
                else if (estado == "Emergencia") alertas.Mensaje_Alerta1();
                else alertas.Mensaje_Alerta0();

                // Mostrar extintores y luces
                imagenes.MostrarExtintores(estado != "Normal");
                imagenes.MostrarLuces(estado != "Normal");

                // Guardar historial
                historial += $"{DateTime.Now} - Piso {piso}: Temp={temp}°C Humo={humo}% Estado={estado}\n";

                Console.WriteLine("\nPresiona '0' para detener o espera para continuar...");
                Thread.Sleep(1500);

                if (Console.KeyAvailable && Console.ReadKey(true).KeyChar == '0')
                {
                    Console.WriteLine("\nMonitoreo detenido.");
                    Thread.Sleep(1000);
                    break;
                }
            }
        }

        private void VerHistorial()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║     *****       HISTORIAL    *****       ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine(string.IsNullOrEmpty(historial) ? "No hay datos aún." : historial);
            Console.WriteLine("\nPresiona una tecla para volver...");
            Console.ReadKey();
        }

        private void Simulacro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("  Iniciando simulacro de emergencia...");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Thread.Sleep(1000);

            Console.ResetColor();
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("  Activando rociadores automáticos...");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.Beep(1200, 400);
            Thread.Sleep(1000);

            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("  Liberando extintores de emergencia...");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.Beep(1000, 400);
            Thread.Sleep(1000);

            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("  Encendiendo luces y alarmas...");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.Beep(1500, 500);
            Thread.Sleep(1000);

            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("  Simulacro finalizado.");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Thread.Sleep(1500);
        }
    }
}