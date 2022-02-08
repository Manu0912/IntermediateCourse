using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class CallWS : IWorkFlow
    {
        public string Description;

        public CallWS(string description)
        {
            Description = description;
        }

        public string Execute()
        {
            return Description;
        }
    }
}
