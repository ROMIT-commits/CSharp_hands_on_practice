using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorld
{
    internal class AssembliesAndNamespaces
    {
        string text = "We want to write this in our code";
        public void PrintString() {
            File.WriteAllText(@"C:\Users\DELL\Documents\C# Practice\HelloWorld\HelloWorld\AssembliesAndNamespaces",text);
        }
    }
}
