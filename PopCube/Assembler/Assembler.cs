using Assembler.Assemblers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    public class Assembler
    {
        public void Assemble(string src, string outf)
        {
            var ast = Parser.Parse(src);
            var bcw = new ByteCodeWriter();
            AssembleAst(ast, ref bcw);
            bcw.WriteFile(outf);
        }

        public static List<iAssembler> AssemblerIndex = new List<iAssembler>()
        {
            new LoadAsm(),
            new AddAsm()
        };

        
        public static void AssembleAst(List<iAst> src, ref ByteCodeWriter bcw)
        {
            foreach(var i in src)
            {
                foreach(var g in AssemblerIndex)
                {
                    if (g.IsMe(i))
                    {
                        g.Assemble(i,ref bcw);
                        break;
                    }
                }
            }
        }
    }
}
