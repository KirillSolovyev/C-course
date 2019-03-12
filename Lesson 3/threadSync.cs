using System;
using System.Threading;

namespace std{
    class Program{
        static int x = 0;
        public static void unsynchronized(){
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Поток: {0} x = {1}", Thread.CurrentThread.Name, x);
                x++;
                Thread.Sleep(1);
            }
        }

        static void Main(){
            for(int i = 1; i < 6; i++){
                Thread nThread = new Thread(unsynchronized);
                nThread.Name = "№ " + i;
                nThread.Start();
            }
        }
    }
}