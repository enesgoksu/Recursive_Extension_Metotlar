namespace Recursive_Extension_Metotlar.Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive - Öz Yinemeli
            // 3^4

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
                Console.WriteLine(result);
            {
                
            }
        }
    }

    public class Islemler{

        public int expo(int sayi, int üs)
        {
            if(üs < 2)
            return sayi;
            return expo(sayi,üs-1)*sayi;
        }
    }
}