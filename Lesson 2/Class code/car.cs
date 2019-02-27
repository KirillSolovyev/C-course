using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Task{
    [Serializable]
    class Car{
        public string mark;
        public string model;
        private int price;

        Dictionary<string, string> equip = new Dictionary<string, string>();

        public Car(string _mark, string model, int price){
            mark = _mark;
            this.model = model;
            this.price = price;
        }

        public Car(string _mark, string model, int price, Dictionary<string, string> equip){
            mark = _mark;
            this.model = model;
            this.price = price;
            this.equip = equip; 
        }

        public void ShowCar(){
            Console.WriteLine(mark + " " + model);
            Console.WriteLine("Price is ${0}", price);
            if(equip.Count != 0){
                foreach(var el in equip){
                    Console.WriteLine(el.Key + ": " + el.Value);
                }
            }
        }
    }

    class Program{
        static void Main(){
            Car c1 = new Car("Toyota", "Camry 70", 35000, new Dictionary<string, string>{{"Color", "Black"}, {"Cabin", "Leather"}});
            Car c2 = new Car("Tesla", "Model X", 80000);
            StreamReader sr = new StreamReader("order.txt");
            string s = sr.ReadLine();
            string[] orders = s.Split(',');
            sr.Close();
            List<Car> AutoShop = new List<Car>();
            AutoShop.Add(c1);
            AutoShop.Add(c2);

            for(int i = 0; i < orders.Length; i++){
                bool isFound = false;
                for(int j = 0; j < AutoShop.Count; j++){
                    if(orders[i] == AutoShop[j].model){
                        isFound = true;
                        Console.WriteLine("The car {0} was sold\n", orders[i]);
                        Car toSold = AutoShop[j];
                        AutoShop.Remove(toSold);
                        FileStream sw = new FileStream("SoldCar.txt", FileMode.OpenOrCreate);
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(sw, toSold);
                        sw.Close();
                    }
                }
                if(isFound == false){
                    Console.WriteLine("The car {0} was not found\n", orders[i]);
                }
            }
        }
    }
}