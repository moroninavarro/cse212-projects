using Microsoft.VisualStudio.TestPlatform.ObjectModel;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        

        //My Comments
       
        //STEP 1 Create local variable using the 'double' as is required called 'result', 
        // then we use a 'new' double 'length' to create the doubles with 'length' spaces in the array.
        //STEP 2 Create a 'for' loop and declare an integer variable 'i' as the loop counter, the
        //value stored in the loop counter is 0. The loop continues while the integer variable 'i',
        // is less than 'length'. Then increase the value of the integer variable  by 1 in each iteration.
        //STEP 3 We access the array result at index 'i'. The value stored in the array is the 'number',
        // multiplied by the integer variable plus 1.
        //STEP 4 we return the array 'result'.

            double[] result = new double[length];
            for(int i = 0; i < length; i++)
            {
                result[i] = number * (i + 1);
            }
        
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        //My comments
        //STEP 1 Create a local variable using the 'List<int>' system as is required, use
        //the 'data' parameter as the value for the local variable.
        //STEP 2 Create a 'for' loop and declare an integer variable with a value of 0,
        // the loop continues while our integer variable is less than the 'amount' parameter, and the integer variable increases by 1 in each iteration.
        //STEP 3 Store the last element of the list in a local variable.
        //STEP 4 Create another loop, declare an integer variable and store the last element of the data.
        //the loop continues while our integer variable is greater than zero, and the integer variable decreases by 1 in each iteration.
        //STEP 5 Access at a specific value in the list.
        //STEP 6 Replace the first element of the list using the local variable in step 3.


        List<int> list = data;
        
        for (int times = 0; times < amount; times++)
        {
        int last = list[list.Count - 1];
        for( int i = data.Count - 1; i > 0; i--)
            {
        
            list[i] = list[i - 1];
            
            }
        list[0] = last;

        }
        
    }
}
