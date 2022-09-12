using System;
//Program napisany przez Olafa Świetlika dnia 12.09.2022
//Oparty na module Random generator bezpiecznych haseł
//Zawiera małe, duże litery oraz cyfry i znaki specjalne
namespace Giganci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wielkie = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string male = wielkie.ToLower();
            string cyfry = "0123456789";
            string znakiS = "!@#$%^&*()<>,.?/';:{}[]|/*-+=_~`" ;

            Console.WriteLine("----------Generator Bezpiecznych haseł----------");

            Console.Write("Ile wielkich liter ma znaleźć się w haśle?");
            int LiczbaWielkich = int.Parse(Console.ReadLine());

            Console.Write("Ile małych liter ma znaleźć się w haśle?");
            int LiczbaMalych= int.Parse(Console.ReadLine());

            Console.Write("Ile cyfr ma znaleźć się w haśle?");
            int LiczbaCyfr = int.Parse(Console.ReadLine());

            Console.Write("Ile znaków specjalnych ma znaleźć się w haśle?");
            int LiczbaZnakow = int.Parse(Console.ReadLine());

            Random r = new Random();
            string hasło = "";  
            
            for(int i =0; i < LiczbaWielkich; i++)
            {
                char znak1 = wielkie[r.Next(wielkie.Length)];
                hasło = hasło.Insert(r.Next(hasło.Length + 1), znak1.ToString());
            }
            for (int i = 0; i < LiczbaMalych; i++)
            {
                char znak2 = male[r.Next(male.Length)];
                hasło = hasło.Insert(r.Next(hasło.Length + 1), znak2.ToString());
            }
            for (int i = 0; i < LiczbaCyfr; i++)
            {
                char znak3 = cyfry[r.Next(cyfry.Length)];
                hasło = hasło.Insert(r.Next(hasło.Length + 1), znak3.ToString());
            }
            for (int i = 0; i < LiczbaZnakow; i++)
            {
                char znak4 = znakiS[r.Next(znakiS.Length)];
                hasło = hasło.Insert(r.Next(hasło.Length + 1), znak4.ToString());
            }
            Console.WriteLine($"Wygenerowane hasło to: {hasło}");
            Console.WriteLine("----------Działanie zakończone----------");
            Console.ReadKey();

        }
    }
}
