//https://leetcode.com/problems/roman-to-integer/description/
namespace RetunLengthArgumentsPassed.Problems
{
    public static class RomanToInteger
    {
        private static readonly char[] subtractionLetterCheck = { Letters.I, Letters.X, Letters.C };

        public static void Run()
        {
            RomanToInt("III");
            RomanToInt("LVIII");
            RomanToInt("MCMXCIV");
        }
        private static int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s)) throw new ArgumentNullException("s");
            //int result
            int result = 0;
            //expand string to char array
            char[] letters = s.ToCharArray();

            //iterate each char in the array
            for (int i = 0; i < letters.Length; i++)
            {
                if (subtractionLetterCheck.Contains(letters[i]) && i < letters.Length - 1)
                {
                    bool isSubtraction = IsSubtraction(letters[i], letters[i + 1]);
                    //if current char return true for the isSubtraction method
                    if (isSubtraction)
                    {
                        //subtract  getIntByLetter(current) from getIntByLetter(current + next item in array) and update the result
                        result += GetIntByLetter(letters[i + 1]) - GetIntByLetter(letters[i]);
                        //skip next char in line
                        i += 1;
                    }
                    else
                    {
                        result += GetIntByLetter(letters[i]);
                    }
                }
                else
                {
                    // add current i to result
                    result += GetIntByLetter(letters[i]);
                }
            }
            Console.WriteLine($"input string {s}, output number: {result}");
            return result;
        }

        private static bool IsSubtraction(char first, char second)
        {
            if (first == Letters.I && second == Letters.V || first == Letters.I && second == Letters.X)
                return true;

            if (first == Letters.X && second == Letters.L || first == Letters.X && second == Letters.C)
                return true;

            if (first == Letters.C && second == Letters.D || first == Letters.C && second == Letters.M)
                return true;

            return false;
        }

        private static int GetIntByLetter(char c)
        {
            return c switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new ArgumentException("Invalid Character submitted. Roman Characters allowed are: I, V, X, L, C, D, M")
            };
        }
    }
    static class Letters
    {
        public const char I = 'I';
        public const char V = 'V';
        public const char X = 'X';
        public const char L = 'L';
        public const char C = 'C';
        public const char D = 'D';
        public const char M = 'M';
    }
}
