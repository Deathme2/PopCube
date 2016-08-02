using Assembler.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    public static class Parser
    {
        public static List<iAst> IastIndex { get; set; } = new List<iAst>()
        {
            new PushStmt(),
            new PopStmt(),
            new AddStmt()
        };

        public static List<iAst> Parse(string raw)
        {
            var re = new List<iAst>();
            foreach (var ln in raw.Replace("\r\n", "\n").Split('\n'))
            {
                foreach (var i in IastIndex)
                {
                    if (i.isMe(ln))
                    {
                        re.Add(i.Parse(ln));
                        break;
                    }
                }
            }

            return re;
        }
    }
}
