﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskePOS
{
    internal class User
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }

        public User(string name, string id, string password)
        {
            Name = name;
            Id = id;
            Password = password;
        }
    }
}
