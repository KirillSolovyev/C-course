using System;

namespace ClassExample{
    class Person{ // Создадим класс Person 
        public string name; // Имя
        public int age; //Возраст
        public string city; // Город
        public static int personCnt = 0; // Статическое поле, считающее сколько экземпляров класса Person создано

        public Person(){ // Конструктор без параметров
            personCnt++; // Каждый раз, когда создается Person увеличивать счетчик на 1
        }

        public Person(string name, int age) : this(){ // Конструктор, принимающий два аргумента: имя и возраст.
            // : this() означает, что при создании класса Person вторым конструктором (строка 14) вызывается первый конструктор (строка 10)
            this.name = name; // Так как имена полей (5 - 6 строка) совпадают с названиями аргументов конструктора (то что 
            this.age = age;   // передается в скобках в строке 14) нужно писать this.имя_поля для того, чтобы не возникали ошибки
        }

        public Person(string _name, int _age, string _city) : this(){ // Принимает 3 аргумента. : this() вызывает первый конструктор
            name = _name; // Так как имена полей и агрументов в конструкторе разные (name != _name) нет необходимости использовать this.имя_поля
            age = _age;
            city = _city;
        }

        public void Greeting(){ // Функция, которая будет выводить приветствие
            Console.WriteLine("Hello, I\'m {0}! I\'m {1} y.o I\'m living in {2}\n", name, age, city);
        }

        public static void StaticF(string Name){ // Статическая функция, не требующая экземпляр класса
            Console.WriteLine("Hello from static, {0}! This function does not need an instance of the class\n", Name);
        }
    }

    class Execute{
        public static void Main(){
            Person.StaticF("Kirill"); // Функция работает даже если не создан ни один экземпляр класса, потому что она статическая
            Person man1 = new Person("Jack", 25); // Создаем экземпляр Person вторым конструктором
            man1.city = "Almaty"; // Назначаем город для man1
            Person man2 = new Person("Lily", 20, "Astana"); // Создаем экземпляр Person третьим конструктором
            Person man3 = new Person(){name = "Anna", age = 18, city = "Almaty"}; // Создаем экземпляр Person первым конструктором, одновременно
                                                                                 // назначая полям name, age, city значения
            man1.Greeting(); // Вызываем функцию Greeting
            man2.Greeting();
            man3.Greeting();
            Console.WriteLine("Persons were created: {0}", Person.personCnt); // Вывести количество созданных Person
        }
    }
}