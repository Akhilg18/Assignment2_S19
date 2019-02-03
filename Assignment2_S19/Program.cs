using System;
using System.Collections.Generic;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));


            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);


            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine(findMedian(arr2));

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadLine();

        }

        static void displayArray(int[] arr) {
            Console.WriteLine();
            foreach (int n in arr) {
                Console.Write(n + " ");
            }
        }

        //function to sort the array
        static int[] sortthearray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            return arr;
        }
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            try
            {
                int n = a.Length;
                d = d % 5;
                int[] b = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    if ((i - d) < 0)
                    {
                        b[n + i - d] = a[i];
                    }
                    else
                    {
                        b[i - d] = a[i];
                    }
                }
                return b;
            }
            catch
            {
             Console.WriteLine("Exception occured while computing rotLeft()");
            }
            return null;
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            try
            {
                int maxToys = 0;
                // Array.Sort(prices);
                prices = sortthearray(prices);
                for (int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] < k)
                    {
                        maxToys++;
                    }
                    k = k - prices[i];
                }
                return maxToys;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing maximumToys()");
            }
            return 0;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            for(int i=0;i<arr.Count;i++)
            {
                int leftsum = 0;
                int rightsum = 0;
                for(int y=0;y<i;y++)
                {
                    leftsum = arr[y] + leftsum;
                }
                for(int z=i+1;z<arr.Count;z++)
                {
                    rightsum = rightsum + arr[z];
                }
                if(leftsum==rightsum)
                {
                    return "YES";
                }
            }
            return "NO";
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int currentnumber;
            int missingnumber;
            //Array.Sort(arr);
            // Array.Sort(brr);
            arr = sortthearray(arr);
            brr = sortthearray(brr);
            int[] c = new int[brr.Length];
            while(i <brr.Length)
                {
                currentnumber = arr[i];
                while(j<arr.Length)
                {
                    if (brr[i] == arr[j])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        missingnumber = brr[i];
                        Console.WriteLine(missingnumber);
                        k++;
                        i++;
                    }
                }
                }
            
            return new int[] { };
        }



        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            try
            {
                for (int i = 0; i < grades.Length; i++)
                {
                    int temp = 0;
                    if (grades[i] >= 38)
                    {
                        temp = grades[i] / 5;
                        if (((temp + 1) * 5) - grades[i] < 3)
                        {
                            grades[i] = (temp + 1) * 5;
                        }
                    }
                }
                return grades;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing gradingStudents()");
            }
            return null;
        }


        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            arr = sortthearray(arr);
            
            if(arr.Length%2==0)
            {
                int g = arr.Length / 2;
                return (arr[g] + arr[g - 1]) / 2;
            }
            else
            {
                int g = arr.Length / 2;
                return arr[g];
            }
            
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            return new int[] { };
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            try
            {
                string dd;
                string mm;
                if (year / 4 == 0)
                {
                     dd = "12.";
                     mm = "09.";
                    return (String.Concat(dd, mm, year));
                }
                else
                {
                    dd = "13.";
                    mm = "09.";
                    return (String.Concat(dd, mm, year));
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing gradingStudents()");
            }
            return "";
        }
    }
}
