using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCube
{
    class Program
    {
        static void Main(string[] args)
        {
            var rp = new PopCube();
            rp.Execute(File.ReadAllBytes(@"C:\Users\Myvar\Google Drive\PopCube\Assembler\bin\Debug\test.pc"));
        }
    }
}
