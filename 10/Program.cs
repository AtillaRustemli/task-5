namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-1000 qeder CUT ederlerin icerisinde   reqemleri cemi 5 ile 7 arasinda olan en boyuk eded:");
            int s = 0;
            int l = 0;
            for (int i = 0; i < 1001; i += 2)
            {

                if (i % 10 + (i % 1000) / 100 + i / 1000 + (i % 100) / 10 > 5&& i % 10 + (i % 1000) / 100 + i / 1000 + (i % 100)/10<7 )
                {
                    l++;
                    
                        s = i;
                    




                }
            }
            Console.WriteLine(s);
        }
    }
}