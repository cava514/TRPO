using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork1._2
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
