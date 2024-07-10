using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace DaiNi 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1.Write a program to delete the duplqicates from an array.
            List<int> list = new List<int> { 2, 2, 5,2, 8, 5, 9, 3,8 };
            list = DeleteDuplicate(list);
            Console.WriteLine(string.Join(", ", list));
//  2.Write a program to find the largest and the second largest number in an array.

//  3.Write a program that places all the zeros in an array at the end of the list.

//  4.Write a program to find the first non - repeating character in a string.   

//  5.Write a program to merge two sorted arrays into a single sorted array.

//  6.Write a program to find the missing number in an array containing n distinct numbers taken from 0, 1, 2, ..., n.

//  7.Write a program to check whether a number is Armstrong number or not.
//  Hint: Armstrong number is a number that is equal to the sum of cubes of its digits.

//  8.Write a program to find the longest common prefix in an array of strings.

//  9.Write a program that prints the Fibonacci sequence up to n terms(where n is user input).

//  10.Write a program that reads N integers, determines how many positive and negative values have been read and computes the total and average of input values.

        }

        static List<int> DeleteDuplicate(List<int> original)
        {
            //PROGRAM <DeleteDuplicate>

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i+1; j < original.Count; j++)
                {
                    if (original[i] == original[j])
                        original.RemoveAt(j);
                }
            }
            return original;
        }

        static void FindThe2Largest(List<int> original)
        {
            //PROGRAM <FindThe2Largest>

            int Largest = original[0];
            int Larger = Largest-1;

            //Outer Loop to Traverse Array 
            for (int i = 1; i < original.Count; i++)
            {
                if (original[i] > Largest)
                {
                    Larger = Largest;
                    Largest = original[i];
                }
            }
            Console.WriteLine($"The Largest of the Array is = {Largest} and the 2nd Largest is {Larger}");
        }

        static List<int> ZeroToEnd(List<int> original)
        {
            //PROGRAM <ZeroToEnd>
            if(original.Contains(0))
            {
                //Outer Loop to Traverse Array 
                for (int i = 0; i < original.Count; i++)
                {
                    if (original[i] == 0)
                    {
                        //Inner Loop to move zeros
                        for (int j = i; j < original.Count-1; j++)
                        {
                            original[j] = original[j+1];
                            original.[original.Count-1] = 0;
                        }
                    }
                }
            }
            return original;
        }

        static int FirstSolo(List<int> original)
        {
            //PROGRAM <FirstSolo>

            int HanSolo = -1;

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i + 1; j < original.Count; j++)
                {
                    if (original[i] == original[j])
                        break;
                    if (j == original.Count - 1)
                        HanSolo = original[i];
                }
                if (HanSolo != -1)
                    break;
            }
            return HanSolo;
        }

        static List<int> MergeSorted(List<int> list1, List<int> list2)
        {
            //PROGRAM <MergeSorted>

            return result;
        }

        static int MissingNo(List<int> original)
        {
            //PROGRAM <DeleteDuplicate>

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i + 1; j < original.Count; j++)
                {
                    if (original[i] == original[j])
                        original.RemoveAt(j);
                }
            }
            return original;
        }

        static void Armstrong(List<int> original)
        {
            //PROGRAM <DeleteDuplicate>

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i + 1; j < original.Count; j++)
                {
                    if (original[i] == original[j])
                        original.RemoveAt(j);
                }
            }
            return original;
        }

        static string LargestCommonPrefix(List<string> original)
        {
            //PROGRAM <DeleteDuplicate>

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i + 1; j < original.Count; j++)
                {
                    if (original[i] == original[j])
                        original.RemoveAt(j);
                }
            }
            return original;
        }

        static void Fibonacci(List<int> original)
        {
            //PROGRAM <DeleteDuplicate>

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i + 1; j < original.Count; j++)
                {
                    if (original[i] == original[j])
                        original.RemoveAt(j);
                }
            }
            return original;
        }

        static List<int> DynamicArrayDetqails(List<int> original)
        {
            //PROGRAM <DeleteDuplicate>

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i + 1; j < original.Count; j++)
                {
                    if (original[i] == original[j])
                        original.RemoveAt(j);
                }
            }
            return original;
        }

    }
}

