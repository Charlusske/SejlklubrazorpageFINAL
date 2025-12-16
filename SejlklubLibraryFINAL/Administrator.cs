using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class Administrator : Member
    {
        #region Constructor
        public Administrator(string name, int age, string email, int id, string password, int phoneNumber) : base(name, age, email, id, password, phoneNumber)
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

        public void EditBoat(
        Boat boat,
        string boatType,
        string model,
        string motor,
        double length,
        double width,
        double depth,
        int buildYear,
        string name,
        string boatNumber)
        {
            boat.BoatType = boatType;
            boat.Model = model;
            boat.Motor = motor;
            boat.Length = length;
            boat.Width = width;
            boat.Depth = depth;
            boat.BuildYear = buildYear;
            boat.Name = name;
            boat.BoatNumber = boatNumber;
        }
        #endregion
    }

}
