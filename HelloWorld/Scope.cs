using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Scope
    {
        private string k = " ";
        public void PrintNumbers()
        {
                
                  string j=" ";
                Console.WriteLine("Inside loop:");
                for (int i = 1; i <= 10; i++)
                {
                    k = i.ToString();
                    j = i.ToString();
                  //  Console.WriteLine(i);
                }
              //  Console.WriteLine("outside loop "+j);
              //  Console.WriteLine("outside loop " + k);
                

        }
        public void HelperMethod() {
           // Console.WriteLine("Value of k accessing from Helper Method:"+k);
        
        }
    }
}
