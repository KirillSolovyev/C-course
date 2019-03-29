using System;
using System.Threading;

namespace std{
    class Program{
        static public void Count(){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i);                
            }
        }

        static public void Count2(){
            for(int i = 100; i <= 110; i++){
                Console.WriteLine(i);                
            }
        }
        static void Main(){
            Thread t1 = new Thread(Count);
            t1.Start();
            Count2();
        }
    }
}