using System;
using System.Threading;

namespace std{
    class Program{ 

        static public void CurrentTime(){
            DateTime t1 = DateTime.Now;
            Console.WriteLine(t1.ToString("yyyy/MM/dd HH:mm:ss:fff"));
            Console.WriteLine("Date thread is completed");
        } 

        static public void getSubStr(string s){
            for(int i = 0; i < s.Length; i++){
                string substr = null;
                for(int j = i; j < s.Length; j++){
                    substr += s[j];
                    Console.WriteLine(substr);
                }
            }
            Console.WriteLine("SubString thread is completed");
        } 

        static void Main(){
            string s = Console.ReadLine();
            Thread t1 = new Thread(CurrentTime);
            Thread t2 = new Thread(() => {
                getSubStr(s);
                //Console.WriteLine(12);
            });
            t1.Start();
            t2.Start();
            // getSubStr("Hello");
        }
    }
}