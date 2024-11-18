using System.Reflection;

namespace RetunLengthArgumentsPassed.Problems
{//https://leetcode.com/problems/longest-common-prefix/description/
    public static class LongestCommonPrefix
    {
        readonly static string[] flArray = { "flower", "flow", "flight" };
        readonly static string[] emptyStringArray = { "dog", "racecar", "car" };
        public static void Run()
        {

            foreach (var f in flArray)
            {
                Console.Write(f + " ");
            }
            Console.Write("- ");
            Console.WriteLine(GetLongestCommonPrefix(flArray));

            foreach (var f in emptyStringArray)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
            Console.WriteLine(GetLongestCommonPrefix(emptyStringArray));


        }
        private static string GetLongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 1 || strs.Length > 200)
                throw new ArgumentException("Input value out of range");


            //add the chars of the first item to a result char list
            List<char> identicalChars = strs[0].ToList();
            //after the first object
            for (int i = 1; i < strs.Length; i++)
            {
                //iterate the current object char list compare each curent char location to the result char list
                char[] currentItemChars = strs[i].ToCharArray();

                for (int c = 0; c < currentItemChars.Length; c++)
                {
                    if (identicalChars.Count == 0) return "no common prefix";

                    if (identicalChars.Count > c && currentItemChars[c] != identicalChars[c])
                    {
                        identicalChars.RemoveRange(c, identicalChars.Count - c);
                        break;
                    }
                }
            }
            return new string(identicalChars.ToArray()) ?? "no common prefix";
        }
    }
}
