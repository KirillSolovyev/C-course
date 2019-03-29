using System;

namespace std{
    class Program{
        static void Main(){
            DateTime t1 = DateTime.Now;
            Console.WriteLine(t1.ToString("Date: yyyy/MM/dd Time: HH:mm:ss:fff"));
            Console.ReadLine();
        }
    }
}