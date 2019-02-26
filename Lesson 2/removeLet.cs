using System;
using System.Text.RegularExpressions;

namespace Example{
    class Program{
        // Remove letter
        static void Main(){
            string s = Console.ReadLine();
            s = Regex.Replace(s, @"\s+", " "); // Replace several spaces by one
            string[] a = s.Split();
            int pos = int.Parse(a[0]);
            s = a[1].Remove(--pos, 1);
            Console.WriteLine(s);
        }
    }
}