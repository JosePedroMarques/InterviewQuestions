using InterviewQuestionsExtraTests;
using NUnit.Framework;

namespace InterviewQuestions
{
    [TestFixture]
    class InterviewProblemsTests
    {
        [Test]
        public void TestLongestImprovement()
        {
            //The result for the input below should be 2. The longest improving sequence is 3,5
            int[] input = new[] {9, 3, 5, 4}; 
            Assert.AreEqual(2,InterviewProblems.LongestImprovement(input));
            ExtraQuestions.LongestImprovement(InterviewProblems.LongestImprovement);
        }

        [Test]
        public void TestPairProduct()
        {
            //The result for the input below should be 48: 6*8. note that 8*7 is the greatest product (56) but 56 isn't divisible by 3
            int[] input = new[] {6,8,8,7,2,5};
            Assert.AreEqual(48, InterviewProblems.MaxProd(input));
            ExtraQuestions.PairProduct(InterviewProblems.MaxProd);
        }

        [Test]
        public void TestBalanced()
        {
            string input = "(())";
            Assert.IsTrue(InterviewProblems.BalancedBrackets(input));
            ExtraQuestions.Balanced(InterviewProblems.BalancedBrackets);
        }
       
    }
}
