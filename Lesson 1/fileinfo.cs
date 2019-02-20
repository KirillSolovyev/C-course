using System;
using System.IO;

namespace FileDirectory{
    class Program{
        static void Main(){
            FileInfo file = new FileInfo(@"text.txt");
            if(!file.Exists){
                using(FileStream st = file.OpenWrite()){
                    using(StreamWriter sw = new StreamWriter(st)){
                        sw.WriteLine("Hello, world!");
                    }
                }
                using(StreamReader sr = file.OpenText()){
                    Console.WriteLine(sr.ReadLine());
                }
            }else{
                file.Delete();
            }
        }
    }
}