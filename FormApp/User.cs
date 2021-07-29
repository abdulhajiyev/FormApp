using System;

namespace FormApp
{
    public class User
    {
        public User(string firstName, string lastName, string username, string phone, DateTime dateTime, string gender, bool agreement)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Phone = phone;
            DateTime = dateTime;
            Gender = gender;
            Agreement = agreement;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public DateTime DateTime { get; set; }
        public string Gender { get; set; }
        public bool Agreement { get; set; }
    }
}
