using System;

namespace UTS
{
    class soaltiga
    {
        //membuat sebuah program untuk menghitung denda pengembalian buku di perpustakaan Fakultas Teknik
        static void Main(string[] args)
        {
            int totaldenda = 0;
            int hari = 0;
            Console.Write("Menginput jumlah hari peminjaman : ");
            hari = int.Parse(Console.ReadLine());
            if (hari <= 5)
            {
                Console.WriteLine("Tidak ada denda");
            }
            else if (hari > 5 && hari <= 10)
            {
                totaldenda = (hari - 5) * 10000;
            }
            else if (hari > 10 && hari <= 30)
            {
                totaldenda = (hari - 10) * 20000 + 50000;
            }
            else if (hari > 30)
            {
                totaldenda = (hari - 30) * 30000 + 50000 + 400000;
                Console.WriteLine("keanggotaan anda dibatalkan.");
            }
            Console.WriteLine("Total denda : Rp." +totaldenda);
        }
    }
}