using System;
using System.Collections.Generic;
using System.Linq;

namespace Praktikum_Week_15
{
    class Program
    {
        private static void TukarHuruf(ref char hurufPertama, ref char hurufKedua)
        {
            if (hurufPertama == hurufKedua) 
                return;
            var counter = hurufPertama;
            hurufPertama = hurufKedua;
            hurufKedua = counter;
        }
        private static void HasilPermutasiInput(char[] list, int cekHurufPertama, int cekHurufKedua)
        {
            if (cekHurufPertama == cekHurufKedua)
                Console.WriteLine(list);
            else
                for (int hasilPermutasi = cekHurufPertama; hasilPermutasi <= cekHurufKedua; hasilPermutasi++)
                {
                    TukarHuruf(ref list[cekHurufPertama], ref list[hasilPermutasi]);
                    HasilPermutasiInput(list, cekHurufPertama + 1, cekHurufKedua);
                    TukarHuruf(ref list[cekHurufPertama], ref list[hasilPermutasi]);
                }
        }
        public static void HasilPermutasiInput(char[] list)
        {
            int x = list.Length - 1;
            HasilPermutasiInput(list, 0, x);
        }
        static void Main(string[] args)
        {
            Console.Title = "Praktikum Week 15";
            while (true)
            {
                Console.Write("Masukkan input : ");
                string inputHuruf = Console.ReadLine();
                inputHuruf = String.Concat(inputHuruf.Split(','));
                char[] hasilInput = inputHuruf.ToCharArray();
                if (hasilInput.Length != hasilInput.Distinct().Count())
                    Console.WriteLine("HURUF ADA YANG KEMBAR\n");
                else
                {
                    HasilPermutasiInput(hasilInput);
                    Console.Write("\n");
                }
            }
        }
    }
}