using System;
class Program
{
    public static void Main(string[] args)
    { 

        int sum = 0;
        Console.WriteLine("Sum of the array elements");
        for (int i = 0; i< 5; i++)
        {

            Console.WriteLine("Sum", arr[i]);
        }

       Console.WriteLine("Sum of array elements:");
        for (int i = 0; i < 5; i++)
        {
            sum = sum + arr[i];
        } 
        Console.WriteLine("Sum",arr[i] );



        Console.WriteLine("Sum", sum);
        return 0;
    }
}