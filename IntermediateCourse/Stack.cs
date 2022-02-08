using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNamespace
{
    public class Stack
    {
        public List<object> List { get; set; }

        public Stack()
        {
            List = new();
        }

        public void Push(object Obj)
        {
            if (Obj != null)
            {
                List.Add(Obj);
            }
            else
            {
                throw new InvalidOperationException("The object cannot be null");
            }
        }

        public object Pop()
        {
            if (List.Count > 0)
            {
                var obj = List[List.Count - 1];
                List.Remove(obj);
                return obj;
            }
            else
            {
                throw new InvalidOperationException("The list cannot be null");
            }
        }

        public void Clear()
        {
            List.Clear();
        }
    }
}
