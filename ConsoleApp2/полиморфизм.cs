using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Издавание звуков");
        }
    }

    // Производный класс, наследующийся от Animal
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Собака гавкает");
        }
    }

    // Еще один производный класс, наследующийся от Animal
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Кошка мяукает");
        }
    }
}

