using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repository
{
    internal interface IMemberRepository
    {
        Task<MemberObject> GetMemberById(int memberId);
        Task<IEnumerable<MemberObject>> GetMembers();
        Task<MemberObject> SaveMember(MemberObject member);
        Task DeleteMember(int memberId);
    }
}
