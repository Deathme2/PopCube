using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    public abstract class iAssembler
    {
        public abstract bool IsMe(iAst src);
        public abstract void Assemble(iAst src, ref ByteCodeWriter bcw);
    }
}
