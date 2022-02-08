using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class SendEmail : IWorkFlow
    {
        public string Description;

        public SendEmail(string description)
        {
            Description = description;
        }

        public string Execute()
        {
            return Description;
        }
    }
}
