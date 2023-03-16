namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1-1000 olan ededlerin daxilinde 3 reqemi umumiyyetle olmayanlari: ");
            for (int i = 0; i < 1001; i++)
            {
                if(i % 10 ==3|| (i % 1000) / 100 ==3|| i / 1000 ==3|| (i % 100) / 10 == 3)
                {

                    continue;

                }
                Console.WriteLine(i);
            }
        }
    }
}