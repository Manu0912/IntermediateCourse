using IntermediateCourse;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WorkFlowEngine workFlowEngine = new WorkFlowEngine();

            Upload upload = new("Upload a video to a cloud storage.");
            CallWS callWS = new("Send an email to the owner of the video notifying them that the video started processing.");
            SendEmail sendEmail = new("Send an email to the owner of the video notifying them that the video started processing.");
            ChangeStatus changeStatus = new("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.");

            workFlowEngine.addWork(upload);
            workFlowEngine.addWork(callWS);
            workFlowEngine.addWork(sendEmail);
            workFlowEngine.addWork(changeStatus);

            workFlowEngine.Run();
        }
    }
}
