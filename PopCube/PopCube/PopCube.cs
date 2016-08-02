using Assembler;
using Newtonsoft.Json;
using PopCube.Exes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCube
{
    public class PopCube
    {
        public static List<IExe> ExeIndex { get; set; } = new List<IExe>()
        {
            new LoadI8(),
            new LoadString(),
            new Add()
        };

        public Scope Scope = new Scope();

        public void SaveState(string fl)
        {
            File.WriteAllText(fl, JsonConvert.SerializeObject(Scope, Formatting.Indented));
        }

        public void LoadState(string fl)
        {
            Scope = JsonConvert.DeserializeObject<Scope>(File.ReadAllText(fl));
        }

        public void Execute(byte[] b)
        {
            var bcs = new ByteCodeStream(b);

            bool execute = true;
            while (execute)
            {
                var id = bcs.ReadByte();
                var mesa = ExeIndex.Where((x) => { return x.ID == id; }).First();
                mesa.Execute(mesa.ReadParameter(ref bcs), ref Scope);

                if(b.Length <= bcs._offset)
                {
                    execute = false;
                    break;
                }
            }
        }
    }
}
