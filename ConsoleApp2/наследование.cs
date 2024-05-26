using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Рисование фигур");
        }
    }

    // Производный класс, наследующийся от Shape(фигуры)
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисование круга"); 
        }
    }

    class наследование
    {
        static void Main()
        {
            Console.WriteLine("Наследование");
            Console.WriteLine(" ");
            Shape shape1 = new Shape();
            Shape shape2 = new Circle();

            shape1.Draw(); // Выводит "Drawing shape"
            shape2.Draw(); // Выводит "Drawing circle"

            Console.WriteLine("...............................................................");
            Console.WriteLine("Полиморфизм");
            Console.WriteLine(" ");
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();

            animal1.MakeSound(); // Выводит "Dog barks"
            animal2.MakeSound(); // Выводит "Cat meows"
            Console.WriteLine("...............................................................");
            Console.WriteLine("Абстракция");
            Console.WriteLine(" ");
            Transport car = new Car();
            car.Model = "Toyota";
            car.Move(); // Вызываем метод Move для машины

            Car specificCar = (Car)car; // Приведение типа для доступа к уникальным методам класса Car
            specificCar.Accelerate(); // Вызываем метод Accelerate для машины

            Transport airplane = new Airplane();
            airplane.Model = "Boeing";
            airplane.Move(); // Вызываем метод Move для самолета

            Airplane specificAirplane = (Airplane)airplane; // Приведение типа для доступа к уникальным методам класса Airplane
            specificAirplane.TakeOff(); // Вызываем метод TakeOff для самолета

            Console.WriteLine("...............................................................");
            Console.WriteLine("Инкапсуляция");
            Console.WriteLine(" ");
            Person person = new Person("Иван", 90);

            Console.WriteLine($"Имя: {person.GetName()}, Возраст: {person.GetAge()}");

            person.SetName("Петр");
            person.SetAge(15);

            Console.WriteLine($"Имя: {person.GetName()}, Возраст: {person.GetAge()}");
            Console.ReadKey();
        }
    }

}

