using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_Introduction
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit apple = new Apple();
            var output = apple.Peel();
            Console.WriteLine(output);
            Console.WriteLine($"The apple is peeled: {apple.Peeled}");
            Assert.IsTrue(apple.Peeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            var orange = new Orange();
            var fruitSalad = new List<IFruit>
            {
                new Apple(),
                new Grape(),
                orange
            };

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                Assert.IsInstanceOfType(fruit, typeof(IFruit));
                if(fruit is Orange o)
                {
                    o.Zest();
                }
            }
        }
            private string GetFruitName(IFruit fruit)
        {
            return$"This fruit is called {fruit.Name}";
        }
        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);
            Console.WriteLine(output);
            Assert.IsTrue(output.Contains("Grape"));
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            List<IFruit> fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Apple(true),
                new Grape()
            };
            Console.WriteLine("Is the orange peeled?");
            foreach(var fruit in fruitSalad)
            {
                if (fruit is Orange orange)
                {
                    if (orange.Peeled)
                    {
                        Console.WriteLine("Is a peeled orange");

                    }
                    else
                    {
                        Console.WriteLine(orange.Zest());
                    }
                }
                else if(fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("We have some grapes");
                }
                else if(fruit.Peeled)
                {
                    Console.WriteLine("Is a peeled apple");
                }
                else
                {
                    Console.WriteLine("Is a non-peeled Apple");
                }
            }
        }
    }
}
