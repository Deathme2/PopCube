using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler.Ast
{
    public class AddStmt : iAst
    {
        public override bool isMe(string raw) => raw.ToLower().StartsWith("add");

        public override iAst Parse(string raw)
        {
            var re = new AddStmt();

            return re;
        }
    }
}
