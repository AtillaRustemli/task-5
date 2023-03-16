namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("1-1000 qeder ededlerin icerisinde hem 7-e, hemde 8-e bolunenlerin siyahisi");
            for (int i = 0; i < 1001; i++)
            {
                if (i % 7 == 0 && i % 8 == 0)
                {
                    Console.WriteLine($".{i}. ");
                }
            }
        }
    }
}