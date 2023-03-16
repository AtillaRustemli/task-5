namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int s = 0;
            int l = 0;
            Console.WriteLine(" 1-1000 olan ededlerin daxilinde 3 reqemi umumiyyetle olmayib ve reqemlerinin cemi 3-e bolunen son eded: ");

        for (int i = 0; i < 1001; i++)
            {

                if (i % 10 + (i % 1000) / 100 + i / 1000 + (i % 100)/10  >11&&i%11==0)
                {
                    l++;
                    if(l==11)
                    {
                        s = i;
                    }
                    
                  
                    

                }    
                


            }



            Console.WriteLine(s);
        }
    }
}