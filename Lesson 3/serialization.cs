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
            Paysage picture1 = new Paysage("is setting down", "firs", "jupms", "on a tree");
            // picture1.DrawPaysage();
            BinaryFormatter bin = new BinaryFormatter();
            using(FileStream ser = new FileStream("pic1.bin", FileMode.OpenOrCreate, FileAccess.Write)){
                bin.Serialize(ser, picture1);
            }

            Paysage pictureFromPhoto;
            using(FileStream ser = new FileStream("pic1.bin", FileMode.Open, FileAccess.Read)){
                pictureFromPhoto = bin.Deserialize(ser) as Paysage;
            }
            pictureFromPhoto.DrawPaysage();
        }
    }
}