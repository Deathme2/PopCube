using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembler;

namespace PopCube.Exes
{
    public class LoadString : IExe
    {
        public LoadString()
        {
            ID = 16;
        }

        public override void Execute(object Pramater, ref Scope s)
        {
            s.Push(Pramater);
        }

        public override object ReadParameter(ref ByteCodeStream bcs)
        {
            var lgnt = bcs.ReadUInt32();
            return bcs.ReadString(lgnt);
        }
    }
}
