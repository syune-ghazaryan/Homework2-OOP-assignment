using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Guest: User
    {
       /// <summary>
       /// Create instance of Guest
       /// </summary>
       /// <param name="username">guest name</param>
        public Guest(string username): base(username,"","")
        {
        }
        /// <summary>
        /// Overrided method that give info about guest
        /// </summary>
        public override void getInfo()
        {
            Console.WriteLine("Username:{0}, User Type:Guest, Date:{1}", this.Username, DateTime.Now.ToString());
        }
    }
}
