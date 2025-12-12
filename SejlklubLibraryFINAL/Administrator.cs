using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class Administrator : Member
    {
        public Administrator(string name, int age, string email, int id, string password, int phoneNumber) : base(name, age, email, id, password, phoneNumber)
        {
        }

        public void CreateMember(MemberRepository repo, Member member)
        {
            repo.Add(member);
        }

        public void EditMember(MemberRepository repo, Member member)
        {
            repo.Update(member);
        }

        public void DeleteMember(MemberRepository repo, int id)
        {
            repo.Delete(id);
        }
    }
}
