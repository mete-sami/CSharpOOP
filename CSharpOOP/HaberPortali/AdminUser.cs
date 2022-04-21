using CSharpOOP.BlogSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.HaberPortali
{
    public class AdminUser : BaseModel2
    {
        string email = "";
        public string EMail
        {
            get
            {
                return email.ToLower();
            }
            set
            {
                email = value;
            }
        }
        string password = "";
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = BlogHelper.CreateMD5(value);
            }
        }
    }
}
