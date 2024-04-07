/* 

YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINIDTION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System.Text;

namespace ISM6225_Spring_2024_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            //Question 3:
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            //Question 4:
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            //Question 5:
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            //Question 6:
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            //Question 7:
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            //Question 8:
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
        }

        /*
        
        Question 1:
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
 

        Constraints:

        1 <= nums.length <= 3 * 104
        -100 <= nums[i] <= 100
        nums is sorted in non-decreasing order.
        */

        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                if (nums.Length == 0) 
                    return 0; // If the array is empty, there are no duplicates

                int k = 1; // Initializing the variable to 1 
                for (int i = 1; i < nums.Length; i++)
                {
                    // If the current element is different from the previous one
                    if (nums[i] != nums[i - 1])
                    {
                        nums[k] = nums[i];  // Copy the current element to the position k
                        k++;
                    }
                }

                return k;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         The above code easily eliminates duplicates from a numeric array that has been sorted in-place while maintaining the element's relative order. 
         Every time an element in the array is compared to its predecessor, iterating over the array and updating it in-place with the unique element if necessary. 
         Nevertheless, since the try-catch block only rethrows the captured exception. Eliminating this try-catch block would result in a clearer, more effective code. 
         To make the code easier to read and maintain, more descriptive variable names would also be beneficial. 
         Although the method addresses the problem effectively overall, a few minor adjustments could make it more understandable.
        */

        /*
        
        Question 2:
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]
 
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        */

        public static IList<int> MoveZeroes(int[] nums)
        {
            try
                {
                    if (nums == null || nums.Length == 0)
                        return new List<int>(); // Return an empty list

                    int nonZeroIndex = 0; // index to track the position for non-zero element

                    // Iterate through the array
                    for (int i = 0; i < nums.Length; i++)
                    {
                        // If the current element is not zero,move it to the position pointed by nonZeroindex                        if (nums[i] != 0)
                        {
                            nums[nonZeroIndex] = nums[i];
                            nonZeroIndex++;
                        }
                    }
                    // Fill the remaining positions with zeros
                    while (nonZeroIndex < nums.Length)
                    {
                        nums[nonZeroIndex] = 0;
                        nonZeroIndex++;
                    }
                    // Convert the modified array to a list and return
                    return nums.ToList();
                }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         The above code preserves the relative order of the non-zero members while successfully moving all zeros to the end of the integer array. 
         It uses a two-pointer method, where one iterates across the array and the other tracks the position of any non-zero elements.
         When an array is empty or null input occurs, the code responds accordingly. 
         There is room for improvement, though. First, contrary to what the method signature states, the code returns a List<int> rather than an IList<int>, which can cause compatibility problems.
         Second, the code might be made more streamlined by removing the needless try-catch block, just like in the previous example. Variable names with greater descriptiveness would also improve readability.
         Overall, the method solves the task successfully, although there are a few little improvements that could benefit from minor enhancements to improve clarity and maintainability.
         */
        /*

        Question 3:
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

 

        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
 

        Constraints:

        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105

        */

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                List<IList<int>> result = new List<IList<int>>(); // List to store triplets
                Array.Sort(nums); // Sort the input array
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    // Skip duplicates or process first element
                    if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                    {
                        int low = i + 1, high = nums.Length - 1, sum = 0 - nums[i];

                        // Two pointers approach
                        while (low < high)
                        {
                            if (nums[low] + nums[high] == sum)
                            {
                                // Add the triplet to the result list
                                result.Add(new List<int> { nums[i], nums[low], nums[high] });

                                // Skip duplicates
                                while (low < high && nums[low] == nums[low + 1]) low++;
                                while (low < high && nums[high] == nums[high - 1]) high--;

                                // Move pointers
                                low++;
                                high--;
                            }
                            else if (nums[low] + nums[high] < sum) low++;
                            else high--;
                        }
                    }
                }
                return result; // Return the list of triplets
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         In the given integer array, the provided code effectively discovers all unique triplets that total up to zero. It achieves an O(n^2) time complexity by using a two-pointer technique within a sorted array, where n is the array's length. 
         When an array has fewer than three members or the input is empty, the code manages edge cases appropriately. 
         Additionally, by eliminating identical parts during the iteration step, duplicate triplets are avoided. 
         Variable names with greater descriptiveness may also be easier to read and manage. 
         Though little changes could further improve the algorithm's clarity and conciseness, overall it addresses the problem and offers an efficient answer.
        */
        /*

        Question 4:
        Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:

        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
        Example 2:

        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:

        1 <= nums.length <= 105
        nums[i] is either 0 or 1.

        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                // Initializing variables maximum consecutive ones and current consecutive ones
                int maxCon = 0;
                int currentCon = 0;

                // Iterate through the array
                foreach (int num in nums)
                {
                    // If the current number is 1
                    if (num == 1)
                    {
                        currentCon++; // Increment
                        maxCon = Math.Max(maxCon, currentCon); // Update the maximum consecutive
                    }
                    else
                    {
                        // If the current number is 0
                        currentCon = 0;
                    }
                }
                return maxCon; // return the count of current consecutive ones
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         The code that is provided effectively determines the binary array's maximum number of consecutive 1s.
         It uses a straightforward iterative method, increasing a counter for each consecutive 1 and changing the maximum count each time a 0 appears. 
         This approach is ideal for this problem because it has an O(n) time complexity, where n is the length of the input array. Effectively, the algorithm manages edge circumstances like an array that is empty or contains no 1s. 
         The readability may also be improved by using variable names that are more descriptive.
         All things considered, the code offers a clear-cut and effective answer to the issue.
        */
        /*

        Question 5:
        You are tasked with writing a program that converts a binary number to its equivalent decimal representation without using bitwise operators or the `Math.Pow` function. You will implement a function called `BinaryToDecimal` which takes an integer representing a binary number as input and returns its decimal equivalent. 

        Requirements:
        1. Your program should prompt the user to input a binary number as an integer. 
        2. Implement the `BinaryToDecimal` function, which takes the binary number as input and returns its decimal equivalent. 
        3. Avoid using bitwise operators (`<<`, `>>`, `&`, `|`, `^`) and the `Math.Pow` function for any calculations. 
        4. Use only basic arithmetic operations such as addition, subtraction, multiplication, and division. 
        5. Ensure the program displays the input binary number and its corresponding decimal value.

        Example 1:
        Input: num = 101010
        Output: 42


        Constraints:

        1 <= num <= 10^9

        */

        public static int BinaryToDecimal(int binary)
        { 
            try
            {
                int deci = 0; // Variable to store the decimal
                int baseValue = 1; // Initialize the base value for binary

                // Iterate until the binary number is greater than 0
                while (binary > 0)
                {
                    // Extract the last digit of the binary number
                    int lastDigit = binary % 10;

                    // Remove the last digit from the binary number
                    binary = binary / 10;
                    deci += lastDigit * baseValue; // Multiply the last digit by the base value and add it to the decimal number
                    baseValue *= 2;  // Update the base value for the next iteration
                }
                return deci;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         The given code effectively uses the function and bitwise operators to translate a binary number to its corresponding decimal form.
         It uses a simple iterative method, going digit by digit through the binary number, extracting the last digit, and multiplying it by a suitable power of two to get the decimal value. 
         Input validation and error handling are examples of edge situations that the code handles correctly.
         There is room for improvement, though. Firstly, in order to improve readability and maintainability, the variable names may be more specific.
         Overall, the algorithm provides a clear and efficient solution to the problem.
        */

        /*

        Question:6
        Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
        You must write an algorithm that runs in linear time and uses linear extra space.

        Example 1:

        Input: nums = [3,6,9,1]
        Output: 3
        Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
        Example 2:

        Input: nums = [10]
        Output: 0
        Explanation: The array contains less than 2 elements, therefore return 0.
 

        Constraints:

        1 <= nums.length <= 105
        0 <= nums[i] <= 109

        */

        public static int MaximumGap(int[] nums)
        {
            try
            {
                     if (nums.Length < 2)
                        return 0;

                    // Find the minimum and maximum elements in the array
                    int min = int.MaxValue;
                    int max = int.MinValue;

                    foreach (int n in nums)
                    {
                        min = Math.Min(min, n);
                        max = Math.Max(max, n);
                    }

                    // Calculate the bucket size and the number of buckets
                    int bucketSize = Math.Max(1, (max - min) / (nums.Length - 1));
                    int numBuckets = (max - min) / bucketSize + 1;

                    // Initialize buckets
                    int[] minBucket = new int[numBuckets];
                    int[] maxBucket = new int[numBuckets];
                    bool[] hasNum = new bool[numBuckets];

                    for (int i = 0; i < numBuckets; i++)
                    {
                        minBucket[i] = int.MaxValue;
                        maxBucket[i] = int.MinValue;
                    }

                    // Put elements into buckets
                    foreach (int n in nums)
                    {
                        int index = (n - min) / bucketSize;
                        minBucket[index] = Math.Min(minBucket[index], n);
                        maxBucket[index] = Math.Max(maxBucket[index], n);
                        hasNum[index] = true;
                    }

                    // Calculate maximum gap
                    int prevMax = min;
                    int maxGap = 0;

                    for (int i = 0; i < numBuckets; i++)
                    {
                        if (hasNum[i])
                        {
                            maxGap = Math.Max(maxGap, minBucket[i] - prevMax);
                            prevMax = maxBucket[i];
                        }
                    }

                    return maxGap;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         The provided code efficiently calculates the maximum difference between two successive elements in a sorted form of the given integer array, adhering to linear time and space complexity requirements.
         By dividing components into buckets according to their values, it uses the bucket sort method, which effectively reduces the sorting complexity to linear time. 
         When an array has fewer than two elements, the method adequately handles edge cases and returns 0 as needed.adding comments to clarify the purpose of each step and the logic behind the bucket sort algorithm would improve the code's comprehensibility, especially for someone reviewing or maintaining it in the future. 
         Overall, the code provides an efficient solution to the problem, meeting the specified constraints.
        */


        /*

        Question:7
        Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5
        Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
        Example 2:

        Input: nums = [1,2,1,10]
        Output: 0
        Explanation: 
        You cannot use the side lengths 1, 1, and 2 to form a triangle.
        You cannot use the side lengths 1, 1, and 10 to form a triangle.
        You cannot use the side lengths 1, 2, and 10 to form a triangle.
        As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.

        Constraints:

        3 <= nums.length <= 104
        1 <= nums[i] <= 106

        */

        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                Array.Sort(nums, (a, b) => b.CompareTo(a)); // Sort the array in descending order

                for (int i = 0; i < nums.Length - 2; i++)
                {
                    if (nums[i] < nums[i + 1] + nums[i + 2]) // Check if it's possible to form a triangle
                    {
                        return nums[i] + nums[i + 1] + nums[i + 2]; // Return the perimeter
                    }
                }

                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
          The provided code efficiently finds the largest perimeter of a triangle that can be formed from the given integer array of side lengths.
          It sorts the array in descending order to ensure that the longest sides are considered first. 
          Then, it iterates through the sorted array and checks if it's possible to form a triangle with the current side lengths. 
          If a valid triangle can be formed, it returns the perimeter; otherwise, it returns 0 as per the problem requirements. 
          The code handles edge cases, such as arrays with less than three elements, appropriately.
          All things considered, the method meets the given limitations and offers an effective solution to the problem.
        */
        /*

        Question:8

        Given two strings s and part, perform the following operation on s until all occurrences of the substring part are removed:

        Find the leftmost occurrence of the substring part and remove it from s.
        Return s after removing all occurrences of part.

        A substring is a contiguous sequence of characters in a string.

 

        Example 1:

        Input: s = "daabcbaabcbc", part = "abc"
        Output: "dab"
        Explanation: The following operations are done:
        - s = "daabcbaabcbc", remove "abc" starting at index 2, so s = "dabaabcbc".
        - s = "dabaabcbc", remove "abc" starting at index 4, so s = "dababc".
        - s = "dababc", remove "abc" starting at index 3, so s = "dab".
        Now s has no occurrences of "abc".
        Example 2:

        Input: s = "axxxxyyyyb", part = "xy"
        Output: "ab"
        Explanation: The following operations are done:
        - s = "axxxxyyyyb", remove "xy" starting at index 4 so s = "axxxyyyb".
        - s = "axxxyyyb", remove "xy" starting at index 3 so s = "axxyyb".
        - s = "axxyyb", remove "xy" starting at index 2 so s = "axyb".
        - s = "axyb", remove "xy" starting at index 1 so s = "ab".
        Now s has no occurrences of "xy".

        Constraints:

        1 <= s.length <= 1000
        1 <= part.length <= 1000
        s​​​​​​ and part consists of lowercase English letters.

        */

        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                int index;

                // Repeat until no occurrence of 'part' is found
                while ((index = s.IndexOf(part)) != -1)
                {
                    // Remove the leftmost occurrence of 'part' from 's'
                    s = s.Remove(index, part.Length);
                }

                return s;
            }
            catch (Exception)
            {
                throw;
            }
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


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}
/*The offered code uses a while loop and the IndexOf method to efficiently delete all instances of a specified substring 'part' from the input string's'. 
  It finds and eliminates the leftmost instance of "part" from the input string iteratively until no more occurrences are detected.
  When 'part' is not found in a string or the string is empty, the code handles these edge cases appropriately. 
  Although the method answers the problem well overall, it might use a few little changes to increase efficiency and clarity.
*/
