using System;

namespace CCIPeaksAndValues
{
    class Program
    {
        public void sortPeakValues(int[]arr)
        {
            Array.Sort(arr);
            for(int i=1;i<arr.Length;i += 2)
            SwapAdjacent(arr,i-1,i);

             
        }

        public void SwapAdjacent(int[]arr,int leftValue,int rightValue)
        {
            int temp;
            temp = arr[leftValue];
            arr[leftValue] = arr[rightValue];
            arr[rightValue] = temp;


           
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("Enter the number of elements in the array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Input the " + num + " elements in array");
            for(int i=0;i<num;i++)
            {
                Console.Write("element #"+ i +": ", arr[i]);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of the array are");
            for(int i=0;i<num;i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            obj.sortPeakValues(arr);

            Console.WriteLine("\n The Peak Value Array is");
            for (int i = 0; i < num; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
