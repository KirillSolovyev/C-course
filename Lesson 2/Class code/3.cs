using System;
using System.Text.RegularExpressions;

namespace Task{
    class Program{
        static void Main(){
            string s = Console.ReadLine();
            string subInt = "";
            string word = "";
            for(int i = 0; i < s.Length; i++){
                if(s[i] != ' ' && i < 3){
                    subInt += s[i];
                }else if(s[i] != ' '){
                    word += s[i];
                }
            }
            // s = Regex.Replace(s, @"\s+", " ");
            // string[] a = s.Split();
            int n = Convert.ToInt32(subInt);
            string ans = word.Remove(n - 1, 1);
            
            Console.WriteLine(ans);
        }
    }
}