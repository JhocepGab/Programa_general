using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mensaje_de_alerta
{
    public class Mensajes_de_Alerta
    {
    private void MostrarMarcoAlerta(string tipoAlerta, ConsoleColor color)
        {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine(" ╔═══════════════════════════╗");
            Console.WriteLine("     SISTEMA DE ALERTA ");
            Console.WriteLine(" " + tipoAlerta + " ");
            Console.WriteLine(" ╚═══════════════════════════╝");
            Console.WriteLine("");
        }
    public void Mensaje_Alerta1()
    {
        MostrarMarcoAlerta("¡ALERTA DE EMERGENCIA!", ConsoleColor.Yellow);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" ┌────────────────────────────────────────┐");
        Console.WriteLine(" │ ¡EVACUACIÓN REQUERIDA!                 │");
        Console.WriteLine(" │ º Liberando extintores de emergencia   │");
        Console.WriteLine(" │ º Activando sistema de enfriamiento    │");
        Console.WriteLine(" │ º Encendiendo luces de emergencia      │");
        Console.WriteLine(" └────────────────────────────────────────┘");
        Console.Beep(1000, 2000);
    }
    public void Mensaje_Alerta2()
    {
        MostrarMarcoAlerta("¡¡ALERTA CRÍTICA!!", ConsoleColor.Red);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" ┌────────────────────────────────────────┐");
        Console.WriteLine(" │ ¡EVACUACIÓN INMEDIATA!                 │");
        Console.WriteLine(" │ º Liberando TODOS los extintores       │");
        Console.WriteLine(" │ º Activando sistemas de emergencia     │");
        Console.WriteLine(" │ º Contactando bomberos                 │");
        Console.WriteLine(" │ º Desactivando sistemas eléctricos     │");
        Console.WriteLine(" └────────────────────────────────────────┘");
        EfectoParpadeo();
    }
    private void EfectoParpadeo()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep(1500, 500);
            Thread.Sleep(5);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(8);
        }
    }
    public void Mensaje_Alerta0()
    {
        MostrarMarcoAlerta("ALERTA PREVENTIVA", ConsoleColor.Green);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" ┌────────────────────────────────────────┐");
        Console.WriteLine(" │ DETECCIÓN DE TEMPERATURA ELEVADA       │");
        Console.WriteLine(" │ º Activando sistemas de ventilación    │");
        Console.WriteLine(" │ º Iniciando aire acondicionado         │");
        Console.WriteLine(" │ º Monitoreando variación térmica       │");
        Console.WriteLine(" └────────────────────────────────────────┘");
        Console.Beep(1000, 1500);
    }
}
}