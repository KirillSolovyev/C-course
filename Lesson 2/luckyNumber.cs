using System;

namespace Example{
    class Program{
        // Lucky ticket
        static void Main(){
            string s = Console.ReadLine();
            int n = 0, n1 = 0;

            for(int i = 0; i < 6; i++){
                if(i < 3){
                    n += Convert.ToInt32(s[i]);
                }else{
                    n1 += Convert.ToInt32(s[i]);
                }
            }

            if(n == n1){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}