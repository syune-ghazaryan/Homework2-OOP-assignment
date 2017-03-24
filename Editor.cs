using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    class Editor:User
    {
       
       /// <summary>
       /// Create instance of Editor
       /// </summary>
       /// <param name="username">editor username</param>
       /// <param name="password">editor password</param>
        public Editor(string username,string password) : base(username,password,"")
        {
          
        }
        /// <summary>
        /// overrided method to get info about this type of user(name,user type, when he logged-in, )
        /// </summary>
        public override void getInfo()
        {
            Console.WriteLine("Username:{0}, User Type:Editor, Date:{1}", this.Username, DateTime.Now.ToString());
        }

    }
}
