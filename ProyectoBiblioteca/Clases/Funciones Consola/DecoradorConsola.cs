﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases.Funciones_Consola
{
    public class DecoradorConsola
    {
        public static void RecuadroTituloBiblioteca()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t\t" + "+----------------------------+");
            //Console.WriteLine("\t\t\t\t" + "|                            |");
            //Console.WriteLine("\t\t\t\t" + "|        BiblioPolis         |");
            //Console.WriteLine("\t\t\t\t" + "|                            |");
            //Console.WriteLine("\t\t\t\t" + "+----------------------------+");

            TextoAnimado(2,("\n\t\t\t\t"  + "+----------------------------+"));
            TextoAnimado(2,("\n\t\t\t\t"  + "|                            |"));
            TextoAnimado(30,("\n\t\t\t\t" + "|        BiblioPolis         |"));
            TextoAnimado(2,("\n\t\t\t\t"  + "|                            |"));
            TextoAnimado(2,("\n\t\t\t\t"  + "+----------------------------+"));
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void RecuadroInicioSesion()
        {
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t\t\t" + "+--------------------------------------------+");
            Console.WriteLine("\t\t\t" + "|              Inicio de sesión              |");
            Console.WriteLine("\t\t\t" + "+--------------------------------------------+");
            Console.WriteLine("\t\t\t" + "| Usuario:                                   |");
            Console.WriteLine("\t\t\t" + "|                                            |");
            Console.WriteLine("\t\t\t" + "| Contraseña:                                |");
            Console.WriteLine("\t\t\t" + "+--------------------------------------------+");
            Console.ResetColor();
        }

        public static void OpcionIngresar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t" + "  [Ingresar]");
            Console.ResetColor();
        }

        public static void MensajeAceptado()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t" + "=-=-=-= Acceso correcto =-=-=-=");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t" + "    [Ir a Panel de Control]");
            Console.ResetColor();
        }

        public static void MensajeRechazado()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("\t\t\t" + "  =-=-= Usuario o contraseña incorrectos =-=-=");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t" + "  [Reintentar]");
            Console.ResetColor();
        }

        public static void TextoAnimado(int velocidad, string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(velocidad);
            }
        }

        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        public static void Dibujar(int num)
        {
            switch (num)
            {
                case 0:
                    string dibujoASCII = @"
                                     _.-""\
                                 _.-""     \
                              ,-""          \
                             ( \            \
                              \ \            \
                               \ \            \
                                \ \         _.-;
                                 \ \    _.-""   :
                                  \ \,-""    _.-""
                                   \(   _.-"" 
                                   `--""";
                    Console.WriteLine(dibujoASCII);
                    break;
                case 1:
                    dibujoASCII = @"
                           .--.                   .---.
                       .---|__|           .-.     |~~~|
                    .--|===|--|_          |_|     |~~~|--.
                    |  |===|  |'\     .---!~|  .--|   |--|
                    |%%|   |  |.'\    |===| |--|%%|   |  |
                    |%%|   |  |\.'\   |   | |__|  |   |  |
                    |  |   |  | \  \  |===| |==|  |   |  |
                    |  |   |__|  \.'\ |   |_|__|  |~~~|__|
                    |  |===|--|   \.'\|===|~|--|%%|~~~|--|
                    ^--^---'--^    `-'`---^-^--^--^---'--'";
                    Console.WriteLine(dibujoASCII);
                    break;
                case 2:
                    dibujoASCII = @"
                                               .oMc
                                            .MMMMMP
                                          .MM888MM
                    ....                .MM88888MP
                    MMMMMMMMb.         d8MM8tt8MM
                     MM88888MMMMc `:' dMME8ttt8MM
                      MM88tt888EMMc:dMM8E88tt88MP
                       MM8ttt888EEM8MMEEE8E888MC
                       `MM888t8EEEM8MMEEE8t8888Mb
                        ""MM88888tEM8""MME88ttt88MM
                         dM88ttt8EM8""MMM888ttt8MM
                         MM8ttt88MM"" "" ""MMNICKMM""
                         3M88888MM""      ""MMMP""
                          ""MNICKM""";
                    Console.WriteLine(dibujoASCII);
                    break;
                default:
                    break;
            }
        }
    }
}