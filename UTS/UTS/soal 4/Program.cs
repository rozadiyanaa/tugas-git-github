using System;

namespace UTS
{
    class soalempat
    {
        //Membuat program permainan suit(batu, gunting, kertas),user diminta untuk menginput character tertentu(b/g/k/e) untuk mulai bermain
        static void Main(string[] args)
        {
          int menang = 0;
          int kalah = 0;
          int seri = 0;
          char pemain = ' ';
          Random random = new Random();

          while (pemain != 'e')
          {
            Console.Write("Choose [b]atu, [g]unting, [k]ertas, or [e]xit: ");
            pemain = Convert.ToChar(Console.ReadLine());

            if (pemain == 'e')
            {
                break;
            }
            int comp = random.Next(1,4);

            if (pemain == 'b')
            {
                if (comp == 1)
                {
                    Console.WriteLine("Komputer memilih batu");
                    Console.WriteLine("Seri.");
                    seri++;
                }
                else if (comp == 2)
                {
                    Console.WriteLine("Komputer memilih gunting");
                    Console.WriteLine("Anda Menang.");
                    menang++;
                }
                else if (comp == 3)
                {
                    Console.WriteLine("Komputer memilih kertas");
                    Console.WriteLine("Anda Kalah.");
                    kalah++;
                }
            }
            else if (pemain == 'g')
            {
                if (comp == 1)
                {
                    Console.WriteLine("Komputer memilih batu");
                    Console.WriteLine("Anda Kalah.");
                    kalah++;
                }
                else if (comp == 2)
                {
                    Console.WriteLine("Komputer memilih gunting");
                    Console.WriteLine("Seri.");
                    seri++;
                }
                else if (comp ==3)
                {
                    Console.WriteLine("Komputer memilih kertas");
                    Console.WriteLine("Anda Menang.");
                    menang++;
                }
            }
            else if (pemain == 'k')
            {
                if (comp == 1)
                {
                    Console.WriteLine("Komputer memilih batu");
                    Console.WriteLine("Anda Menang.");
                    menang++;
                }
                else if (comp == 2)
                {
                    Console.WriteLine("Komputer memilih gunting");
                    Console.WriteLine("Anda Kalah.");
                    kalah++;
                }
                else if (comp ==3)
                {
                    Console.WriteLine("Komputer memilih kertas");
                    Console.WriteLine("Seri.");
                    seri++;
                }
            }
            Console.WriteLine("Skor: "+menang+" menang, "+kalah+" kalah, "+seri+" seri");
            Console.WriteLine("Tekan Enter untuk melanjutkan permainan..");
            Console.ReadKey();
            Console.Clear();
          } 
        }
    }
}   