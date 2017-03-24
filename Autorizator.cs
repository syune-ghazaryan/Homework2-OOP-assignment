using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public  class Autorizator: ICommand
    {
       
       /// <summary>
       /// Check if user registered and give info about user 
       /// </summary>
       /// <param name="user">Usertype</param>
       /// <returns></returns>
       public  bool Accept(User user)
       {
           user.getInfo();
           return true;
       }
        /// <summary>
        /// Access deny
        /// </summary>
        /// <returns>false if access denied</returns>
        public bool Deny()
       {
           Console.WriteLine("Access denied");
           return false;
       }
        /// <summary>
        /// things that happened before user exit
        /// </summary>
        /// <returns></returns>
        public bool Exit()
        {
            string print =Console.ReadLine();
           
            while(String.Compare(print,"exit")!=0)
            {
                print = Console.ReadLine();
            }
            
            return true;
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>string of data(username, password , key)</returns>
       public string[] Print ()
       {
           string[] data = new string[3];
           Console.WriteLine();
           Console.WriteLine("PLEASE,LOG-IN! \n");
           Console.WriteLine("Username: ");
           string username = Console.ReadLine();
           data[0] = username;
           Console.WriteLine("Password: ");
           string password = Console.ReadLine();
           data[1] = password;
           Console.WriteLine("Key: ");
           string key = Console.ReadLine();
           data[2] = key;
           return data;
       }
        
       
       
    }
}
