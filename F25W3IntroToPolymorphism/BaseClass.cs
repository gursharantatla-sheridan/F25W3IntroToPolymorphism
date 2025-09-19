using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F25W3IntroToPolymorphism
{
    public class BaseClass
    {
        public void Show()
        {
            Console.WriteLine("Base class Show method");
        }
    }

    public class  DerivedClass : BaseClass
    {
        public new void Show()
        {
            Console.WriteLine("Derived class Show method");
        }
    }
}
