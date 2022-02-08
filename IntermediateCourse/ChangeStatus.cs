using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class ChangeStatus : IWorkFlow
    {
        public string Description;

        public ChangeStatus(string description)
        {
            Description = description;
        }

        public string Execute()
        {
            return Description;
        }
    }
}
