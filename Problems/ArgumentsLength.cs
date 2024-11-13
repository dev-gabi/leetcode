using System.Text.Json.Nodes;

//https://leetcode.com/problems/return-length-of-arguments-passed/description/
namespace RetunLengthArgumentsPassed.Problems
{
    public static class ArgumentsLength
    {
        public static void Run()
        {
            JsonArray jsonArray = new JsonArray();

            jsonArray.Add(1);
            jsonArray.Add(null);
            jsonArray.Add("Item3");

            Console.WriteLine($"Json array: {jsonArray}. Arguments Length: {GetArgumentsLength(jsonArray)}");

            JsonArray jsonArray2 = new JsonArray();
            jsonArray2.Add("Item1");

            Console.WriteLine($"Json array: {jsonArray2}. Arguments Length: {GetArgumentsLength(jsonArray2)}");

        }

        /* 
        input:args = [5]
        output: 1
        One value was passed to the function so it should return 1.

        Input: args = [{}, null, "3"]
        Output: 3
        Explanation: 
        argumentsLength({ }, null, "3"); // 3
        
        Constraints:
        args is a valid JSON array
        0 <= args.length <= 100    
      */
        public static int GetArgumentsLength(JsonArray args)
        {
            return args.Count;
        }
    }
}
