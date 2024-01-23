using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class LongestIncreasingSubsequence
{

    static void Main()
    {
        FindLongestRisingSequence([6,2,4,6,1,5,9,2]);
    } 
    private static void FindLongestRisingSequence(int[] inputArray)
    {
        int[] array = inputArray;
         
        List<int> list = new List<int>();
        List<int> longestList = new List<int>();
        int highestCount = 1;
        for (int i = 0; i < array.Length; i++)
        {
            list.Add(array[i]);
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    list.Add(array[j]);
                    i++;
                }
                else 
                {
                    break;
                }
                i = j;
            }
            // Compare with in previous lists  
            if (highestCount < list.Count)
            {
                highestCount = list.Count;
                longestList = new List<int>(list);
            }
            list.Clear();

        }
        Console.WriteLine();

        // Print list  
        Console.WriteLine("The longest subsequence");
        foreach (int iterator in longestList)
        {
            Console.Write(iterator + " ");
        }
        Console.WriteLine();
    }
}