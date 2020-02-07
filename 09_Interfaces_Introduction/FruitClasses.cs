using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction
{
    public class Apple : IFruit
    {   //fields
        //constructors
        //properties
        //methods - 
        public Apple() { }
        public Apple(bool isPeeled)
        {
            Peeled = isPeeled;
        }
        public string Name { get { return "Apple"; }}
        public bool Peeled { get; private set; }
        public string Peel() 
        {
            Peeled = true;
            return "You peeled the apple you creep";
        }
    }

    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            Peeled = isPeeled;
        }

        public string Name { get { return "Orange"; } }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peeled the orange you champ";
        }

        public string Zest()
        {
            if (Peeled)
            {
                return "Why are you doing this?";
            }
            else
            {
                return "You zested the orange you chef";
            }
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }
        public bool Peeled { get; private set; }

        public string Peel()
        {
            return "Who peels a grape?";
        }
    }
}
