using System.Globalization;

namespace BinarySearch;

class Program
{
    static void Main()
    {
        int[] orderIDs = { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine(BinarySearch(orderIDs, 3));

    }

    static int BinarySearch(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = nums[mid];

            if (guess == target)
                return mid;
            if (guess < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }

   
}
