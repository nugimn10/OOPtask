using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOOP
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}