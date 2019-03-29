using System;
using System.Threading;

namespace std{
    class Program{
        static void Main(){
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0");
            Console.WriteLine("0");
            Console.WriteLine("0");
            int Color = 0;
            while(true){
                Console.Clear();
                if(Color == 0){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("0");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("0");
                    Console.WriteLine("0");
                    Color = 1;
                }else if(Color == 1){
                    Console.WriteLine("0");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("0");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("0");
                    Color = 2;
                }else if(Color == 2){
                    Console.WriteLine("0");
                    Console.WriteLine("0");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0");
                    Console.ForegroundColor = ConsoleColor.White;
                    Color = 0;
                }
                Thread.Sleep(1000);
            }
        }
    }
}