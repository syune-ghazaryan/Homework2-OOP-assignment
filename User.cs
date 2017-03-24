using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    /// <summary>
    /// Class to define user
    /// </summary>
     public abstract  class User
     { 
         /// <summary>
         /// User username for access
         /// </summary>
         public string Username { get; private set; }
         //public string Password { get; private set; }
         /// <summary>
         /// User password for access
         /// </summary>
         public string Password { get; private set; }
         /// <summary>
         /// User key for access
         /// </summary>
         public string Key {get; private set; }
        
         /// <summary>
         /// Create new instance of User
         /// </summary>
         /// <param name="username">Username</param>
         /// <param name="password">Password</param>
         /// <param name="key">Key</param>
         protected User(string username,string password, string key)
         {
             this.Username = username;
             this.Password = password;
             this.Key = key;
         }
         /// <summary>
         /// Method that give information about user
         /// 
         /// </summary>
         public abstract void getInfo();
     
        
      
    }
}
