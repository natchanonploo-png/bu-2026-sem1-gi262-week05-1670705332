using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;
namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                /*int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;*/
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone(); 
            
            for (int i = 0; i < result.Length - 1; i++)
            {
                int maxIdx = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] > result[maxIdx]) 
                    {
                        maxIdx = j;
                    }
                }
                int temp = result[i];
                result[i] = result[maxIdx];
                result[maxIdx] = temp;
            }
            foreach (int num in result)
            {
                Debug.Log(num);
            }

            return result;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] < result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            foreach (int num in result)
            {
                Debug.Log(num);
            }

            return result;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 1; i < result.Length; i++)
            {
                int key = result[i];
                int j = i - 1;

                while (j >= 0 && result[j] < key)
                {
                    result[j + 1] = result[j];
                    j--;
                }
                result[j + 1] = key; 
            }

            foreach (int num in result)
            {
                Debug.Log(num);
            }

            return result;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            if (numbers.Length == 1) return numbers[0];

            int[] result = (int[])numbers.Clone();
            
            Array.Sort(result); 
            Array.Reverse(result);

            int max = result[0];
            
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] < max)
                {
                    Debug.Log(result[i]);
                    return result[i];
                }
            }

            Debug.Log(max);
            return max;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            if (numbers.Length == 1) return 1;
            int[] sorted = (int[])numbers.Clone();
            Array.Sort(sorted);

            int longest = 1;
            int currentStreak = 1;

            for (int i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] != sorted[i - 1])
                {
                    if (sorted[i] == sorted[i - 1] + 1)
                    {
                        currentStreak++;
                    }
                    else
                    {
                        longest = Math.Max(longest, currentStreak);
                        currentStreak = 1;
                    }
                }
            }
            longest = Math.Max(longest, currentStreak);

            Debug.Log($"The longest consecutive sequence is: {longest}");
            return longest;
        }

        #endregion
    }
}
