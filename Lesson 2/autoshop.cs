using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Example{

    [DataContract]
    public class Car{
        [DataMember]
        public string model;
        [DataMember]
        public string mark;
        [DataMember]
        public decimal price;
        public int quantity = 1;
        [DataMember]
        public Dictionary<string, string> equipment = new Dictionary<string, string>();

        [DataMember]
        public decimal GetPrice{
            get{
                return price;
            }
            set{
                if(value < 500){
                    price = 500;
                }else{
                    price = value;
                }
            }
        }

        public Car(string _model, string _mark, decimal _price, Dictionary<string, string> equip, int _quantity){
            model = _model;
            mark = _mark;
            GetPrice = _price;
            equipment = equip;
            quantity = _quantity;
        }

        public Car(string _model, string _mark, decimal _price, int _quantity){
            model = _model;
            mark = _mark;
            GetPrice = _price;
            quantity = _quantity;
            equipment.Add("Color", "Black");
            equipment.Add("Cabin", "Leather");
        }

        public Car(){

        }

        public void ShowCar(){
            Console.WriteLine("\n" + mark + " " + model);
            Console.Write("Equipment: ");
            foreach(var el in equipment){
                Console.Write(el.Key + ": " + el.Value + ", ");
            }
            Console.Write("\nPrice: ${0}\n", GetPrice);
        }
    }

    class AutoShop{
        List<Car> cars = new List<Car>();

        public AutoShop(List<Car> _cars){
            cars = _cars;
        }

        public void AddCar(Car item){
            if(cars.Contains(item) == true){
                item.quantity++;
            }else{
                cars.Add(item);
            }
        }

        public void RemoveCar(Car item){
            if(cars.Contains(item) == true){
                item.quantity--;
                if(item.quantity == 0){
                    cars.Remove(item);
                }
            }else{
                Console.WriteLine("No such cars were found");
            }
        }

        public Car BuyCar(string _model){
            bool hasCar = false;
            Car toRemove = new Car();
            for(int i = 0; i < cars.Count; i++){
                if(cars[i].model == _model){
                    hasCar = true;
                    toRemove = cars[i];
                    break;
                }
            }

            if(hasCar){
                Console.WriteLine("The car {0} was sold", _model);
                RemoveCar(toRemove);
                return toRemove;
            }else{
                Console.WriteLine("Sorry, we have no such car {0}", _model);
                return null;
            }
        }

        public void SendCar(Car item){
            DataContractSerializer XmlSer = new DataContractSerializer(typeof(Car));
            using(FileStream fs = new FileStream(item.model + ".xml", FileMode.OpenOrCreate)){
                XmlSer.WriteObject(fs, item);
            }
        }

    }

    class Program{
        static void Main(){
            Car c1 = new Car("Camry 70", "Toyota", 34700, new Dictionary<string, string>{{"Color","Black/White"}, {"Cabin", "Leather"}, {"Tires", "Steel"}}, 1);
            Car c2 = new Car("Model X", "Tesla", 88000, 2);
            AutoShop salon = new AutoShop(new List<Car>{c1, c2});
            using(StreamReader sr = new StreamReader("order.txt")){
                string s = sr.ReadLine();
                string[] orders = s.Split(',');
                for(int i = 0; i < orders.Length; i++){
                    Car toSer = salon.BuyCar(orders[i]);
                    if(toSer != null){
                        salon.SendCar(toSer);
                    }
                }
            }
        }
    }
}