using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarDealership.DatabaseFiles {
    public class CommentsDB {

        public const string Path = @"..\..\DataFiles\ListingComments.txt";

        public static Dictionary<string, List<string>> LoadComments() {
            var result = new Dictionary<string, List<string>>();
            var comments = System.IO.File.ReadAllText(Path).Split('=');
            foreach (var comment in comments) {
                var parts = comment.Split('|');
                string listingId = parts[0].Trim();
                if (!result.ContainsKey(listingId)) {
                    result[listingId] = new List<string>();
                }
                foreach (var part in parts) {
                    string commentText = part.Trim();
                    if (!string.IsNullOrEmpty(commentText)) {
                        result[listingId].Add(commentText);
                    }
                }
            }
            return result;
        }

        public static void SaveComments(Dictionary<string, List<string>> comments) {

            string saveString = "";
            string listingAppend = "";
            string commentsAppend = "";

            foreach (var key in comments) {
                listingAppend += key.Key;
                foreach (var comment in key.Value) {
                    commentsAppend += comment+ "|";
                }
                saveString += listingAppend +"|" + commentsAppend + "=";
            }
            System.IO.File.WriteAllText(Path, saveString);

        }

    }
}
