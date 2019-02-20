using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

//Serialization: Binary Serialization (to bites)

namespace Std{
    [Serializable]
    public class ToSerialize{
        public string name{ get; set; }

        [NonSerialized]
        public int age;

        public ToSerialize(string _name, int _age){
            name = _name;
            age = _age;
        } 

        public void Show(){
            Console.WriteLine("Name: {0}; Age: {1};", name, age);
        }
    }
    class Program{
        static void Main(){
            ToSerialize per = new ToSerialize("Kirill", 19);
            // Binary Serialization
            BinaryFormatter El = new BinaryFormatter(); 
            using(FileStream fs = new FileStream(per.name + ".dat", FileMode.Create)){
                El.Serialize(fs, per);
            }
            // Binary Deserialization
            using(FileStream sr = new FileStream(per.name + ".dat", FileMode.Open)){
                BinaryFormatter des = new BinaryFormatter();
                ToSerialize Per = (ToSerialize)des.Deserialize(sr);
                Per.Show();
                // Output is Kirill 0 (since the age field is nonserialized, otherwise - 19)
            }
        }
    }
}