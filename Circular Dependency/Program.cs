using System;

namespace Circular_Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface Solution
            Person person = new Person();
            person.Run();

            // Emitter Solution
            Person2 person2 = new Person2();
            person2.Run();
        }
    }
   
}
