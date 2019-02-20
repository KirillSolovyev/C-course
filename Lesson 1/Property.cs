using System;

namespace ClassExample{
    class Person{ // Создадим класс Person 
        public string name; // Имя
        int age; //Возраст
        public string city; // Город
        static int personCnt = 0; // Статическое поле, считающее сколько экземпляров класса Person создано

        public int Age{ // Свойство (Property) более гибкие поля для хранений данных 
            get{ // Работает когда требуется получить значение из свойства
                return age; // возвращает значение поля age
            }
            set{ // Работает когда назначается значение
                if(value < 0){ // Проверяем возраст. Если возраст слишком мал, то устанавливаем по умолчанию 0
                    age = 0;
                    Console.WriteLine("Too young"); // Если слишком стар, то устанавливаем по умолчанию 120
                }else if(value > 120){
                    age = 120;
                    Console.WriteLine("Too old");
                }else{ // Во всех других случаях поле agt будет хранить переданное значение
                    age = value;
                }
            }
        }

        public static int GetPersonCout{ // Мы не хотим, чтобы программа изменила значение personCnt, для этого создаем свойство GetPersonCout 
                              // и назначаем его только для чтения (ReadOnly)
            get{
                return personCnt;
            }
        }

        public Person(){ // Конструктор без параметров
            personCnt++; // Каждый раз, когда создается Person увеличивать счетчик на 1
        }

        public Person(string name, int age) : this(){ // Конструктор, принимающий два аргумента: имя и возраст.
            // : this() означает, что при создании класса Person вторым конструктором (строка 14) вызывается первый конструктор (строка 10)
            this.name = name; // Так как имена полей (5 - 6 строка) совпадают с названиями аргументов конструктора (то что 
            Age = age;   // передается в скобках в строке 14) нужно писать this.имя_поля для того, чтобы не возникали ошибки
        }

        public Person(string _name, int _age, string _city) : this(){ // Принимает 3 аргумента. : this() вызывает первый конструктор
            name = _name; // Так как имена полей и агрументов в конструкторе разные (name != _name) нет необходимости использовать this.имя_поля
            Age = _age; // Передаем значение в свойство Age (работает set, который проверяет на правильность введенных данных) 
            city = _city;
        }

        public void Greeting(){ // Функция, которая будет выводить приветствие
            Console.WriteLine("Hello, I\'m {0}! I\'m {1} y.o I\'m living in {2}\n", name, Age, city); // Когда вызывается свойство Age работает get
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
            Person man3 = new Person(){name = "Anna", Age = 18, city = "Almaty"}; // Создаем экземпляр Person первым конструктором, одновременно
                                                                                 // назначая полям name, age, city значения
            Person young = new Person("Young", -10, "SomeWhere"); // В консоле появится сообщение "Too young" и age присвоится 0
            Person old = new Person("Old", 1000, "There"); // В консоли появится сообщение "Too old" и age присвоится 120
            man1.Greeting(); // Вызываем функцию Greeting
            man2.Greeting();
            man3.Greeting();
            young.Greeting();
            old.Greeting();
            // Person.GetPersonCout = 5; // Error
            Console.WriteLine("Persons were created: {0}", Person.GetPersonCout);
        }
    }
}