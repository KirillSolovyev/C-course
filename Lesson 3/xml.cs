using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Ex{
    [Serializable]
    public class Paysage{
        public string sun = "sunset";
        public string trees = "fir";
        public string rabbit = "jumps";
        public string squirrel = "on tree";

        public Paysage(){}

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
            XmlSerializer Xser = new XmlSerializer(typeof(Paysage));
            using(FileStream ser = new FileStream("pic2.xml", FileMode.OpenOrCreate, FileAccess.Write)){
                Xser.Serialize(ser, picture1);
            }

            Paysage pictureFromPhoto;
            using(FileStream ser = new FileStream("pic2.xml", FileMode.Open, FileAccess.Read)){
                pictureFromPhoto = Xser.Deserialize(ser) as Paysage;
            }
            pictureFromPhoto.DrawPaysage();
        }
    }
}