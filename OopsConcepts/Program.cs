
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int option;
            Console.WriteLine("enter the option\n 1.inheritance\n2.Encapsulation\n3.polymorphism and Abstraction");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    childClass ch = new childClass();
                    ch.printParent();//accessing parent class method using child class object
                    break;
                   
                case 2://Encapsulation in C# is implemented with different levels of access to object data that can be specified using the access modifiers:
                      // Public: Access to all code in the program
                       //Private: Access to only members of the same class
                    Console.WriteLine("this line of code is written in a class which contains other methods,objects and program statements which is to say that all these are encapsulated in one class");
                    break;

                case 3:
                    Random random = new Random();
                   int x= random.Next(1,4);//polymorphism-overloading of two methods which are having same name but different method signature(number of input paramaters)
                                           //here abstraction is also achieved as the menthod next is implemented in random class since it is not showing implementation details here
                    Console.WriteLine("{0}", x);
                    break;
            }
            Console.ReadLine();
        }
    }
}
