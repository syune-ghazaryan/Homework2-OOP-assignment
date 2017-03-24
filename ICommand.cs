using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    interface ICommand
    {
        /// <summary>
        /// Interface to define ability to exit
        /// </summary>
        /// <returns></returns>
         bool Exit();
        /// <summary>
        /// interfac to define ability of printing
        /// </summary>
        /// <returns></returns>
         string[] Print();
    }
}
