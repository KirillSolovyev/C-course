using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ex{
    [Serializable]
    class Paysage{
        string sun = "sunset";
        string trees = "fir";
        string rabbit = "jumps";
        string squirrel = "on tree";

        public Paysage(string _sun, string _trees, string _rabbit, string _squirrel){
            sun = _sun;
            trees = _trees;
            rabbit = _rabbit;
            squirrel = _squirrel;
        }

        public void DrawPaysage(){
            Console.WriteLine("Rabbit {0}. Sun {1}. Squirrel {2} and {3} swing in the wind", rabbit, sun, squirrel, trees);
        }
    }

    class Program{
        static void Main(){
            Paysage photo;
            BinaryFormatter bin = new BinaryFormatter();
            using(FileStream fs = new FileStream("pic1.bin", FileMode.Open, FileAccess.Read)){
                photo = bin.Deserialize(fs);
            }
            photo.DrawPaysage();
        }
    }
}