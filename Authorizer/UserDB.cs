using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Authorizer
{
    public class UserDB
    {
        /// <summary>
        /// lambda that retrieves the users from the stored file into a List
        /// </summary>
        /// <returns>a list of all stored users</returns>
        public static List<string> GetUSers =>
            System.IO.File.ReadAllText(Authorizer.UsersPath).Trim().Split('|').ToList();
        
        /// <summary>
        /// write a list of user strings back to the stored file (overwrite)
        /// </summary>
        /// <param name="users"></param>
        public void SaveUsers(List<string> users)
        {
            System.IO.File.WriteAllText(Authorizer.UsersPath, string.Join("|", users));
        }

        /// <summary>
        /// empty constructor for serialization
        /// </summary>
        public UserDB() { 
           
        }
    }
}
