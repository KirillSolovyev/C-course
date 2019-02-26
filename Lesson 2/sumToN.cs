using System;

namespace Example{
    class Program{
        static void Main(){
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int ans = 0;
            for(int i = 1; i <= n; i++){
                ans += i;
            }
            Console.WriteLine(ans);
        }
    }
}