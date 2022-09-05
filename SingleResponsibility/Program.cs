using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objmemberinfo = new MemberInfo();
            var member = new Member();

            objmemberinfo.MemberId = 1;
            objmemberinfo.MemberName = "Murali";
            objmemberinfo.MemberGroup = "Grp1";

            member.InsertMember(objmemberinfo);
            Console.WriteLine(objmemberinfo.MemberId);
            Console.WriteLine(objmemberinfo.MemberName);
            Console.WriteLine(objmemberinfo.MemberGroup);

            Console.ReadLine();
        }
    }
}
