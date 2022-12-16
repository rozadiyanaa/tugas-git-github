using System;

namespace UTS
{
    class soalsatu
    {
        public static void Main(string[] args)
        {
            string nama, nim, konsentrasi;
            Console.WriteLine("Nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("Nim : ");
            nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi : ");
            konsentrasi = Console.ReadLine();

            Console.WriteLine("|*******************************|");
            Console.WriteLine("{0,-8} {1,24}", "|Nama:", nama+"|");
            Console.WriteLine("{0,-16} {1,16}", "|", nim+"|");
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("{0,-16} {1,16}", "|", konsentrasi+"|");
            Console.WriteLine("|*******************************|");
        }
    }
}
