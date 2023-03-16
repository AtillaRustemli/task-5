namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1-100000 qeder ederlerin icerisinden       hem sade eded olan     hem ededin ozunun daxilinde 0,1,5,7,9 reqemleri olmayan       hem ededin reqemleri ceminde 2 reqemi olmayan ededler: ");

            for (int i = 0; i < 100001; i++)
            {
                if((i%10+(i%100)/10+(i%1000)/100+(i%10000)/1000+(i%100000)/10000)%10 != 2|| (i % 10 + (i % 100) / 10 + (i % 1000) / 100 + (i % 10000) / 1000 + (i % 100000) / 10000) % 10!=2)
                {



                if(i==2||i==3)
                {
                        Console.WriteLine(i);
                }
                if(! (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0) )
                {
                        if(i % 10 != 0&&(i % 100) / 10 != 0&&(i % 1000) / 100 != 0 && (i % 10000) / 1000 != 0&&(i % 100000) / 10000 != 0){
                            if(i % 10 != 1 && (i % 100) / 10 != 1 && (i % 1000) / 100 != 1 && (i % 10000) / 1000 != 1 && (i % 100000) / 10000 != 1)
                            {
                                if(i % 10 != 5 && (i % 100) / 10 != 5 && (i % 1000) / 100 != 5 && (i % 10000) / 1000 != 5 && (i % 100000) / 10000 != 5)
                                {
                                    if(i % 10 != 7 && (i % 100) / 10 != 7 && (i % 1000) / 100 != 7 && (i % 10000) / 1000 != 7 && (i % 100000) / 10000 != 7)
                                    {
                                        if(i % 10 != 9 && (i % 100) / 10 != 9 && (i % 1000) / 100 != 9 && (i % 10000) / 1000 != 9 && (i % 100000) / 10000 != 9)
                                        {
                                            Console.WriteLine(i);
                                        }
                                    }
                                }
                            }
                        }
                        

                    }


                }

               
            }
        }
    }
}