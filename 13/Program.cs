namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-100000 qeder ederlerin icerisinden      hem butun reqemleri yalniz tek ededlerden ibaret olan     polindrom olan       daxilinde minimum 1 dene 5 reqemi olan ededler:");
            for (int i = 1; i < 100001; i+=2)
            {
                if (i / 100000 + (i % 100000) + (i % 10000) / 1000 + (i % 1000) / 100 + (i % 100) / 10 + i % 10 > 5)
                {




                    if (i / 100000 == 5 || (i % 100000) == 5 || (i % 10000) / 1000 == 5 || (i % 1000) / 100 == 5 || (i % 100) / 10 == 5 || i % 10 == 5)
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
                            if ((i % 1000) / 100 == i % 10)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else if (999 < i && i < 10000)
                        {
                            if ((i % 10000) / 1000 == i % 10 && (i % 1000) / 100 == (i % 100) / 10)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else if (9999 < i && i < 100000)
                        {
                            if (i  / 10000 == i % 10 && (i % 10000) / 1000 == (i % 100) / 10 )
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