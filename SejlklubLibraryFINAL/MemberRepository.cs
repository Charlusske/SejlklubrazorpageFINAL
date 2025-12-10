using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class MemberRepository
    {
        private List<Member> _members;

        // Constructor
        public MemberRepository()
        {
            _members = new List<Member>();
        }

        // Add a new member
        public void Add(Member member)
        {
            _members.Add(member);
        }

        // Get a member by ID
        public Member GetById(int id)
        {
            foreach (Member member in _members)
            {
                if (member.Id == id)
                {
                    return member;
                }
            }

            return null;
        }

        // Get all members
        public List<Member> GetAll()
        {
            return _members;
        }

        //  Update member
        public Member Update(Member member)
        {
            var existing = GetById(member.Id);
            if (existing != null)
            {
                existing.UpdateInfo(member.Name, member.Email, member.Password, member.Id, member.PhoneNumber);
            }
            return existing;
        }

        // Delete member
        public bool Delete(int id)
        {
            var member = GetById(id);
            if (member != null)
            {
                _members.Remove(member);
                return true;
            }
            return false;
        }

        // Search for members by name
        public List<Member> SearchByName(string name)
        {
            List<Member> result = new List<Member>();

            foreach (Member member in _members)
            {
                if (member.Name.ToLower().Contains(name.ToLower()))
                {
                    result.Add(member);
                }
            }

            return result;
        }

    }
}
