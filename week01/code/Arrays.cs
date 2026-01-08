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
        


        //In this function i need to create the code to return an array starting with 'number' followed by multiples of 'number'.
        //For example MultiplesOf(3,5), where the 3 is the starting number and 5 is the number of multiples, would result in <double>{3,6,9,12,15}.
        //step 1 Create name of the array using the 'double' as is required, then we use 'new double[length]' to create the doubles with length spaces in the array.
        //step 2 Create a loop 'for'with specification, a count variable called 'i' which starts at 0 which is the position of the array
        //the cicle will repeat it while length is minor then 'i'. Then increase the value of 'i' in 1 after to change the position of the array.
        //step 3 Create another variable called result[i], it multiply the number by the [i] plus 1.
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
    }
}
