namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1-1000 olan ededlerin hem reqemleri cemi 5-e bolunen,    hem de ozu 5-e bolunen ededler:");
            for (int i = 0; i < 1001; i++)
            {

                if (i % 5 == 0&& (i%10+ (i % 1000) / 100+i/1000+(i%100)/10)%5==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}