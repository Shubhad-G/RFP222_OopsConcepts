using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class parentClass
    {
        public void printParent()
        {
            Console.WriteLine("parent class");
        }
    }

    public class childClass:parentClass
    { 
        public void printChild()
        {
            Console.WriteLine("Child Class");
        }
    }
}
