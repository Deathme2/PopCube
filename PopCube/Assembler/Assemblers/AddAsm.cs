using Assembler.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler.Assemblers
{
    public class AddAsm : iAssembler
    {
        public override void Assemble(iAst src, ref ByteCodeWriter bcw)
        {
            bcw.Add();
        }

        public override bool IsMe(iAst src) => src is AddStmt;
    }
}
