using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testnawadata
{
    class Program
    {
        static void Main(string[] args)
        {
            SoalNomer1 jawabanNo1 = new SoalNomer1();
            SoalNomer2 jawabanNo2 = new SoalNomer2();
            string pilihanAkhir = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine("================ Helo World Inilah Test Logic =================");
                Console.WriteLine("Silahkan Pilih Soal Yang Ingin Anda Cek Outputnya            ");
                Console.WriteLine("1. Jawaban Soal Nomer 1 ");
                Console.WriteLine("2. Jawaban Soal Nomer 2 ");
                Console.Write("Pilih Salah Satu (1/2)  : ");
                string pilihanUser = Console.ReadLine();

                switch (pilihanUser)
                {
                    case "1":
                        jawabanNo1.jawabanNomer1();
                        break;
                    case "2":
                        jawabanNo2.jawabanNomer2();
                        break;

                }

                Console.Write("Lanjut Cek Lagi (Y/T) : ");
                pilihanAkhir = Console.ReadLine();

            } while (pilihanAkhir == "Y");

            Console.ReadLine();
        }

        
          
    }
}

