using System;

namespace Task{
    class Program{
        static void Main(){
            int n = int.Parse(Console.ReadLine());
            // int n = int.Parse(s);

            int sum = 0;

            for(int i = 1; i <= n; i++){
                sum += i;
            }

            Console.WriteLine(sum);
            // Console.Write("Hello");
        }
    }
}