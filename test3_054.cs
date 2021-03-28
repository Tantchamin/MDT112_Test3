using System;

namespace Test3_054
{
    class Program
    {
        static void Main(string[] args)
        {
            int bucket1 = int.Parse(Console.ReadLine());
            int bucket2 = int.Parse(Console.ReadLine());
            int bucket3 = int.Parse(Console.ReadLine());
            int bucketNum = 0, boxout = 0, i = 1;

            while (bucket1 != 0 || bucket2 != 0 || bucket3 != 0)
            {
                Console.WriteLine("Bucket1: {0}, Bucket2: {1}, Bucket3: {2}", bucket1, bucket2, bucket3);
                if (i % 2 != 0)
                {
                    Console.WriteLine("Player A");
                }
                else
                {
                    Console.WriteLine("Player B");
                }
                Console.Write("Bucket: ");
                bucketNum = int.Parse(Console.ReadLine());
                Console.Write("Out: ");
                boxout = int.Parse(Console.ReadLine());
                if (bucketNum == 1)
                {
                    bucket1 = bucket1 - boxout;
                }
                else if (bucketNum == 2)
                {
                    bucket2 = bucket2 - boxout;
                }
                else if (bucketNum == 3)
                {
                    bucket3 = bucket3 - boxout;
                }
                i = i + 1;
            }
            Console.WriteLine("Bucket1: {0}, Bucket2: {1}, Bucket3: {2}", bucket1, bucket2, bucket3);
            if (i % 2 != 0)
            {
                Console.WriteLine("Player A Win");
            }
            else
            {
                Console.WriteLine("Player B Win");
            }
        }
    }
}
