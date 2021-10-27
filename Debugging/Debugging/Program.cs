using System;
using System.Collections.Generic;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===============================================
            // ============== Debugging Basics ===============
            // ===============================================

            // This program returns the shortest names in the list of names.
            // The program will be changed to represent logical errors
            // For example, in GetPartyFriend method, changed < in if statement to >

            // Press F9 to use a breakpoint or click the vertical grey bar to the left of the row numbers

            // ===============================================
            // ============== Locals and Autos ===============
            // ===============================================

            // To view all breakpoints placed, go to Debug > Windows > Breakpoints
            // To use locals and autos, go to Debug > Windows > Locals or Debug > Windows > Autos
            // Locals: Shows us the variables around the context that we are currently in. (Variables in the scope that we are currently looking at).
            // Autos: Autos automatically show the variables around the current breakpoint.
            // Watch: (Found in Debug > Windows > Watch) Used to watch variables located in the current debugging scope.


            // ======================================================
            // == Debugging, Creating List Copies and Solving Bugs ==
            // ======================================================

            // Found out there was a logical bug in the GetPartyFriend function, in the name length comparison.
            // Created copy of friend list in order to not delete the friends in the friends list.

            // ======================================================
            // ======= Debugging Call Stack, Throwing   =============
            // ======= Errors And Defensive Programming =============            
            // ======================================================

            // Attempting to fix out of bounds exception when count is greater than the friend list length 
            // when we call the GetPartyFriends function.
            // Call stack: stack that shows which method called which and in which line.

            var friends = new List<string> { "Tom", "Frank", "Joe", "Michelle", "Andy", "Maria", "Tim", "Lance", "Mike", "Angelica", "Jose", "Thomas" };

            // Could catch the error here by not letting user input a value greater than the friends list length.
            var partyFriends = GetPartyFriends(friends, 13);

            foreach (var name in partyFriends)
                Console.WriteLine(name + " is invited.");
                
        }


        /// <summary>
        /// Returns a list of as many party friends with the shortest name as provided in the count variable.
        /// This method takes the friends list and the count of how many friends do you want returned.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            // Catching null list exception
            if (list == null)
                throw new ArgumentNullException("List should not be empty.");

            // Check if list the count is greater than List.Count or is less than or equal to 0.
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("Count passed cannot be greater than elements in the list.");

            // Copy of list.
            var buffer = new List<string>(list);
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }

        /// <summary>
        /// Returns the party friend with the shortest name.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                // < for shortest name. > for largest names.
                // Intentionally changing from < to >.
                if(list[i].Length < shortestName.Length)
                    shortestName = list[i];
            }
            return shortestName;
        }
    }
}
