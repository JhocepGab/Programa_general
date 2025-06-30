using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Imagenes
    {
        public void TodosLosPisos()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╔══════     SISTEMA DE MONITOREO DE EDIFICIO    ═════════╗");
            Console.WriteLine("║             ┌────────── PISO 4 ──────────┐             ║");
            Console.WriteLine("║   ▒▒▒▒▒▒    │ Monitoreo en Tiempo Real   │   ▒▒▒▒▒▒    ║");
            Console.WriteLine("║             └────────────────────────────┘             ║");
            Console.WriteLine("║             ┌────────── PISO 3 ──────────┐             ║");
            Console.WriteLine("║   ▒▒▒▒▒▒    │ Monitoreo en Tiempo Real   │   ▒▒▒▒▒▒    ║");
            Console.WriteLine("║             └────────────────────────────┘             ║");
            Console.WriteLine("║             ┌────────── PISO 2 ──────────┐             ║");
            Console.WriteLine("║   ▒▒▒▒▒▒    │ Monitoreo en Tiempo Real   │   ▒▒▒▒▒▒    ║");
            Console.WriteLine("║             └────────────────────────────┘             ║");
            Console.WriteLine("║             ┌────────── PISO 1 ──────────┐             ║");
            Console.WriteLine("║   ▒▒▒▒▒▒    │ Monitoreo en Tiempo Real   │   ▒▒▒▒▒▒    ║");
            Console.WriteLine("║             └────────────────────────────┘             ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ResetColor();
        }

        public void MostrarPiso(int piso, int temperatura, int humo, string estado)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n╔═════════════ Piso {piso} ═══════════════╗");
            Console.WriteLine($"  ║      Temperatura: {temperatura} °C      ║");
            Console.WriteLine($"  ║      Nivel de humo: {humo}%             ║");
            Console.WriteLine($"  ║      Estado: {estado}                   ║");
            Console.WriteLine("   ╚═════════════════════════════════════════╝");
            Console.ResetColor();
        }

        public void MostrarExtintores(bool activos)
        {
            Console.ForegroundColor = activos ? ConsoleColor.Red : ConsoleColor.Green;
            Console.WriteLine("┌────────────────────────────────────── Extintores ──────────────────────────────────────────┐");
            Console.WriteLine(activos ? "│ LIBERANDO EXTINTORES           │" : "│ Listos para activarse                                │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────┘");
            Console.ResetColor();
        }

        public void MostrarLuces(bool activas)
        {
            Console.ForegroundColor = activas ? ConsoleColor.Yellow : ConsoleColor.Gray;
            Console.WriteLine("┌───────────────────────────────────── Luces Estroboscópicas ────────────────────────────────┐");
            Console.WriteLine(activas ? "│ ACTIVADAS                      │" : "│ Inactivas                                          │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────┘");
            Console.ResetColor();
        }
    }
}
