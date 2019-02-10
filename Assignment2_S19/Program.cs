/* Self Reflection from Assignment 2 
 * learnt how to use functions
 * learnt how to use arrys
 * learnt about checking the conditions based on the array values
 * learnt about the sorting algorithms
 * learnt how to cover different use cases based on different input cnoditions
 * leant how to checkout the team code and sync the code and push the final code to repository
 */

using System;
using System.Collections.Generic;
using System.Linq;

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
            int[] r = rotLeft(a, d);            //Method call to rotate array a by d times
            displayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            //Method call to find the maximum no of toys that can be brought using k amount.
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
            //Method call to re-grade student grades by rounding off qualified grades.
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
            //Method call to print the 256th day of the programmer in mm.dd.yyy format.
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadLine();

        }

        static void displayArray(int[] arr) {
            try
            {
                Console.WriteLine();
                foreach (int n in arr)
                {
                    Console.Write(n + " ");
                }
            }
            catch {
                Console.WriteLine("Exception occured while computing displayarray");

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
            if(d<0)
            {
                Console.WriteLine("exitinf the function as the value d is less than zero");
                return null;
            }
            if(a.Length==0)
            {
                Console.WriteLine("exiting the function as the array is null");
                return null;
            }
            
            try
            {   //initilizing n with the length of the array.
                int n = a.Length;
                d = d % 5;
                //create a new array to return the left displaced elements.
                int[] b = new int[a.Length];
                //looping through the array elements.
                for (int i = 0; i < a.Length; i++)
                {   // checking if the value of i-d is less than zero
                    if ((i - d) < 0)
                    {
                        // if yes assign the value to the rray b at position (n+i-d)
                        b[n + i - d] = a[i];
                    }
                    else
                    {   // if no assign the value at the position (i-d) in the array b.
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
                //check if amount given is positive and array of prices is not empty
                //if (k > 0 && prices != null)
                if(k>0 && prices.Length>0)
                {
                    int maxToys = 0;
                    // sorting the prices in the array
                    prices = sortthearray(prices);
                    for (int i = 0; i < prices.Length; i++)
                    {
                        //buying the toys in order of lowest priced first
                        if (prices[i] < k)
                        {
                            //keeping track of number of toys brought
                            maxToys++;
                        }
                        // subtracting the price of toys brought from the actual amount
                        k = k - prices[i];
                    }
                    //return number of toys brought using the given amount.
                    return maxToys;
                }
                else
                {
                    //error msg to let the user know about negative amount.
                    Console.WriteLine("check the input values");
                }
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
            if(arr.Count==0)
            {
                Console.WriteLine("exiting the function as the array is null");
                return null;
            }
            try
            {   //looping through the array
                for (int i = 0; i < arr.Count; i++)
                {

                    int leftsum = 0;
                    int rightsum = 0;
                    //loop to calculate the left sum at point of array
                    for (int y = 0; y < i; y++)
                    {   //saving the left sum in the variable leftsum
                        leftsum = arr[y] + leftsum;
                    }
                    //loop to calculate the right sum at a point of array
                    for (int z = i + 1; z < arr.Count; z++)
                    {
                        //saving the right sum in the variable rightsum
                        rightsum = rightsum + arr[z];
                    } //checking if left sum equal to right sum
                    if (leftsum == rightsum)
                    {
                        return "YES";
                    }
                }
                return "NO";

            }
            catch
            {
                Console.WriteLine("Exception occured while computing balanced sums");
                return "EXCEPTION";

            }
        }

        // Complete the missingNumbers function below
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            // intializing the temparory varibles.
            int i = 0;
            int j = 0;
            int k = 0;
            //declaring current number and missing number
            int missingnumber;

            //sorting the arrays arr and brr.
            arr = sortthearray(arr);
            brr = sortthearray(brr);
            //creating a new array to store the missing numbers.


            List<int> list = new List<int>();
            try
            {
                while (i < brr.Length)
                {
                    //checking if the value of the array brr is equal to arr
                    if (brr[i] == arr[j])
                    {
                        // if yes then increment the position of arr and brr
                        i++;
                        j++;
                        if (j == arr.Length)
                        {
                            //if the position of the arr reached the end print the remaining numbers of brr.
                            while (i < brr.Length)
                            {
                                list.Add(brr[i]);
                                i++;

                            }
                        }
                    }
                    else
                    {// if the value of the array brr is not equal to arr then add the number to the list
                        missingnumber = brr[i];
                        // add the missing number to the list.
                        list.Add(missingnumber);
                        i++;
                    }


                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing missingnumbers()" );
            }
            int[] c = new int[list.Count];
            int z = 0;
            //looping through the elements of the list to add into the array.
            foreach (int num in list)
            {
                c[z] = num;
                z++;

            }
            int[] d = new int[c.Length];
            //making the array distinct.
            d = c.Distinct().ToArray();

            return d;
        }



        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            try
            {
                //flag corner to check the corner cases
                bool corner = true;
                for (int i = 0; i < grades.Length; i++)
                {
                    //check if grades are above 100 or below 0.
                    if (grades[i] > 100 || grades[i] < 0)
                    {
                        corner = false;
                    }
                }
                for (int i = 0; i < grades.Length; i++)
                {
                    int temp = 0;
                        if (grades[i] >= 38)
                        {
                        //rounding off grades to nearest integer based on requirements.
                            temp = grades[i] / 5;
                            if (((temp + 1) * 5) - grades[i] < 3)
                            {
                                grades[i] = (temp + 1) * 5;
                            }
                        }
                    }
                if (corner == true)
                    return grades;
                else
                {
                    Console.WriteLine("grades greater than 100 or less than zero. check below grades:");
                    return grades;
                }
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
            if(arr.Length==0)
            {
                Console.WriteLine("exiting the function as the array is null");
                return -1;
            }
            try
            {   //sort the array
                arr = sortthearray(arr);
                //checking if the array is even
                if (arr.Length % 2 == 0)
                {   //if it is even then average the middle 2 elements
                    int g = arr.Length / 2;
                    return (arr[g] + arr[g - 1]) / 2;
                }
                else
                {   //if the array is odd then return the middle element.
                    int g = arr.Length / 2;
                    return arr[g];
                }
            }
            catch
            {
                Console.WriteLine("Error occured while computing median");
            }
            return -1;
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] a)
        {
            List<int> result = new List<int>();
            a = sortthearray(a);
            int mindiff = Math.Abs(a[1] - a[0]);
            int dif = mindiff;

            for (int i = 0, j = 1; j < a.Length; i++, j++)
            {
                if ((dif = Math.Abs(a[j] - a[i])) <= mindiff)
                {

                    if (mindiff != dif) result.Clear();
                    result.Add(a[i]);
                    result.Add(a[j]);
                    mindiff = dif;

                }


            }
            int[] c = new int[result.Count];
            int n = 0;
            foreach (int value in result)
            {
                c[n] = value;
                n++;
            }
            return c;
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {

            try
            {
                string dd;
                string mm;
                //check the year if it is a leap year
                if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                {
                    dd = "12.";
                    mm = "09.";
                    // returning the date in the given format.
                    return (String.Concat(dd, mm, year));
                }
                else
                {
                    dd = "13.";
                    mm = "09.";
                    // returning the date in the given format.
                    return (String.Concat(dd, mm, year));
                }
            }
            catch
            {
                //Console.WriteLine("Exception occured while computing gradingStudents()");
                Console.WriteLine("Exception occured while computing day of programmer ");
            }
            return "";
        }
    }
}
