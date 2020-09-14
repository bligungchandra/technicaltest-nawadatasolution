using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testnawadata
{
    public class SoalNomer1
    {
        public void jawabanNomer1()
        {
            Console.WriteLine("-------Berikut Ini Merupakan Logika Saya Untuk Soal Nomor 1----------");
            Console.WriteLine("Masukkan inputan:");
            string inpt = Console.ReadLine();
            //membuat inputan menjadi sebuah array
            var split = inpt.Split(',', ' ', '.');

            //cari nilai terbesarnya dulu
            int nilaiTebesar = nilaiTerbesarDalamInputUser(split);

            //adalah penampung inputan
            int outputReturn = 0;
            //buka satu satu
            foreach (var item in split)
            {
                int outputInt = Convert.ToInt32(item);
                //jika ketemu angka terbesar lanjut looping
                if (outputInt == nilaiTebesar) continue;
                //menambah tiap angka
                outputReturn += outputInt;
            }

            Console.Write("Outputnya Adalah : ");
            Console.WriteLine(outputReturn.ToString());
        }

        private int nilaiTerbesarDalamInputUser(string[] inputs) 
        {
            int temp = 0;

            foreach (var output in inputs)
            {
                var outputInt = Convert.ToInt32(output);

                if (temp < outputInt)
                {
                    temp = outputInt;
                    continue;
                }
            }

            return temp;
        }

     


    }
}
