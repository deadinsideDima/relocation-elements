using System;

namespace RelocationElements
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source"> Source array. </param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[]? source, int value)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty", nameof(source));
            }

            int j = source.Length - 1;
            while (source[j] == value)
            {
                j--;
            }

            for (int i = 0; i < j; i++)
            {
                while (source[i] == value)
                {
                    int k = i;
                    while (k < j)
                    {
                        source[k] = source[k + 1];
                        k++;
                    }

                    source[k] = value;
                    j--;
                }
            }
        }
    }
}
