using Assembler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCube
{
    public abstract class IExe
    {
        public int ID { get; set; }
        public abstract object ReadParameter(ref ByteCodeStream bcs);
        public abstract void Execute(object Pramater, ref Scope s);
    }
}
