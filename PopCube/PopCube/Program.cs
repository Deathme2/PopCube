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
            rp.Execute(File.ReadAllBytes(args[0]));
            rp.SaveState("debug.json");
        }
    }
}
