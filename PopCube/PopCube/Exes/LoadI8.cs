using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembler;

namespace PopCube.Exes
{
    public class LoadI8 : IExe
    {
        public LoadI8()
        {
            ID = 17;
        }

        public override void Execute(object Pramater,ref Scope s)
        {
            s.Push(Pramater);
        }

        public override object ReadParameter(ref ByteCodeStream bcs)
        {
            return bcs.ReadByte();
        }
    }
}
