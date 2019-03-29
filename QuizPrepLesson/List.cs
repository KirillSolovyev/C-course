using System;
using System.Collections.Generic;

namespace Ex{
    class Program{
        static void Main(){
            List<string> lst = new List<string>();
            lst.Add("Hello");
            lst.Add("Hi");
            lst.Add("Hola");
            lst.Remove("Hi");

            // for(int i = 0; i < lst.Count; i++){
            //     //string el = lst[i];
            //     lst[i] += '@';
            //     Console.WriteLine(lst[i]);
            // }

            foreach(string el in lst){
                //el += '@';
                Console.WriteLine(el);
            }

        }
    }
}