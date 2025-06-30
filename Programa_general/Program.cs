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

            Imagenes imagenes = new Imagenes();
            imagenes.TodosLosPisos();

            Thread.Sleep(2000);
            Paneldecontrol panel = new Paneldecontrol();
            panel.MenuPrincipal();

            Console.WriteLine("\nGracias por usar el sistema.");
            Console.ReadKey();
        }

        static void MostrarEncabezado()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  ╔═════════════════════════════════════════════════════╗  ║");
            Console.WriteLine("║   -----------------------------------------------         ║");
            Console.WriteLine("║           SISTEMA DE MONITOREO CONTRA INCENDIOS           ║");
            Console.WriteLine("║   -----------------------------------------------         ║");
            Console.WriteLine("║  ╚═════════════════════════════════════════════════════╝  ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Thread.Sleep(1500);
        }
    }
}