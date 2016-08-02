using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler.Ast
{
    public class PushStmt : iAst
    {
        public string RawValue { get; set; }
        public string Type { get; set; }

        public override bool isMe(string raw) => raw.ToLower().StartsWith("push");

        public override iAst Parse(string raw)
        {
            var re = new PushStmt();

            var s = raw.Remove(0, 5).Trim();
            //"str : ing" : str

            if (s.Contains("\""))
            {
                bool flag = false;
                bool flag1 = false;
                string tmp = "";

                for (int i = 0; i < s.Length; i++)
                {
                    var ichar = s[i];
                    if (ichar == '"')
                    {
                        flag = !flag;
                        if (!flag)
                        {
                            re.RawValue = tmp.Trim().Remove(0, 1);
                            tmp = "";
                        }
                    }

                    if(flag)
                    {
                        tmp += ichar;                        
                    }
                    else
                    {
                        if(ichar == ':')
                        {
                            flag1 = true;
                        }
                        else
                        {
                            if(flag1)
                            {
                                tmp += ichar;
                            }
                        }
                    }
                }
                if (flag1)
                {
                    re.Type = tmp.Trim();
                }

            }
            else
            {
                var s1 = s.Split(':');
                re.RawValue = s1[0].Trim();
                re.Type = s1[1].Trim();
            }

            return re;
        }
    }
}
