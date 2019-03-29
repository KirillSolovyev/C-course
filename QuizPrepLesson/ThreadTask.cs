using System;
using System.Threading;

namespace std{
    class Program{
        static string s; 

        static public void CurrentTime(){
            DateTime t1 = DateTime.Now;
            Console.WriteLine(t1.ToString("yyyy/MM/dd HH:mm:ss:fff"));
        } 

        static public void getSubStr(){
            for(int i = 0; i < s.Length; i++){
                string substr = null;
                for(int j = i; j < s.Length; j++){
                    substr += s[j];
                    Console.WriteLine(substr);
                }
            }
        } 

        static void Main(){
            s = Console.ReadLine();
            Thread t1 = new Thread(CurrentTime);
            Thread t2 = new Thread(getSubStr);
            t1.Start();
            t2.Start();
            // getSubStr("Hello");
        }
    }
}