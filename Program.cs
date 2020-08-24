using System;
using System.Linq;
using System.Threading;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dot = 300;
            Console.Write("Intrduzca un mensaje: ");
            string message = Console.ReadLine();
            message = message.ToUpper();

            MorseDictionary morse = new MorseDictionary();
            foreach(var element in message)
            {
                for (int i = 0; i < morse.morseDictionary[element].Length; i++)
                {
                    Console.Write(morse.morseDictionary[element][i]);
                    if (morse.morseDictionary[element][i] == '.')
                    {
                        Console.Beep(400, dot);
                        Thread.Sleep(dot);
                    }
                    else
                    {if(morse.morseDictionary[element][i] == '-')
                        {
                            Console.Beep(400, dot * 3);
                        }

                    }
                }
                Console.Write("|");
            }
        }
    }
}
