using System;

namespace CSHARPharjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vastaus = onkoSamat(1, 2);
            Console.WriteLine("Olivatko luvut samat: " + vastaus);
        }
        public static bool onkoSamat(int luku1, int luku2)
        {
            if(luku1 == luku2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
