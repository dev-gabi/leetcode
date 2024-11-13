namespace RetunLengthArgumentsPassed.Problems
{//https://leetcode.com/problems/longest-common-prefix/description/
    public static class LongestCommonPrefix
    {
        readonly static string[] flArray = { "flower", "flow", "flight" };
        readonly static string[] emptyStringArray = { "dog", "racecar", "car" };
        public static void Run()
        {

            Console.WriteLine(flArray);
            LongestCommonPrefix(flArray);
            Console.WriteLine(LongestCommonPrefix(flArray));

            Console.WriteLine(emptyStringArray);
            Console.WriteLine(LongestCommonPrefix(emptyStringArray));


        }
        private static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 1 || strs.Length > 200)
                throw new ArgumentException("Input value out of range");

            //iterate strs

            //create char array from the string

            //add the chars of the first item to a result char list

            //after the first object
            //iterate the current object char list compare each curent char location to the result char list

            //if not equale delete the result char list from the current location 

        }
    }
}
