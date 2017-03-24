using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    class Program
    {
       
        
        static void  Main(string[] args)
        {
                //List of registered users
                List<User> users = new List<User>() { new Admin("aaa","aa","a"), new Editor("bbb","bb") , new Guest("ccc"), 
                new Guest("ddd"), new Admin("eee","ee","e"), new Editor("fff","ff") };

                Autorizator autorizator = new Autorizator();//creating new autorizator
                bool exit = false;//indicate if new autorization should be done

                //
                while(!exit)
                {
                    string[] data = autorizator.Print();//print simple instruction for autorization
                    //Checking if necessarry field are filled  and deny access if they aren't filled
                    if ((String.IsNullOrEmpty(data[0]) && String.IsNullOrEmpty(data[1]) && String.IsNullOrEmpty(data[2])) || String.IsNullOrEmpty(data[0]))
                    {
                        
                        autorizator.Deny();
                        exit = false;
                    }
                    else
                    {
                        //checking if password and key are input if aren't checkin if there any guest in registered users list
                        if (String.IsNullOrEmpty(data[1]) && String.IsNullOrEmpty(data[2]) )
                        {
                           
                            for (int i = 0; i < users.Count; i++)
                            {
                                if (data[0] == users[i].Username)
                                {
                                    User guest = new Guest(data[0]);// creat new guest and initialize username field
                                    autorizator.Accept(guest);//accept guest
                                    autorizator.Exit();//let user print something before he print "exit"
                                    exit = false;
                                    break;

                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            //checking if there any edior in users list
                            if (String.IsNullOrEmpty(data[2]))
                            {
                                for (int i = 0; i < users.Count; i++)
                                {
                                    if (data[0] == users[i].Username && data[1] ==users[i].Password )
                                    {
                                        User editor = new Editor(data[0], data[1]);
                                        autorizator.Accept(editor);
                                        autorizator.Exit();
                                        exit = false;
                                        break;

                                    }
                                    else
                                    {
                                        continue;
                                    }

                                }
                              
                            }
                            //ceckin is there any admin in userlist
                            else
                            {
                                for (int i = 0; i < users.Count; i++)
                                {
                                    if (data[0] == users[i].Username && data[1] == users[i].Password && data[2] == users[i].Key)
                                    {
                                        User admin = new Admin(data[0], data[1],data[2]);
                                        autorizator.Accept(admin);
                                        autorizator.Exit();
                                        exit = false;
                                        break;

                                    }
                                    else
                                    {
                                        continue;
                                    }

                                }
                            }
                        }
                    }
                }
        }
    }
}
