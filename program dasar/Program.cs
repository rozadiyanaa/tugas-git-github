using System;

namespace AduDadu
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            PlayGame();
        }

        static void Intro(){

            Console.WriteLine("...");
            Console.WriteLine("Jadi kita akan memulai permainan Dadu");
            Console.WriteLine("Semoga kamu menang dalam permainan ini");
            Console.WriteLine("Jika kamu kalah maka itu bukan akhir dari permainan");
            Console.WriteLine("Coba lagi dan semangat");
            Console.WriteLine();

        }
        static void PlayGame(){
            
            int PemainRandom;
            int KomputerRandom;

            int PoinKamu = 0;
            int KomputerPoin = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine("Tekan tombol apa saja untuk menggulirkan dadu");

                Console.ReadKey();

                PemainRandom = random.Next(1, 7);
                Console.WriteLine("Kamu bergulir"+PemainRandom);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                KomputerRandom = random.Next(1, 7);
                Console.WriteLine("Komputer bergulir"+KomputerRandom);


                if (PemainRandom > KomputerRandom)
                {
                    PoinKamu++;
                    Console.WriteLine("Kamu menang di ronde ini !");
                }
                else if ( PemainRandom < KomputerRandom)
                {
                    KomputerPoin++;
                    Console.WriteLine("Komputer menang di ronde ini");
                }
                else
                {
                    Console.WriteLine("Seri !");
                }

                Console.WriteLine("Skor saat ini");
                Console.WriteLine("Kamu :"+PoinKamu+". Komputer : "+KomputerPoin+".");
                Console.WriteLine();

            }

            if (PoinKamu > KomputerPoin)
            {
                Console.WriteLine("Selamat kamu menang !!");
                Console.WriteLine("Ayo main lagi !!");
                Console.WriteLine();
            } 
            else if (PoinKamu < KomputerPoin)
            {
                System.Console.WriteLine("Sayang sekali kamu kalah !!");
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine("Ini seri !");
                System.Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}