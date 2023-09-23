/*
            int rows = 9; // Number of rows in the pyramid
for (int i = 1; i <= rows; i++)
{
    // Print spaces before numbers
    for (int j = rows - i; j > 0; j--)
    {
        Console.Write("  ");
    }
    // Print numbers in decreasing order
    for (int j = i; j >= 1; j--)
    {
        Console.Write(j + " ");
    }
    // Print numbers in increasing order
    for (int j = 2; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine(); // Move to the next line for the next row
}
*/