namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        int sum, digit;
            int chan,digitSum=0;
            Console.WriteLine(" 1-1000 qeder ederlerin icerisinden         hem polindrom olan       hem ededin reqemleri daxilinde 3 olan    hem ededin reqemleri cemi 10 dan boyuk olan ededler: ");

            for (int i = 0; i < 1001; i++)
               
            {
            l1:
                digitSum = 0;
                sum = 0;
                chan = i;

                while (chan>0)
                {
                    digit = chan % 10;
                    
                    if(digit==3)
                    {
                        i++;
                        goto l1;
                    }
                    digitSum += digit;
                    sum = sum * 10 + digit;
                    chan /= 10;}
                if(i==sum)
                {
                    if (digitSum > 10)
                    {
                        Console.WriteLine(i);
                    }
                }
               }
            
        }
    }
}
