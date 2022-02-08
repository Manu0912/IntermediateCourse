using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class WorkFlowEngine
    {
        public List<IWorkFlow> WorkFlow;

        public WorkFlowEngine()
        {
            WorkFlow = new List<IWorkFlow>();
        }

        public void addWork(IWorkFlow workFlow)
        {
            WorkFlow.Add(workFlow);
        }

        public void Run()
        {
            int i = 0;
            if(WorkFlow.Count > 0)
            {
                while (i < WorkFlow.Count)
                {
                    Console.WriteLine("Work is starting\n");
                    Console.WriteLine("Description: {0}", WorkFlow[i].Execute());
                    Console.WriteLine("\nWork completed\n");
                    i++;
                }
            }
            else
            {
                throw new Exception("The list cannot be empty");
            }
            
        }

    }
}
