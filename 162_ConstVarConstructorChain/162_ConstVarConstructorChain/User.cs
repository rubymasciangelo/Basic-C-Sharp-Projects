﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162_ConstVarConstructorChain
{
    public class User
    {
        public string Name;
        public int Age;

        public User()
        {

        }
        public User(string Name)
        {
            this.Name = Name;
        }
        //public User(string Name, int Age)
        public User(int Age)
        {
            //this.Name = Name;
            this.Age = Age;
        }
    }
}