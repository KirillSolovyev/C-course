using System;
using System.Threading;

namespace std{
    class Program{
        static int x = 0;
        // Without synchronization threads will be unknownly implemented
        // This function is not synchronized
        // Output is unknown
        public static void unsynchronized(){
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Поток: {0} x = {1}", Thread.CurrentThread.Name, x);
                x++;
                Thread.Sleep(1);
            }
        }

        static object synchronizer = new object();
        public static void synchronized(){ //When a thread started counting all other threads
                                           //were waiting for the thread count to 10
            lock(synchronizer){
                x = 1;
                for(int i = 0; i < 10; i++){
                    Console.WriteLine("Поток: {0} x = {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(1);
                }
            }
        }

        static void Main(){
            for(int i = 1; i < 6; i++){
                // Thread nThread = new Thread(unsynchronized);
                Thread nThread = new Thread(synchronized);
                nThread.Name = "№ " + i;
                nThread.Start();
            }
        }
    }
}