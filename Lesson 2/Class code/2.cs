using System;

namespace Task{
    class Program{
        static void Main(){
            string s = Console.ReadLine();
            int sum1 = 0, sum2 = 0;

            for(int i = 0; i < 6; i++){
                int num = Convert.ToInt32(s[i]);
                if(i < 3){
                    sum1 += num;
                }else{
                    sum2 += num;
                }
            }

            if(sum1 == sum2){
                Console.WriteLine(@"\nYES");
            }else{
                Console.WriteLine("\nNO");
            }
        }
    }
}