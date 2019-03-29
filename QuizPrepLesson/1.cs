using System;
using System.Threading;

namespace std{
    class Program{
        static void getSubString(string s){
            for(int i = 0; i < s.Length; i++){
                string subStr = null;
                for(int j = i; j < s.Length; j++){
                    subStr += s[j];
                    Console.Write(subStr + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Completed");
        }

        static void GetCurrentTime(){
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine("Completed");
        }
        static void Main(){
            string s = Console.ReadLine();
            Thread t1 = new Thread(GetCurrentTime);
            Thread t2 = new Thread(() => {
                getSubString(s);
            });
            t1.Start();
            t2.Start();
        }
    }
}