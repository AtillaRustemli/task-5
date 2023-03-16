namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k=0;
            Console.WriteLine(" 1-1000 olan ededlerin daxilinde 3 reqemi umumiyyetle olmayib ve reqemlerinin cemi 3-e bolunen son eded: ");

            for (int i = 0; i < 1001; i++)
            {
                    
                if (i % 10 == 3 || (i % 1000) / 100 == 3 || i / 1000 == 3 || (i % 100) / 10 == 3||!((i % 10 + (i % 1000) / 100 + i / 1000 + (i % 100) / 10) % 3 == 0))
                {
                    
                    continue;

                }
                k = i;
                
            }

            
            
            Console.WriteLine(k);
        }
    }
}