namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int k=0;
            for (int i = 0; i < 1001; i++)
            {
                 k+= i;


            }
            if(k%7==0) {
                Console.WriteLine($"Beli, tam bolunur ve cavab {k/7}-a beraberdir");
            }
            else
            {
                Console.WriteLine("Eded 7-e tam bolunmur");
            }
            
        }
                

            
        }
    }
