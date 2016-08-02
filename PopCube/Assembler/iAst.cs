using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    public abstract class iAst
    {
        public abstract bool isMe(string raw);
        public abstract iAst Parse(string raw);
    }
}
