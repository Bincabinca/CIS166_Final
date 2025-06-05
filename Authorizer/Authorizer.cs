using System.Collections.Generic;
using System.Linq;
using System;








namespace Authorizer {
    public class  Authorizer {
        
        private const string UsersPath = @"..\..\DataFiles\UserDB.txt";



        //private Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();
        //private Dictionary<char, int> passwordMappings = new Dictionary<char,int>();
        Random rand = new Random();
        
     

        public static void saveUser(string username) { 
        
        
        }
      
        //private List<int> encryptPassword(string password) {
        //    // Encrypts the password using a simple mapping
        //    List<int> encryptedPass = new List<int>();
        //    foreach (char c in password) {

        //        if (passwordMappings.ContainsKey(c)) {

        //            encryptedPass.Add(passwordMappings[c]);
        //        } else {
        //            int newValue = rand.Next(1,25); // Random value for simplicity
        //            passwordMappings[c] = newValue;
        //            encryptedPass.Add(newValue);
        //        }
        //    }
        //    return encryptedPass;
        //}

        public static string GetKey(string input) {
            // Creates a monosub key mapping for the given input
            return "placeholder";
        }
    }
        
    }

