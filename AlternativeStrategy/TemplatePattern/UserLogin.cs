using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeStrategy.TemplatePattern
{
    public class UserLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public UserLogin(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
