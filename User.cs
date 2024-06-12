using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeyPOS
{
    class User
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }

        public User(string id, string name, string password)
        {
            Name = name;
            Id = id;
            Password = password;
        }
    }
}