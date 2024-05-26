using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Абстрактный класс "Транспорт"
    public abstract class Transport
    {
        public string Model { get; set; }

        public abstract void Move(); // Абстрактный метод
    }

    // Конкретный класс "Машина" наследует абстрактный класс "Транспорт"
    public class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Машина движется по дороге");
        }

        public void Accelerate()
        {
            Console.WriteLine("Машина ускоряется");
        }
    }

    // Конкретный класс "Самолет" также наследует абстрактный класс "Транспорт"
    public class Airplane : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Самолет летит в небе");
        }

        public void TakeOff()
        {
            Console.WriteLine("Самолет взлетает");
        }
    }
}
