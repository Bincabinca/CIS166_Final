using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public static class CommentStorage
    {
        private static Dictionary<int,List <String>> 
            commentsData = new Dictionary<int, List<string>>();

        public static void addComment(int ListingID, string comment)
        { 
            if(!commentsData.ContainsKey(ListingID))
            {
                commentsData[ListingID] = new List<string>();
            }
            commentsData[ListingID].Add(comment);
        }
        public static List<string> getComments(int ListingID)
        {
            if (commentsData.ContainsKey(ListingID))
            {
                return commentsData[ListingID];
            }
            return new List<string>(); // Return an empty list if no comments found for the ListingID
        }

    }
}
