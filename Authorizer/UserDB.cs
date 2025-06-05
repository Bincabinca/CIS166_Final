using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Authorizer
{
    public class UserDB
    {

        public UserDB() { 
           
        }

        public static List<List<string>> GetUsers()
        {
            var users = System.IO.File.ReadAllText(Authorizer.UsersPath).Trim().Split('|').ToList();

            List<List<string>> userinfo = new List<List<string>>();

            foreach (var user in users){
                
                List<string> userInfo = user.Split('\n').ToList();

            }
          
            return userinfo;
        }

  


    }
}
