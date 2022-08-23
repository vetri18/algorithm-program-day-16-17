﻿namespace BubbleSort
{
    class Program
    {
        public static void Main()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for( int j = 0; j <= arr.Length-2; j++ )
            {
                for ( int i = 0; i <= arr.Length-2; i++ )
                {
                    if ( arr[i] > arr[i + 1] )
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array");
            foreach(int ele in arr )
            {
                Console.WriteLine(ele);
            }
        }
    }
}