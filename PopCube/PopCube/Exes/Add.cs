using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembler;

namespace PopCube.Exes
{
    public class Add : IExe
    {
        public Add()
        {
            ID = 4;
        }

        public override void Execute(object Pramater, ref Scope s)
        {
            var a = s.Pop();
            var tpa = s.TypePop();
            var b = s.Pop();
            var tpb = s.TypePop();

            /* cehack tipe compatibility
             * for eg, int and a float is not compaible
             *  */

            if(tpa == typeof(byte))
            {
                s.Push((byte) a + (byte)b);
            }
            else if (tpa == typeof(short))
            {
                s.Push((short)a + (short)b);
            }
            else if (tpa == typeof(int))
            {
                s.Push((short)a + (short)b);
            }
        }

        public override object ReadParameter(ref ByteCodeStream bcs)
        {
            return "";
        }
    }
}
