package questions;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;
import static org.junit.Assert.assertEquals;

public class InterviewQuestionsTest {

    @Test
    public void testLongestImprovement() throws Exception {
        //The result for the input below should be 2. The longest improving sequence is 3,5
        int[] input = new int[] {9, 3, 5, 4};
        assertEquals(2, InterviewQuestions.LongestImprovement(input));

        input = new int[] {1, 1, 1, 1, 1};
        assertEquals(input.length, InterviewQuestions.LongestImprovement(input));

        input = new int[] { 9, 8, 7, 6, 5, 4 };
        assertEquals(1, InterviewQuestions.LongestImprovement(input));


        input = new int[] {10,1,2,3} ;
        assertEquals(3, InterviewQuestions.LongestImprovement(input));
    }

    @Test
    public void testMaxProd() throws Exception {
        //The result for the input below should be 48: 6*8. note that 8*7 is the greatest product (56) but 56 isn't divisible by 3
        int[] input = new int[] {6,8,8,7,2,5};
        assertEquals(48, InterviewQuestions.MaxProd(input));

        input = new int[] { 1, 1, 8, 9, 2, 5 };
        assertEquals(72, InterviewQuestions.MaxProd(input));
    }



    @Test
    public void testBalancedBrackets() throws Exception {
        String input = "(())";
        assertTrue(InterviewQuestions.BalancedBrackets(input));

        input = "(()";
        assertFalse(InterviewQuestions.BalancedBrackets(input));

        input = ")()(";
        assertFalse(InterviewQuestions.BalancedBrackets(input));

        input = "((())())";
        assertTrue(InterviewQuestions.BalancedBrackets(input));
    }
}