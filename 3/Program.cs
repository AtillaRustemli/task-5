namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" 1-1000 qeder ederlerin icerisinden reqemleri cemi 3-e bolunen ededler");
            for (int i = 0; i < 1001; i++)
            {
                
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}