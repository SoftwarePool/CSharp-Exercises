using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrays =new int[4];
            arrays[0] = 1;
            arrays[1] = 2;
            arrays[2] = 3;
            arrays[3] = 4;

            for(int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(arrays[i]);
            }
        }
    }
}
