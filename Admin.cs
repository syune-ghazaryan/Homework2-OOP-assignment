using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    class Admin: User
    {
       
       /// <summary>
       /// Create new instance of admin
       /// </summary>
       /// <param name="username">admin name</param>
       /// <param name="password">admin password</param>
       /// <param name="key">admin key</param>
        public Admin(string username, string password, string key):base(username,password,key)
        {
           
        }
        /// <summary>
        /// overrided methot hat give info about admin
        /// </summary>
        public override void getInfo()
        {
            Console.WriteLine("Username:{0}, User Type:Admin, Date:{1}", this.Username, DateTime.Now.ToString());
        }
        
    }
}
