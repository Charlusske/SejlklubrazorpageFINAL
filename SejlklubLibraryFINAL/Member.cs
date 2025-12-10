using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class Member
    {
        // Instance fields
        private string _name;
        private string _email;
        private int _id;
        private string _password;
        private int _phoneNumber;

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        // Constructor
        public Member(string name, string email, int id, string password, int phoneNumber)
        {
            _name = name;
            Email = email;
            _id = id;
            _password = password;
            _phoneNumber = phoneNumber;
        }

        // Methods
        public Member UpdateInfo(string name, string email, string password, int id, int phoneNumber)
        {
            _name = name;
            _email = email;
            _password = password;
            _phoneNumber = phoneNumber;
            _id = id;

            return this;

        }

        public override string ToString()
        {
            return $"Member ID: {_id}, Name: {_name}, Email: {_email}, Phone Number: {_phoneNumber}";
        }

    }
}

