using System;

namespace UTS
{
    class soaldua
    {
        //membuat tebak angka
        static void Main(string[] args)
        {
            int Answer = 0;
            Random rnd = new Random();
            int check = rnd.Next(1,101);
            while (Answer != check)
            {
                Console.Write("Tebak angka antara 1-100: ");
                Answer = Convert.ToInt32(Console.ReadLine());
                if (Answer < check)
                {
                    Console.WriteLine("Salah, angka terlalu rendah");
                }
                else if (Answer > check)
                {
                    Console.WriteLine("Salah, angka terlalu tinggi");
                }
                else
                {
                    Console.WriteLine("Selamat!! Anda berhasil menebak angka");
                    Console.WriteLine("Thank you for playing.");
                    Console.ReadKey();
                }
            }
        }
    
    }
}
