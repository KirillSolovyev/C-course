using System;
using System.Collections.Generic;

namespace Example{

    class Car{
        string model;
        string mark;
        decimal price;
        Dictionary<string, string> equipment = new Dictionary<string, string>();

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

        public Car(string _model, string _mark, decimal _price, Dictionary<string, string> equip){
            model = _model;
            mark = _mark;
            GetPrice = _price;
            equipment = equip;
        }

        public Car(string _model, string _mark, decimal _price){
            model = _model;
            mark = _mark;
            GetPrice = _price;
            equipment.Add("Color", "Black");
            equipment.Add("Cabin", "Leather");
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

    class Program{
        static void Main(){
            Car c1 = new Car("Camry 70", "Toyota", 34700, new Dictionary<string, string>{{"Color","Black/White"}, {"Cabin", "Leather"}, {"Tires", "Steel"}});
            Car c2 = new Car("Model X", "Tesla", 88000);
            c1.ShowCar();
            c2.ShowCar();
        }
    }
}