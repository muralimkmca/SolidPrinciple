using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationprinciple
{
    public interface IMessage
    {
        string ToAddress { get; set; }

        string BccAddress { get; set; }

        string MessageBody { get; set; }

        string Subject { get; set; }

        bool send();
    }

    public class smtpmessage : IMessage
    {
        public string ToAddress { get; set; }
        public string BccAddress { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }

        public bool send()
        {
            //Write logic for send the mail
            return true;
        }
    }


    public class smsmessage : IMessage
    {
        public string ToAddress { get; set; }
        public string BccAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MessageBody { get; set; }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool send()
        {
            //send the sms logic
            return true;
        }
    }
}
