namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1-1000 qeder ederlerin icerisinden reqemleri cemi 3-e bolunen ve son reqemi 3 olmayan ededler:");
            for (int i = 0; i < 1001; i++)
            {

                if (i % 3 == 0&&i%10!=3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}