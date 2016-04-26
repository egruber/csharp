using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DynamicArray
{
    protected object[] data;
    protected int baseIndex;

    // Copy Method
    public void Copy(DynamicArray array)
    {
        // First, detect if the arrays are the same. This keeps us from copying the same thing if it's already there.
        if(array != this)
        {
            // Make sure that the new array is the correct size
            if (data.Length != array.data.Length)
                data = new object[array.data.Length];
            // Populate the new array with the old array's content
            for (int i = 0; i < data.Length; ++i)
                data[i] = array.data[i];
            baseIndex = array.baseIndex;
        }
    }

    // Constructors
    public DynamicArray() : this(0,0)
    {

    }

    public DynamicArray(int n) : this(n,0)
    {

    }
    public DynamicArray(int n, int m)
    {
        data = new object[n];
        baseIndex = m;
    }
}

namespace DynamicArrayTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[5];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = i + 1;
                Console.WriteLine("Current Index: " + i + " Current Value: " + firstArray[i]);
            }
            int[] secondArray = new int[5];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = (2*i) + 1;
                Console.WriteLine("Current Index: " + i + " Current Value: " + secondArray[i]);
            }
            // Begin by creating a pair of Dynamic Arrays
            DynamicArray firstDynamicArray = new DynamicArray(5);
            DynamicArray secondDynamicArray = new DynamicArray(secondArray);

            //Console.WriteLine(firstArray);
            //Console.WriteLine(secondArray);

        }
    }
}
