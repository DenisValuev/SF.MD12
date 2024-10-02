namespace SF.Module12.Unit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static int BinarySearch(int value, int[] array, int left, int right)
        {
            var middle = (left + right) / 2;
            var midElement = array[middle];
            
            if (midElement == value)
            {
                return middle;
            }

            else if (left < right)
            {
                if (value < midElement)
                {
                    return BinarySearch(value, array, left, middle - 1);
                }
                else
                {
                    return BinarySearch(value, array, middle + 1, right);
                }
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Task 12.3.1
        /// </summary>
        /// <param name="value"></param>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        static int BinarySearchNotRecursive(int value, int[] array, int left, int right)
        {
            while (left <= right)
            {
                var middle = (value + left) / 2;
                var midElement = array[middle];

                if (midElement == value)
                {
                    return middle;
                }
                else if (value < midElement)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }

        static int GetIndexSortArray(int[] array, int element)
        {
            int index;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > element)
                {
                    return index;
                }
            }
            return index;
        }
    }
}
