using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

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

                //int team = numbers[minIndex];
                //numbers[minIndex] = numbers[i]; 
                //numbers[i] = team;

                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if(numbers[j] < numbers[j+1])
                    {
                        (numbers[j], numbers[j + 1] = (numbers[j + 1], numbers[j]);
                    }
                }
            }

            return numbers;

        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {

            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            return 0;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            return 0;
        }

        #endregion
    }
}
