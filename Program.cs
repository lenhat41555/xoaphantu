using System;

namespace xoaphantu
{
    class Program
    {
        static void Main(string[] args)
        {
           string strInput = Console.ReadLine();
string[] strItems = new string[] { "1", "2", "3", "4", "5" };

int removeIndex = Array.IndexOf(strItems, strInput);

if (removeIndex >= 0)
{
    // declare and define a new array one element shorter than the old array
    string[] newStrItems = new string[strItems.Length - 1];

    // loop from 0 to the length of the new array, with i being the position
    // in the new array, and j being the position in the old array
    for (int i = 0, j = 0; i < newStrItems.Length; i++, j++)
    {
        // if the index equals the one we want to remove, bump
        // j up by one to "skip" the value in the original array
        if (i == removeIndex)
        {
            j++;
        }

        // assign the good element from the original array to the
        // new array at the appropriate position
        newStrItems[i] = strItems[j];
    }

    // overwrite the old array with the new one
    strItems = newStrItems;
}
        }
    }
}
