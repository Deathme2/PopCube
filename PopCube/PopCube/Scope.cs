using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCube
{
    public class Scope
    {
        public Stack<object> Stack { get; set; } = new Stack<object>();
        private Stack<Type> TypeStack { get; set; } = new Stack<Type>();

        public void Push(object obj)
        {
            Stack.Push(obj);
            TypeStack.Push(obj.GetType());
        }

        public Type TypePop()
        {
            return TypeStack.Pop();
        }

        public object Pop()
        {
            return Stack.Pop();
        }
    }
}
