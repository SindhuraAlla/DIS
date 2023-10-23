﻿/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System.Text;

namespace ISM6225_Fall_2023_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 1, 3, 50, 75 };
            int upper = 99, lower = 0;
            IList<IList<int>> missingRanges = FindMissingRanges(nums1, lower, upper);
            string result = ConvertIListToNestedList(missingRanges);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();

            //Question2:
            Console.WriteLine("Question 2");
            string parenthesis = "()[]{}";
            bool isValidParentheses = IsValid(parenthesis);
            Console.WriteLine(isValidParentheses);
            Console.WriteLine();
            Console.WriteLine();

            //Question 3:
            Console.WriteLine("Question 3");
            int[] prices_array = { 7, 1, 5, 3, 6, 4 };
            int max_profit = MaxProfit(prices_array);
            Console.WriteLine(max_profit);
            Console.WriteLine();
            Console.WriteLine();

            //Question 4:
            Console.WriteLine("Question 4");
            string s1 = "69";
            bool IsStrobogrammaticNumber = IsStrobogrammatic(s1);
            Console.WriteLine(IsStrobogrammaticNumber);
            Console.WriteLine();
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Question 5");
            int[] numbers = { 1, 2, 3, 1, 1, 3 };
            int noOfPairs = NumIdenticalPairs(numbers);
            Console.WriteLine(noOfPairs);
            Console.WriteLine();
            Console.WriteLine();

            //Question 6:
            Console.WriteLine("Question 6");
            int[] maximum_numbers = { 3, 2, 1 };
            int third_maximum_number = ThirdMax(maximum_numbers);
            Console.WriteLine(third_maximum_number);
            Console.WriteLine();
            Console.WriteLine();

            //Question 7:
            Console.WriteLine("Question 7:");
            string currentState = "++++";
            IList<string> combinations = GeneratePossibleNextMoves(currentState);
            string combinationsString = ConvertIListToArray(combinations);
            Console.WriteLine(combinationsString);
            Console.WriteLine();
            Console.WriteLine();

            //Question 8:
            Console.WriteLine("Question 8:");
            string longString = "leetcodeisacommunityforcoders";
            string longStringAfterVowels = RemoveVowels(longString);
            Console.WriteLine(longStringAfterVowels);
            Console.WriteLine();
            Console.WriteLine();
        }

        /*
        
        Question 1:
        You are given an inclusive range [lower, upper] and a sorted unique integer array nums, where all elements are within the inclusive range. A number x is considered missing if x is in the range [lower, upper] and x is not in nums. Return the shortest sorted list of ranges that exactly covers all the missing numbers. That is, no element of nums is included in any of the ranges, and each missing number is covered by one of the ranges.
        Example 1:
        Input: nums = [0,1,3,50,75], lower = 0, upper = 99
        Output: [[2,2],[4,49],[51,74],[76,99]]  
        Explanation: The ranges are:
        [2,2]
        [4,49]
        [51,74]
        [76,99]
        Example 2:
        Input: nums = [-1], lower = -1, upper = -1
        Output: []
        Explanation: There are no missing ranges since there are no missing numbers.

        Constraints:
        -109 <= lower <= upper <= 109
        0 <= nums.length <= 100
        lower <= nums[i] <= upper
        All the values of nums are unique.

        Time complexity: O(n), space complexity:O(1)
        */

        public static IList<IList<int>> FindMissingRanges(int[] nums, int lower, int upper)
        {
            try
            {
                var returnList = new List<IList<int>>();

                // If the input array 'nums' is empty, add a single range from 'lower' to 'upper'.
                if (nums.Length == 0)
                 {
                    returnList.Add(new List<int> { lower, upper });
                    return returnList;
        }

                // Initialize the start of the range to the lower bound.
                int start = lower;

                for (int i = 0; i < nums.Length; i++)
                {
                    // If there's a gap between 'start' and the current element in 'nums', add it as a range.
                if (start < nums[i])
                {
                    int end = nums[i] - 1;
                    returnList.Add(new List<int> { start, end });
            }
                // Update the start to the next possible number in the range.
                start = nums[i] + 1;
        }

                // If there's a gap between the last element in 'nums' and the upper bound, add it as a range.
                if (nums[nums.Length - 1] < upper)
                {
                    returnList.Add(new List<int> { nums[nums.Length - 1] + 1, upper });
        }

        return returnList;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums = { 0, 1, 3, 50, 75 };
        int lower = 0;
        int upper = 99;

        IList<IList<int>> missingRanges = solution.FindMissingRanges(nums, lower, upper);

        Console.WriteLine("Missing Ranges:");
        foreach (var range in missingRanges)
        {
            Console.WriteLine($"[{range[0]}, {range[1]}]");
        }
    }
}
    
                return new List<IList<int>>();
                catch (Exception)
            {
                throw;
            }

        

        /*
         
        Question 2

        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.An input string is valid if:
        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.
 
        Example 1:

        Input: s = "()"
        Output: true
        Example 2:

        Input: s = "()[]{}"
        Output: true
        Example 3:

        Input: s = "(]"
        Output: false

        Constraints:

        1 <= s.length <= 104
        s consists of parentheses only '()[]{}'.

        Time complexity:O(n^2), space complexity:O(1)
        */

        public static bool IsValid(string s)
        {
            try
            {
            
                // Keep removing pairs of matching brackets until no more can be removed.
                while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
                 {
                    s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        }

                // If the string is empty, all brackets are matched and valid. Otherwise, it's invalid.
                 return s.Length == 0;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        string input1 = "()";         // Valid
        string input2 = "()[]{}";     // Valid
        string input3 = "(]";         // Invalid
        string input4 = "([)]";       // Invalid
        string input5 = "{[]}";       // Valid

        // Test the 'IsValid' method on different input strings and print the results.
        Console.WriteLine($"Is '{input1}' valid? {solution.IsValid(input1)}");
        Console.WriteLine($"Is '{input2}' valid? {solution.IsValid(input2)}");
        Console.WriteLine($"Is '{input3}' valid? {solution.IsValid(input3)}");
        Console.WriteLine($"Is '{input4}' valid? {solution.IsValid(input4)}");
        Console.WriteLine($"Is '{input5}' valid? {solution.IsValid(input5)}");
    }

       
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*

        Question 3:
        You are given an array prices where prices[i] is the price of a given stock on the ith day.You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
        Example 1:
        Input: prices = [7,1,5,3,6,4]
        Output: 5
        Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

        Example 2:
        Input: prices = [7,6,4,3,1]
        Output: 0
        Explanation: In this case, no transactions are done and the max profit = 0.
 
        Constraints:
        1 <= prices.length <= 105
        0 <= prices[i] <= 104

        Time complexity: O(n), space complexity:O(1)
        */

        public static int MaxProfit(int[] prices)
        {
            try
            {
            
            int max = 0;         // Initialize the maximum profit to 0.
            int min = prices[0]; // Initialize the minimum price to the first element in the array.

                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] < min)
                    {
                        min = prices[i]; // Update the minimum price if a lower price is encountered.
                    }
                    else if ((prices[i] - min) > max)
                    {
                        max = prices[i] - min; // Update the maximum profit if a higher profit is found.
                    }
                }

                return max; // Return the maximum profit.
            }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        int maxProfit1 = solution.MaxProfit(prices1);
        Console.WriteLine("Maximum Profit 1: " + maxProfit1);

        int[] prices2 = { 7, 6, 4, 3, 1 };
        int maxProfit2 = solution.MaxProfit(prices2);
        Console.WriteLine("Maximum Profit 2: " + maxProfit2);

}
}|
            catch (Exception)
            {
                throw;
            }
        }

        /*
        
        Question 4:
        Given a string num which represents an integer, return true if num is a strobogrammatic number.A strobogrammatic number is a number that looks the same when rotated 180 degrees (looked at upside down).
        Example 1:

        Input: num = "69"
        Output: true
        Example 2:

        Input: num = "88"
        Output: true
        Example 3:

        Input: num = "962"
        Output: false

        Constraints:
        1 <= num.length <= 50
        num consists of only digits.
        num does not contain any leading zeros except for zero itself.

        Time complexity:O(n), space complexity:O(1)
        */

        public static bool IsStrobogrammatic(string s)
        {
            try
            {

                var sz = num.Length;
                var l = 0;
                var r = sz - 1;

             while (l <= r)
        {
            var cl = num[l];
            var cr = num[r];

            // Check for invalid digits at the middle of the number
            if (l == r && cl is not ('0' or '1' or '8'))
                return false;
            // Check for invalid digits at the beginning and end of the number
            else if (cr == cl && cl is not ('0' or '1' or '8'))
                return false;
            // Check for valid strobogrammatic pairs
            else if (cr != cl && ($"{cl}{cr}" is not "69" && $"{cl}{cr}" is not "96"))
                return false;

            l++;
            r--;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test cases
        string num1 = "69";
        Console.WriteLine($"Is {num1} strobogrammatic? {solution.IsStrobogrammatic(num1)}"); // Expected: true

        string num2 = "88";
        Console.WriteLine($"Is {num2} strobogrammatic? {solution.IsStrobogrammatic(num2)}"); // Expected: true

        string num3 = "962";
        Console.WriteLine($"Is {num3} strobogrammatic? {solution.IsStrobogrammatic(num3)}"); // Expected: false
    }
}catch (Exception)
            {
                throw;
            }
        

        /*

        Question 5:
        Given an array of integers nums, return the number of good pairs.A pair (i, j) is called good if nums[i] == nums[j] and i < j. 

        Example 1:

        Input: nums = [1,2,3,1,1,3]
        Output: 4
        Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
        Example 2:

        Input: nums = [1,1,1,1]
        Output: 6
        Explanation: Each pair in the array are good.
        Example 3:

        Input: nums = [1,2,3]
        Output: 0

        Constraints:

        1 <= nums.length <= 100
        1 <= nums[i] <= 100

        Time complexity:O(n), space complexity:O(n)

        */

        public static int NumIdenticalPairs(int[] nums)
        {
            try
            {
                             
                // Create a Dictionary to store the count of each unique integer.
                        Dictionary<int, int> count = new Dictionary<int, int>();
                        int result = 0; // Initialize the result to 0.

                        // Iterate through the 'nums' array.
                        foreach (int num in nums)
                        {
                            if (count.ContainsKey(num))
                            {
                                // If the number is already in the Dictionary, increment the result by the current count
                                // (as it represents the number of identical pairs with this number) and increment the count.
                                result += count[num];
                                count[num]++;
                            }
                            else
                            {
                                // If the number is not in the Dictionary, add it with a count of 1.
                                count[num] = 1;
                            }
                        }

                        return result; // Return the total number of identical pairs.
                    }

                    public static void Main(string[] args)
                    {
                        // Example usage:
                        int[] nums = { 1, 2, 3, 1, 1, 3 };
                        Solution solution = new Solution();
                        int numPairs = solution.NumIdenticalPairs(nums);
                        Console.WriteLine("Number of identical pairs: " + numPairs);
                    }
}catch (Exception)
            {
                throw;
            }
        

        /*
        Question 6

        Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

        Example 1:

        Input: nums = [3,2,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2.
        The third distinct maximum is 1.
        Example 2:

        Input: nums = [1,2]
        Output: 2
        Explanation:
        The first distinct maximum is 2.
        The second distinct maximum is 1.
        The third distinct maximum does not exist, so the maximum (2) is returned instead.
        Example 3:

        Input: nums = [2,2,3,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2 (both 2's are counted together since they have the same value).
        The third distinct maximum is 1.
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1

        Time complexity:O(nlogn), space complexity:O(n)
        */

        public static int ThirdMax(int[] nums)
        {
            try
            {
            // Create a HashSet to store unique numbers.
                    HashSet<int> set = new HashSet<int>();

                    foreach (int num in nums)
                    {
                        // Add the current number to the HashSet.
                        set.Add(num);

                        // If the size of the HashSet is greater than 3, remove the minimum element.
                        if (set.Count > 3)
                        {
                            set.Remove(set.Min());
                        }
                    }

                    // If the HashSet has fewer than 3 elements, return the maximum element. Otherwise, return the minimum.
                    if (set.Count < 3)
                    {
                        return set.Max();
                    }
                    else
                    {
                        return set.Min();
                    }
                }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums1 = { 3, 2, 1 };
        int result1 = solution.ThirdMax(nums1);
        Console.WriteLine("Third maximum: " + result1);  // Expected: 1

        int[] nums2 = { 1, 2 };
        int result2 = solution.ThirdMax(nums2);
        Console.WriteLine("Third maximum: " + result2);  // Expected: 2

        int[] nums3 = { 2, 2, 3, 1 };
        int result3 = solution.ThirdMax(nums3);
        Console.WriteLine("Third maximum: " + result3);  // Expected: 1
    }catch (Exception)
            {
                throw;
            }
        }

        /*
        
        Question 7:

        You are playing a Flip Game with your friend. You are given a string currentState that contains only '+' and '-'. You and your friend take turns to flip two consecutive "++" into "--". The game ends when a person can no longer make a move, and therefore the other person will be the winner.Return all possible states of the string currentState after one valid move. You may return the answer in any order. If there is no valid move, return an empty list [].
        Example 1:
        Input: currentState = "++++"
        Output: ["--++","+--+","++--"]
        Example 2:

        Input: currentState = "+"
        Output: []
 
        Constraints:
        1 <= currentState.length <= 500
        currentState[i] is either '+' or '-'.

        Timecomplexity:O(n), Space complexity:O(n)
        */

        public static IList<string> GeneratePossibleNextMoves(string currentState)
        {
            try
            {
                var list = new List<string>();
        var arr = currentState.ToCharArray(); // Convert the input string to a character array.

        // Iterate through the string up to the second-to-last character.
        for (int i = 0; i < currentState.Length - 1; i++)
        {
            // Check if two consecutive '+' characters are found.
            if (arr[i] == arr[i + 1] && arr[i] == '+')
            {
                // Generate a new string by replacing the two '+' characters with '-' characters.
                arr[i] = arr[i + 1] = '-';
                list.Add(new string(arr));

                // Reset the characters to their original '+' to explore other possibilities.
                arr[i] = arr[i + 1] = '+';
            }
        }

        return list; // Return the list of possible next moves.
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        string currentState1 = "++++";
        IList<string> moves1 = solution.GeneratePossibleNextMoves(currentState1);
        Console.WriteLine("Possible next moves 1:");
        foreach (string move in moves1)
        {
            Console.WriteLine(move);
        }

        string currentState2 = "+++--++";
        IList<string> moves2 = solution.GeneratePossibleNextMoves(currentState2);
        Console.WriteLine("Possible next moves 2:");
        foreach (string move in moves2)
        {
            Console.WriteLine(move);
        }
    }catch (Exception)
            {
                throw;
            }
        }

        /*

        Question 8:

        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:

        Input: s = "leetcodeisacommunityforcoders"
        Output: "ltcdscmmntyfrcdrs"

        Example 2:

        Input: s = "aeiou"
        Output: ""

        Timecomplexity:O(n), Space complexity:O(n)
        */

        public static string RemoveVowels(string s)
     
       {
        string ret = "";
        char[] vowels = {'a', 'e', 'i', 'o','u'};
        for (int i=0; i<s.Length; i++)
        {
            if (!vowels.Contains(s[i]))
            {
                ret = ret + s[i];
            }
        }
       
        return ret; 
            return "";
        }

        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<string> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "\"" + input[i] + "\""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}
