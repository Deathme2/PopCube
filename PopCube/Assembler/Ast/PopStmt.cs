using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler.Ast
{
    public class PopStmt : iAst
    {
        public string RawValue { get; set; }

        public override bool isMe(string raw) => raw.ToLower().StartsWith("pop");

        public override iAst Parse(string raw)
        {
            var re = new PopStmt();

            var s = raw.Remove(0, 4).Trim();
            re.RawValue = s.Trim();

            return re;
        }
    }
}
