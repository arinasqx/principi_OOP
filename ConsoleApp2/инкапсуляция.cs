using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        private string имя;
        private int годики;

        public Person(string имя, int годики)
        {
            this.имя = имя;
            this.годики = годики;
        }

        public void SetName(string name)
        {
            this.имя = name;
        }

        public string GetName()
        {
            return имя;
        }

        public void SetAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Возраст не может быть отрицательным");
            }

            this.годики = age;
        }

        public int GetAge()
        {
            return годики;
        }
    }
}
    
