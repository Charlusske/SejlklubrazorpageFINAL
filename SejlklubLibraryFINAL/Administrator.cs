using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class Administrator : Member
    {
        #region constructors
        public Administrator(string name, string email, int id, string password, int phoneNumber) : base(name, email, id, password, phoneNumber)
        {
        }
        #endregion

        #region Methods
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
        #endregion
    }

}
