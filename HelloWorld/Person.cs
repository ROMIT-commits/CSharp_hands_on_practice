using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // In the same project (same assembly)

    namespace Alpha
    {
        internal class A
        {
            public void DoSomething() => Console.WriteLine("A");
        }
    }

    namespace Beta
    {
        class B
        {
            public void UseA()
            {
                Alpha.A a = new Alpha.A(); // ✅ This works because both are in the same assembly
                a.DoSomething();
            }
        }
    }

}


