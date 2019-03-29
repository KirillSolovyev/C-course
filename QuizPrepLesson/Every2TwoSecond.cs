using System;
using System.Threading;

namespace std{
    class Program{
        static public void CurrentTime(){
            while(true){
                DateTime t1 = DateTime.Now;
                Console.Clear();
                Console.WriteLine(t1.ToString("yyyy/MM/dd HH:mm:ss:fff"));
                Thread.Sleep(1000);
            }
        } 

        static void Main(){
            Thread t1 = new Thread(CurrentTime);
            t1.Start();
        }
    }
}