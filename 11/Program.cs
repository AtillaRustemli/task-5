namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1-1000 qeder ederlerin icerisinden         hem polindrom olan       hem ededin reqemleri daxilinde 3 olan    hem ededin reqemleri cemi 10 dan boyuk olan ededler: ");

            for (int i = 0; i < 1001; i++)
            {
                if (i%10+(i%100)/10+(i%1000)/100+i/1000>10&&i % 10 !=3&& (i % 100) / 10 !=3&& (i % 1000) / 100 !=3 && i / 1000 != 3)
                {
                    if (9 < i && i < 100)
                    {
                        if(i % 11 == 0) {
                            Console.WriteLine(i);

                        }
                    }
                    else if (99 < i && i <= 999)
                    {
                        if (i % 10 == i / 100)
                        {
                            Console.WriteLine(i);   
                        }
                    }
                   
                }
            }
            
        }
    }
}