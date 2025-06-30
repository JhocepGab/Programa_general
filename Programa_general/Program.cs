using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary2;
using Mensaje_de_alerta;

namespace Programa_general
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MostrarEncabezado();
            // Creación de Imagenes necesarias y llamamos a nuestra clase
            Imagenes imagenes = new Imagenes();
            imagenes.TodosLosPisos();
            Thread.Sleep(2500); // Pausa para mejor visualización
            Random r = new Random();
            int piso = r.Next(1, 5);
            int temperatura = r.Next(50, 350);
            MostrarInformacionDeteccion(piso, temperatura);
            ProcesarAlerta(piso, temperatura);
            Console.WriteLine("\nPresione cualquier tecla para acceder al panel de control...");

            Console.ReadKey(true);
            Paneldecontrol panel = new Paneldecontrol();
            panel.Panel();
            Console.ReadKey();
        }
        private static void MostrarEncabezado()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║ SISTEMA DE ALARMA CONTRA INCENDIOS ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");
            Console.ResetColor();
            Thread.Sleep(2000);
        }
        private static void MostrarInformacionDeteccion(int piso, int temperatura)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("DETECCIÓN DE INCIDENTE ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine(" Piso detectado: " + piso + " ");
            Console.WriteLine(" Temperatura actual: " + temperatura + "°C ");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.ResetColor();
            Thread.Sleep(2500);
        }
        private static void ProcesarAlerta(int piso, int temperatura)
        {
            // Objetos necesarios
            Imagenes imagenes = new Imagenes();
            Mensajes_de_Alerta alertas = new Mensajes_de_Alerta();
            switch (piso)
            {
                case 1:
                    imagenes.ImagenPiso1();
                    ProcesarPiso(temperatura, alertas, "PISO 1"); break;
                case 2:
                    imagenes.ImagenPiso2();
                    ProcesarPiso(temperatura, alertas, "PISO 2"); break;
                case 3:
                    imagenes.ImagenPiso3();
                    ProcesarPiso(temperatura, alertas, "PISO 3"); break;
                case 4:
                    imagenes.ImagenPiso4();
                    ProcesarPiso(temperatura, alertas, "PISO 4"); break;
            }
        }
        private static void ProcesarPiso(int temperatura, Mensajes_de_Alerta alertas,
       string numeroPiso)
        {
            Console.Clear();
            if (temperatura >= 500 && temperatura <= 550)
            {
                MostrarEstadoAlerta("MÍNIMA", temperatura, ConsoleColor.Green);
                Console.WriteLine($" Registrando {numeroPiso}");
                Mensajes_de_Alerta alerta0 = new Mensajes_de_Alerta();
                alerta0.Mensaje_Alerta0();
            }
            else if (temperatura >= 551 && temperatura <= 575)
            {
                MostrarEstadoAlerta("MODERADA", temperatura, ConsoleColor.Yellow);
                Console.WriteLine($" Estado: Temperatura elevada en {numeroPiso}");
                Mensajes_de_Alerta alerta1 = new Mensajes_de_Alerta();
                alerta1.Mensaje_Alerta1();
            }
            else
            {
                MostrarEstadoAlerta("MÁXIMA", temperatura, ConsoleColor.Red);
                Console.WriteLine($" Estado: Temperatura crítica en {numeroPiso}");
                Mensajes_de_Alerta alerta2 = new Mensajes_de_Alerta();
                alerta2.Mensaje_Alerta2();
            }
            Imagenes A = new Imagenes();
            A.AparatosQueCombateFuego();
            Console.ReadKey();
        }
        private static void MostrarEstadoAlerta(string nivelAlerta, int temperatura,
       ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("╔════════════ ALERTA " + nivelAlerta + " ════════╗");
            Console.WriteLine(" Temperatura detectada:" + temperatura + "°C ");

            Console.WriteLine("╚════════════════════════════════════════════════╝\n");
            Console.ResetColor();
            Thread.Sleep(2500);
        }
    }
}
