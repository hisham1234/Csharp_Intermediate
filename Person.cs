using System;

namespace Csharp_Intermediate
{
    partial class Program
    {
        public class Person
        {
            public string Name;
            public static Person Parse(string text)
            {
                var person = new Person();
                person.Name = text;
                return person;
            }

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0} I am {1}",Name,to);
            }
        }
    }
}
