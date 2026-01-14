public static class Arrays
{
    // <summary>
    // Step-by-step plan to solve the problem:
    // 1. Create an array of doubles with the size equal to 'length'.
    // 2. Use a loop to calculate each multiple of 'number'.
    //    - The first multiple is number * 1, the second is number * 2, and so on.
    // 3. Store each calculated multiple in the corresponding index of the array.   
    // 4. Return the completed array.
    
    public static double[] MultiplesOf(double number, int length)

    // create an array of doubles with the size equal to 'length'.
    {
        double[] multiples = new double[length];
        // Use a loop to calculate each multiple of 'number'.
        for (int i = 0; i < length; i++)
        // The first multiple is number * 1, the second is number * 2, and so on.
        {
            multiples[i] = number * (i + 1);
            // Store each calculated multiple in the corresponding index of the array.
        }
        return multiples;
    }
    

/// Step-by-step plan to solve the problem:
/// 1. Get the number of elements in the list.
/// 2. Calculate the index where the list will be split for rotation.
/// 3. Create a temporary list to store the rotated values. 
/// 4. Add the last 'amount' elements from the original list to the front of the temporary list.
/// 5. Add the remaining elements from the original list to the temporary list.
/// 6. Clear the original list and copy the contents of the temporary list back into it.


    public static void RotateListRight(List<int> data, int amount)
    {
        // Get the number of elements in the list
        int count = data.Count;

        //  Calculate where to split the list
        int splitIndex = count - amount;

        // Create a temporary list to store rotated values
        List<int> rotated = new List<int>();

        //  Add the last 'amount' elements to the front
        for (int i = splitIndex; i < count; i++)
        {
            rotated.Add(data[i]);
        }

        //  Add the remaining elements
        for (int i = 0; i < splitIndex; i++)
        {
            rotated.Add(data[i]);
        }

        // Replace original list contents
        data.Clear();
        data.AddRange(rotated);
    }
}
