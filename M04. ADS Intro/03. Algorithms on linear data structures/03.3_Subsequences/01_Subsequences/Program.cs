using System;
using System.Collections.Generic;

namespace _01_Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> seq1 = new List<int>() { 2, 2, 2, 3, 3, 3 };
            List<int> maxEquals = MaxSubSequenceEqualNumbers(seq1);
            Console.WriteLine(string.Join(", ", maxEquals));

            List<int> seq2 = new List<int>() { 1, 2, 3, 10, 4, 3, 2 };
            List<int> maxGrowing = MaxSubSequenceGrowingNumbers(seq2);
            Console.WriteLine(string.Join(", ", maxGrowing));

            List<int> seq3 = new List<int>() { 1, 2, 3, 10, 4, 3, 2 };
            List<int> maxDecreasing = MaxSubSequenceDecreasingNumbers(seq3);
            Console.WriteLine(string.Join(", ", maxDecreasing));
        }

        public static List<int> MaxSubSequenceEqualNumbers(List<int> list)
        {
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();

            tempSubSequence.Add(list[0]);

            for (int i = 1; i < list.Count; i++)
            {
                if(tempSubSequence[0] == list[i])
                {
                    tempSubSequence.Add(list[i]);
                    if(tempSubSequence.Count > maxSubSequence.Count)
                    {
                        maxSubSequence.Clear();
                        maxSubSequence.AddRange(tempSubSequence); 
                    }
                }
                else
                {
                    tempSubSequence.Clear();
                    tempSubSequence.Add(list[i]);
                }
            }

            return maxSubSequence;
        }

        public static List<int> MaxSubSequenceGrowingNumbers(List<int> list)
        {
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();

            tempSubSequence.Add(list[0]);
            int currentValue = tempSubSequence[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (currentValue < list[i])
                {
                    tempSubSequence.Add(list[i]);
                    currentValue = list[i];
                    if (tempSubSequence.Count > maxSubSequence.Count)
                    {
                        maxSubSequence.Clear();
                        maxSubSequence.AddRange(tempSubSequence);
                    }
                }
                else
                {
                    tempSubSequence.Clear();
                    tempSubSequence.Add(list[i]);
                }
            }

            return maxSubSequence;
        }

        public static List<int> MaxSubSequenceDecreasingNumbers(List<int> list)
        {
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();

            tempSubSequence.Add(list[0]);
            int currentValue = tempSubSequence[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (currentValue > list[i])
                {
                    tempSubSequence.Add(list[i]);
                    currentValue = list[i];
                    if (tempSubSequence.Count > maxSubSequence.Count)
                    {
                        maxSubSequence.Clear();
                        maxSubSequence.AddRange(tempSubSequence);
                    }
                }
                else
                {
                    tempSubSequence.Clear();
                    tempSubSequence.Add(list[i]);
                    currentValue = list[i];
                }
            }

            return maxSubSequence;
        }
    }
}
