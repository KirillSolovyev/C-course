using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex{
    class Program{

        static void CountLetter(){
            for(int i = 0; i < 10; i++){
                Console.Write((char)('a' + i) + " ");
            }
            Console.WriteLine();
        }

        static void Main(){
            // CountInt();
            // CountLetter();
            Task th = new Task(() => {
                for(int i = 1; i <= 10; i++){
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            });
            // th.Start();
            th.RunSynchronously();
            CountLetter();
            // th.Wait();
        }
    }
}