using System;
using System.Threading;

namespace std{
    class Program{
        static public void Count(){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i); 
                Thread.Sleep(1000);               
            }
        }
        static void Main(){
            Thread t1 = new Thread(Count);
            t1.Start();
        }
    }
}