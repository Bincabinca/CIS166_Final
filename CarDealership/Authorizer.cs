using System.Collections.Generic;
using System.Linq;
using System;
using System.Runtime.CompilerServices;
using System.IO;


namespace CarDealership {
    public class  Authorizer {
        
        public const string UsersPath = @"..\..\DataFiles\UserDB.txt";
        private static Random rand = new Random();



        // Checks if the user is authorized by checking the password against the user database
        public static Dictionary<string,string> generateMap(string password) {

            // Generates a mapping of characters in the password to random uppercase letters
            Dictionary<string,string> output = new Dictionary<string,string>();

            foreach (char c in password)
            {
                output[c.ToString()] = ((char)rand.Next(65, 91)).ToString();
            }
            //List<string> charlist = password.ToCharArray();

            //foreach (string s in charlist ) {

            //    output.Add(s, ((char)rand.Next(65,91)).ToString());


            //}
            return output;
        }
      
       
        public static string GetKey(string input) {
            // Creates a monosub key mapping for the given input
            Dictionary<string, string> map = generateMap(input);
            string output = "";
            foreach (char c in input) {
                output += map[c.ToString()];
                
            
            }
            return output;
        }

        // Saves the key to a file, appending it if the file already exists
        public static void saveKey(string filepath,string key) {

            if (!File.Exists(filepath))
            {
                File.Create(filepath).Close();

            }
            else {
            
                System.IO.File.WriteAllText(filepath,key);
            }
        }


    }
        
    }

