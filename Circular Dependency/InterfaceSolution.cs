using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Dependency
{
    public class Person : IPerson
    {
        public void Run()
        {
            Console.WriteLine("Running");
            CoffeeMachine coffee = new CoffeeMachine();
            coffee.BrewCoffee(this);
        }
        public void CallFriends()
        {
            Console.WriteLine("Calling Friends");
        }
    }
    public interface IPerson
    {
        void Run();
        void CallFriends();
    }
    public class CoffeeMachine
    {
        public void BrewCoffee(IPerson person)
        {
            Console.WriteLine("Brewing Coffee");
            person.CallFriends();
        }
    }
}
