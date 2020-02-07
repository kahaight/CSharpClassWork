using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction
{
    public interface IFruit
    {
        string Name { get; }//implement an interface and inherit from a class, interface also called a contract, when you sign the contract, you must have the elements present in the interface
        bool Peeled { get; }
        string Peel();//don't care what the method does, but you must include a method called peel
    }
}
