using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    class InterviewProblems
    {

        /// Fill in the three methods below with algorithms you believe solve the problems described in the summary above them.
        /// You can use the provided InterviewProblemsTests.cs to perform unit tests and check how you're doing. Feel free to add some tests.

        /// <summary>
        /// Longest improvement
        /// A student's performance in lab activities should always improve, but that is not always the case.
        /// Since progress is one of the most important metrics for a student, let’s write a program that computes the longest period of increasing performance for any given student.
        /// For example, if his grades for all lab activities in a course are: 9, 7, 8, 2, 5, 5, 8, 7 then the longest period would be 4 consecutive labs (2, 5, 5, 8).
        /// Given an array with the lab grades of a student, your task is to write a function that computes and returns the longest period length of increasing performance
        ///  for the student that has these grades
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static int LongestImprovement(int[] grades)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pair product
        /// Given an array of integers, find the maximum product between two numbers from the array that is a multiple of 3.
        /// The result for the input {6,8,8,7,2,5} should be 48 = 6*8. Note that 8*8 is the greatest product (64) but 64 isn't divisible by 3.
        /// Given the input {1,9,2,4} the result should be  36 = 9*4, and not 81 (9*9)
        /// </summary>
        /// <param name="v"></param>
        public static int MaxProd(int[] v)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Balanced brackets
        /// Given a string of open and closed brackets output true if the brackets are balanced or false otherwise.
        /// A string is balanced if it consists entirely of pairs of opening/closing brackets (in that order), none of which mis-nest.
        /// Expected complexity: O(N)
        /// </summary>
        /// <param name="s"></param>
        public static bool BalancedBrackets(string s)
        {
            //TODO
            throw new NotImplementedException();
        }
       
    }
}
