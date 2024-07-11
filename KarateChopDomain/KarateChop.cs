namespace KarateChopDomain
{
    /// <summary>
    /// The KarateChop class contains methods to perform binary search operations.
    /// </summary>
    public static class KarateChop
    {
        /// <summary>
        /// A binary chop (sometimes called the more prosaic binary search) finds the position of a target value in a sorted array of values.
        /// It should return the integer index of the target in the array, or -1 if the target is not in the array.
        /// </summary>
        /// <param name="target">The target value to search for in the array.</param>
        /// <param name="array">The sorted array of integers to search within.</param>
        /// <returns>The integer index of the target value in the array, or -1 if the target is not found.</returns>
        public static int Chop(int target, int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

    }
}
