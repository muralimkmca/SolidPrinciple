using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationprinciple
{
    public interface ISPMessage
    {
        bool Send(string ToAddress, string MessageBody);
    }

    public interface IEmailMsg : ISPMessage
    {
        string Subject { get; set; }

        string BCCAddress { get; set; }
    }

    public class smtpmsg : IEmailMsg
    {
        public string Subject { get; set; }
        public string BCCAddress { get; set; }

        public bool Send(string ToAddress, string MessageBody)
        {
            // mail send logic
            return true;
        }
    }


    public class smsmsg : ISPMessage
    {
        public bool Send(string ToAddress, string MessageBody)
        {
            //sms send logic

            return true;
        }
    }

}
