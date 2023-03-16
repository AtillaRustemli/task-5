namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1-1000 olan ededlerin terkibinde 3 reqemi olmayan ededler:");
            for (int i = 0; i < 1001; i++)
            {

                if (i % 2 == 0 && (i % 10 + (i % 1000) / 100 + i / 1000 + (i % 100) / 10) % 2 == 1&&(i/100)%2==1|| (i / 1000) % 2==1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}