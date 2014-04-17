using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InterviewQuestionsExtraTests
{
    public class ExtraQuestions
    {
        
        public static void LongestImprovement(Func<int[], int> func)
        {
            var input = new int[] {1, 1, 1, 1, 1};
            var res = func(input);
            if (res != input.Length)
                Fail("[" + string.Join(" , ", input) + "]", input.Length.ToString(), res.ToString());
            input = new int[] { 9, 8, 7, 6, 5, 4 };
            res = func(input);
            if (res != 1)
                Fail("["+ string.Join(" , ", input)+ "]", "1", res.ToString());
            input = new int[] {10,1,2,3} ;
            res = func(input);
            if(res!=3)
                Fail("[" + string.Join(" , ", input) + "]", "3", res.ToString());
        }

        public static void Balanced(Func<string, bool> func)
        {
            var input = "(()";
            var res = func(input);
            if(res)
                Fail(input,"false","true");

            input = ")()(";
            res = func(input);
            if (res)
                Fail(input, "false", "true");

            input = "((())())";
            res = func(input);
            if (!res)
                Fail(input, "true", "false");

        }

        public static void PairProduct(Func<int[], int> func)
        {
           var input = new[] { 1, 1, 8, 9, 2, 5 };
            var res = func(input);
            if(res != 72)
                Fail("[" + string.Join(" , ", input) + "]", "72", res.ToString());
        }


        private static void Fail(string input, string expected,string result)
        {
            throw new Exception(string.Format("Assertion failed on input {0}: expected {1} was {2}", input, expected, result));
        }

    }
}
