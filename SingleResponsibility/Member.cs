using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Member
    {
        public MemberInfo InsertMember(MemberInfo memberInfo)
        {
			var objLogging = new Logging();
			try
			{
				var memberdetail = new MemberInfo();

				memberdetail.MemberId = Convert.ToInt32("@");
				memberdetail.MemberName= memberInfo.MemberName;
				memberdetail.MemberGroup = memberInfo.MemberGroup;

				
				return memberdetail;

			}
			catch (Exception ex)
			{

				objLogging.Handle(ex.Message);
                return null;
			}
        }

    }
}
