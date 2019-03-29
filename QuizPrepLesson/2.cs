using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Example{
    [Serializable]
    public class Employee{
        public string name;
        
        public string id;
        public int salary = 50000;

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public string Id{
            get{
                return id;
            }
            set{
                id = value;
            }
        }

        public int Salary{
            get{
                return salary;
            }
            set{
                salary += value;
            }
        }

        public Employee(string _name, string _id, int _salary){
            Name = _name;
            Id = _id;
            Salary = _salary;
        }

        public Employee(){}

        public void ShowInfo(){
            Console.WriteLine("Name: {0} Id: {1} Salary: {2}", name, id, salary);
        }
    }
    class Program{
        static void Main(){
            Employee e1 = new Employee("Kirill", "12345", 0);
            XmlSerializer Xser = new XmlSerializer(typeof(Employee));
            using(FileStream fs = new FileStream(@"C:\Users\admin\Desktop\QuizPrep\employee.xml", FileMode.OpenOrCreate)){
                Xser.Serialize(fs, e1);
            } 

            Employee serializedE;
            using(FileStream fs = new FileStream(@"C:\Users\admin\Desktop\QuizPrep\employee.xml", FileMode.OpenOrCreate)){
                serializedE = Xser.Deserialize(fs) as Employee;
            } 

            serializedE.ShowInfo();
        }
    }
}