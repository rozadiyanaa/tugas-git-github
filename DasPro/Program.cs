using System;
using System.Collections.Generic;

namespace TebakKata
{
    class Program
    {
        static int kesempatan = 5;
        static String katamisteri = "bangtan";
        static List<string> listtebakan = new List<string>{};
        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            EndGame();
        }
        static void Intro()
        {
            Console.WriteLine("Hallo, hari ini kita akan bermain tebak kata");
            Console.WriteLine($"Kamu punya{kesempatan} untuk menebak kata misteri hari ini");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan idol");
            Console.WriteLine($"Kata tersebut terdiri dari {katamisteri.Length} huruf");
            Console.WriteLine("Apakah yang dimaksud?");
            Console.ReadKey();
            Console.WriteLine();
        }
        static void PlayGame()
        {
            while (kesempatan > 0)
            {
                Console.Write("Apa huruf tebakanmu?(pilih a-z).");
                string input = Console.ReadLine();
                listtebakan.Add(input);
                if (jawaban(katamisteri,listtebakan))
                {
                    Console.WriteLine("Selamat kamu berhasil");
                    Console.WriteLine($"Kata misteri hari ini adalah {katamisteri}");
                    break;
                }else if (katamisteri.Contains(input))
                {
                    Console.WriteLine("Huruf itu ada didalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya");
                    Console.WriteLine(Cekhuruf(katamisteri,listtebakan));
                }
                else
                {
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan kamu tinggal {kesempatan}");
                }
                //showend();
                //break
            
                if (kesempatan == 0)
                {
                    //Console.WriteLine("Maaf kesempatan kamu telah habis.");
                    //Console.WriteLine($" jawabannya adalah : {kesempatan} ");
                    EndGame();
                    break;
                }
               
            }
            
        }
                        static bool jawaban(string katamisteri,List<string> list){
                    bool status = false;
                    for (int i = 0; i < katamisteri.Length; i++)
                    {
                        string c = Convert.ToString(katamisteri[i]);
                        
                        if (list.Contains(c))
                        {
                            status = true;
                        }else{
                            return status = false;
                        }
                    }
                    return status;
                }
                static string Cekhuruf(string katamisteri, List<string> list){
                    string x = "";
                    for (int i = 0; i < katamisteri.Length; i++)
                    {
                        string c = Convert.ToString(katamisteri[i]);
                        if (list.Contains(c))
                        {
                            x = x + c;
                        }else{
                            x = x + ".";
                        }
                    }
                    return x;
                }

                 static void EndGame(){
                    Console.WriteLine("Finish");
                    Console.WriteLine($"jawabannya adalah {katamisteri}");
                }

        
    }
}
        
