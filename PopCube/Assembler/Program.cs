using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    class Program
    {
        static void Main(string[] args)
        {
            var ass = new Assembler();
            ass.Assemble(File.ReadAllText(args[0]), "test.pc");

        }
    }
}
