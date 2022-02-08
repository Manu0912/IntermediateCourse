using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    internal class Upload : IWorkFlow
    {
        public string Description;

        public Upload(string description)
        {
            Description = description;
        }

        public string Execute()
        {
            return Description;
        }
    }
}
