using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162_ConstVarConstructorChain
{
    public class User
    {
        public string Name;
        public int Phone;

        public User() //mosh tutorial advised including default constructor so that I do not have to add default parameters
        {
        }
        public User(string userName)
        {
            this.Name = userName;
        }
        public User(string userName, int userPhone)
            : this(userName) //passes name constructor in so it calls the name constructor first
        {
            this.Phone = userPhone;
        }
    }
}
