using Assembler.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler.Assemblers
{
    public class LoadAsm : iAssembler
    {
        public override void Assemble(iAst src, ref ByteCodeWriter bcw)
        {
            var x = src as PushStmt;
            if(string.IsNullOrEmpty(x.Type))
            {
                bool isString = false;
                foreach(var i in x.RawValue)
                {
                    if(!char.IsDigit(i))
                    {
                        isString = true;
                        break;
                    }
                }


                if(isString)
                {
                    bcw.LoadString(x.RawValue);
                }
                else
                {
                    bcw.LoadI32(Convert.ToInt32(x.RawValue));
                }
            }
            else
            {
                switch(x.Type)
                {
                    case "i8":
                        bcw.LoadI8(Convert.ToSByte(x.RawValue));
                        break;
                }
            }
        }

        public override bool IsMe(iAst src) => src is PushStmt;
    }
}
