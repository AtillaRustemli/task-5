namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" 1-100000 qeder ederlerin icerisinden    hem butun reqemleri eyni olan,       hem reqemleri cemi 5 den boyuk olan      hem reqemleri arasinda 5 reqemi olmayan ededler:   ");



            for (int i = 0; i < 100001; i++)
            {
                if (i / 100000 + (i % 100000)/10000 + (i % 10000) / 1000 + (i % 1000) / 100 + (i % 100) / 10 + i % 10 > 5)
                {




                    if (i / 100000 != 5 && (i % 100000)/10000 != 5 && (i % 10000) / 1000 != 5 && (i % 1000) / 100 != 5 && (i % 100) / 10 != 5 && i % 10 != 5)
                    {




                        if (9 < i && i < 100)
                        {
                            if ((i % 100) / 10 == i % 10)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        if (99 < i && i < 1000)
                        {
                            if ((i % 1000) / 100 == (i % 100) / 10 && (i % 100) / 10 == i % 10)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else if (999 < i && i < 10000)
                        {
                            if ((i % 10000) / 1000 == (i % 1000) / 100 && (i % 1000) / 100 == (i % 100) / 10 && (i % 100) / 10 == i % 10)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else if (9999 < i && i < 100000)
                        {
                            if ((i % 100000) / 10000 == (i % 10000) / 1000 && (i % 10000) / 1000 == (i % 1000) / 100 && (i % 1000) / 100 == (i % 100) / 10 && (i % 100) / 10 == i % 10)
                            {
                                Console.WriteLine(i);
                            }
                        }

                        {



                        }

                    }

                }

                   
            }
        }
    }
}                  