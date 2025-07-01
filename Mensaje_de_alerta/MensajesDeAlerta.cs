using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mensaje_de_alerta
{
    public class MensajesDeAlerta
    {
        public void Mensaje_Alerta0()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n ╔═══════════════ ALERTA PREVENTIVA ═══════════════╗");
            Console.WriteLine("   ║  Sistema normal - ventilación funcionando       ║");
            Console.WriteLine("   ╚═════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.Beep(600, 200);
            Thread.Sleep(500);
        }

        public void Mensaje_Alerta1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ╔══════════════ ALERTA DE EMERGENCIA ═════════════╗");
            Console.WriteLine("   ║    Temperatura elevada, activando sistemas      ║");
            Console.WriteLine("   ║    - Activando extintores de emergencia         ║");
            Console.WriteLine("   ║    - Activando sistema de enfriamiento          ║");
            Console.WriteLine("   ╚═════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.Beep(1000, 300);
            Thread.Sleep(500);
        }

        public void Mensaje_Alerta2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ╔═════════════════ ¡¡ALERTA CRÍTICA!! ═══════════════╗");
            Console.WriteLine("   ║              ¡Incendio detectado!                  ║");
            Console.WriteLine("   ║         - Activando TODOS los extintores           ║");
            Console.WriteLine("   ║         - Contactando bomberos                     ║");
            Console.WriteLine("   ║         - Encendiendo luces de emergencia          ║");
            Console.WriteLine("   ╚════════════════════════════════════════════════════╝");
            Console.ResetColor();
            EfectoParpadeo();
            Thread.Sleep(500);
        }

        private void EfectoParpadeo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep(1500, 400);
                Thread.Sleep(200);
                Console.ResetColor();
                Thread.Sleep(200);
            }
        }
    }
}
