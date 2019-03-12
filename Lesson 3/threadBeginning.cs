using System;
using System.Threading;

namespace Ex{
    class Program{
        static void CountInt(){
            for(int i = 1; i <= 10; i++){
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void CountLetter(){
            for(int i = 0; i < 10; i++){
                Console.Write((char)('a' + i) + " ");
            }
            Console.WriteLine();
        }

        static void Main(){
            // CountInt();
            // CountLetter();
            Thread th = new Thread(CountLetter);
            th.Start();
            CountInt();
        }
    }
}