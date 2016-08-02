using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    public class ByteCodeWriter
    {
        private ByteCodeStream _bs = new ByteCodeStream();

        public void LoadString(string s)
        {
            _bs.WriteByte(16);
            _bs.WriteUInt32(Encoding.ASCII.GetByteCount(s));
            foreach(var i in Encoding.ASCII.GetBytes(s))
            {
                _bs.WriteByte(i);
            }
        }

        public void LoadI8(sbyte i)
        {
            _bs.WriteByte(17);
            _bs.WriteSByte(i);
        }

        public void LoadI32(int i)
        {
            _bs.WriteByte(19);
            _bs.WriteInt(i);
        }

        public void Add()
        {
            _bs.WriteByte(4);
        }

        public void WriteFile(string s)
        {
            File.WriteAllBytes(s, _bs._buffer.ToArray());
        }
    }
}
