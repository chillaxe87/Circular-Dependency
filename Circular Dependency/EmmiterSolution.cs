using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Dependency
{
    public delegate void CoffeeReady();
    public class Person2
    {
        public void Run()
        {
            Console.WriteLine("Running 2");
            CoffeeMachine2 machine = new CoffeeMachine2();
            CoffeeReady coffee = new CoffeeReady(CallFriends);
            machine.BrewCoffee(coffee);
        }
        public void CallFriends()
        {
            Console.WriteLine("Calling Friends 2");
        }
    }
    public class CoffeeMachine2
    {
        public void BrewCoffee(CoffeeReady coffee)
        {
            Console.WriteLine("Brewing Coffee 2");
            coffee.Invoke();
        }
    }
}
